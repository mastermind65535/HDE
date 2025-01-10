using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace HDE
{
    public partial class Form1 : Form
    {
        public static string _TARGET = "";

        public static RichTextBoxWriter _writer;

        public static string _WORKING_PATH = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        public static string _DIE_PATH = Path.Combine(_WORKING_PATH, "bin\\DIE");
        public static string _PYD_PATH = Path.Combine(_WORKING_PATH, "bin\\PYD");

        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(Path.Combine(_WORKING_PATH, "bin"));
            Directory.CreateDirectory(Path.Combine(_WORKING_PATH, "bin\\DIE"));
            Directory.CreateDirectory(Path.Combine(_WORKING_PATH, "bin\\PYD"));

            _writer = new RichTextBoxWriter(_CMD);
            Console.SetOut(_writer);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async Task Load()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select An Executable File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _TARGET = ofd.FileName;

                string Language = "";
                string Compiler = "";
                string Linker = "";

                Console.WriteLine($"[+] Loading Executable Information Using Detect It Easy...");
                string DIE_RESULT = execute.cmd(_DIE_PATH, $"diec -d -g -a --verbose --heuristicscan \"{_TARGET}\"");
                string[] lines = DIE_RESULT.Split('\n');

                foreach (string line in lines)
                {
                    string info = line.Trim();
                    int colonIndex = info.IndexOf(':');

                    if (colonIndex != -1)
                    {
                        string key = info.Substring(0, colonIndex).Trim();
                        string value = info.Substring(colonIndex + 1).Trim();

                        if (key.Contains("Language"))
                        {
                            Language = value;
                            Console.WriteLine($"[+] Language Information Found: {Language}");
                        }
                        else if (key.Contains("Compiler"))
                        {
                            Compiler = value;
                            Console.WriteLine($"[+] Compiler Information Found: {Compiler}");
                        }
                        else if (key.Contains("Linker"))
                        {
                            Linker = value;
                            Console.WriteLine($"[+] Linker Information Found: {Linker}");
                        }
                    }
                }

                if (Language == "Python")
                {
                    Console.WriteLine("[+] Starting Pydecompiler...");
                    execute.cmd(_PYD_PATH, $"pyd {_TARGET}");
                    string EXTRACT_RESULT = Path.Combine($"{_PYD_PATH}", $"{_TARGET.Split('\\').Last()}_extracted");

                    Console.WriteLine("[+] Moving parse result...");
                    string RESULT = Path.Combine(_WORKING_PATH, DateTime.Now.ToString("yyyyMMddHHmmss"));
                    Directory.Move(EXTRACT_RESULT, RESULT);
                    Directory.Delete(EXTRACT_RESULT);

                    Console.WriteLine("[+] Starting decompiler...");
                    string MAIN_PYC = $"{_TARGET.Split('\\').Last().Split('.').First()}.pyc";
                    execute.cmd(_PYD_PATH, $"pycdc {Path.Combine(RESULT, MAIN_PYC)} >> result.py");

                    string CODE = File.ReadAllText(Path.Combine(RESULT, "result.py"));
                    _CODE.Text = CODE;
                }   
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Load();
        }
    }

    public class execute
    {
        public static string cmd(string path, string cmd)
        {
            // Create a new process to run the command
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";  // Run the Command Prompt (cmd)
            process.StartInfo.Arguments = "/C " + cmd; // /C runs the command and terminates the cmd window
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.RedirectStandardOutput = true; // Redirect the standard output
            process.StartInfo.RedirectStandardError = true; // Redirect the error output
            process.StartInfo.UseShellExecute = false; // We need to redirect input/output
            process.StartInfo.CreateNoWindow = true; // Don't show the command prompt window

            // Capture the output and error asynchronously
            process.Start();

            string output = process.StandardOutput.ReadToEnd();  // Capture standard output
            string error = process.StandardError.ReadToEnd();    // Capture error output

            // Combine output and error (if any)
            string result = output + error;

            process.WaitForExit();

            return result;
        }
    }

    public class RichTextBoxWriter : TextWriter
    {
        private RichTextBox _richTextBox;

        public RichTextBoxWriter(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        public override void Write(char value)
        {
            _richTextBox.AppendText(value.ToString());
            _richTextBox.ScrollToCaret(); // Auto scroll to the bottom
        }

        public override void Write(string value)
        {
            _richTextBox.AppendText(value);
            _richTextBox.ScrollToCaret(); // Auto scroll to the bottom
        }

        public override void WriteLine(string value)
        {
            _richTextBox.AppendText(value + Environment.NewLine);
            _richTextBox.ScrollToCaret(); // Auto scroll to the bottom
        }

        public override Encoding Encoding => Encoding.Default;
    }
}
