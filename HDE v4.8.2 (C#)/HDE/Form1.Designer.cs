namespace HDE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            _MENU = new ToolStrip();
            _MENU_FILE = new ToolStripDropDownButton();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            compileToolStripMenuItem = new ToolStripMenuItem();
            compileAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            _CURRENT_TASK = new GroupBox();
            _CURRENT_PROGRESS = new ProgressBar();
            _CMD = new RichTextBox();
            _CODE = new RichTextBox();
            _STRUCT = new TreeView();
            _INFO = new RichTextBox();
            _MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            _CURRENT_TASK.SuspendLayout();
            SuspendLayout();
            // 
            // _MENU
            // 
            _MENU.Items.AddRange(new ToolStripItem[] { _MENU_FILE });
            _MENU.Location = new Point(0, 0);
            _MENU.Name = "_MENU";
            _MENU.Size = new Size(1484, 25);
            _MENU.TabIndex = 0;
            _MENU.Text = "toolStrip1";
            // 
            // _MENU_FILE
            // 
            _MENU_FILE.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, compileToolStripMenuItem, compileAsToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            _MENU_FILE.Image = (Image)resources.GetObject("_MENU_FILE.Image");
            _MENU_FILE.ImageTransparentColor = Color.Magenta;
            _MENU_FILE.Name = "_MENU_FILE";
            _MENU_FILE.Size = new Size(54, 22);
            _MENU_FILE.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 22);
            openToolStripMenuItem.Text = "Open..";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(138, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(141, 22);
            saveToolStripMenuItem.Text = "Save..";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(141, 22);
            saveAsToolStripMenuItem.Text = "Save As..";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(138, 6);
            // 
            // compileToolStripMenuItem
            // 
            compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            compileToolStripMenuItem.Size = new Size(141, 22);
            compileToolStripMenuItem.Text = "Compile..";
            // 
            // compileAsToolStripMenuItem
            // 
            compileAsToolStripMenuItem.Name = "compileAsToolStripMenuItem";
            compileAsToolStripMenuItem.Size = new Size(141, 22);
            compileAsToolStripMenuItem.Text = "Compile As..";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(138, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 25);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1484, 736);
            splitContainer1.SplitterDistance = 494;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(_INFO);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(_STRUCT);
            splitContainer2.Size = new Size(494, 736);
            splitContainer2.SplitterDistance = 411;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(_CODE);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(_CMD);
            splitContainer3.Panel2.Controls.Add(_CURRENT_TASK);
            splitContainer3.Size = new Size(986, 736);
            splitContainer3.SplitterDistance = 474;
            splitContainer3.TabIndex = 0;
            // 
            // _CURRENT_TASK
            // 
            _CURRENT_TASK.Controls.Add(_CURRENT_PROGRESS);
            _CURRENT_TASK.Dock = DockStyle.Bottom;
            _CURRENT_TASK.Location = new Point(0, 209);
            _CURRENT_TASK.Name = "_CURRENT_TASK";
            _CURRENT_TASK.Size = new Size(986, 49);
            _CURRENT_TASK.TabIndex = 0;
            _CURRENT_TASK.TabStop = false;
            _CURRENT_TASK.Text = "N/A";
            // 
            // _CURRENT_PROGRESS
            // 
            _CURRENT_PROGRESS.Dock = DockStyle.Fill;
            _CURRENT_PROGRESS.Location = new Point(3, 19);
            _CURRENT_PROGRESS.Name = "_CURRENT_PROGRESS";
            _CURRENT_PROGRESS.Size = new Size(980, 27);
            _CURRENT_PROGRESS.TabIndex = 0;
            // 
            // _CMD
            // 
            _CMD.BackColor = Color.Black;
            _CMD.Dock = DockStyle.Fill;
            _CMD.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _CMD.ForeColor = Color.White;
            _CMD.Location = new Point(0, 0);
            _CMD.Name = "_CMD";
            _CMD.Size = new Size(986, 209);
            _CMD.TabIndex = 1;
            _CMD.Text = "";
            // 
            // _CODE
            // 
            _CODE.BackColor = Color.FromArgb(224, 224, 224);
            _CODE.Dock = DockStyle.Fill;
            _CODE.Location = new Point(0, 0);
            _CODE.Name = "_CODE";
            _CODE.Size = new Size(986, 474);
            _CODE.TabIndex = 0;
            _CODE.Text = "";
            // 
            // _STRUCT
            // 
            _STRUCT.Dock = DockStyle.Fill;
            _STRUCT.Location = new Point(0, 0);
            _STRUCT.Name = "_STRUCT";
            _STRUCT.Size = new Size(494, 321);
            _STRUCT.TabIndex = 0;
            // 
            // _INFO
            // 
            _INFO.Dock = DockStyle.Fill;
            _INFO.Location = new Point(0, 0);
            _INFO.Name = "_INFO";
            _INFO.Size = new Size(494, 411);
            _INFO.TabIndex = 0;
            _INFO.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            Controls.Add(splitContainer1);
            Controls.Add(_MENU);
            Name = "Form1";
            Text = "HDE v4.8.2";
            _MENU.ResumeLayout(false);
            _MENU.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            _CURRENT_TASK.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip _MENU;
        private ToolStripDropDownButton _MENU_FILE;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem compileAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TreeView _STRUCT;
        private SplitContainer splitContainer3;
        private RichTextBox _CODE;
        private RichTextBox _CMD;
        private GroupBox _CURRENT_TASK;
        private ProgressBar _CURRENT_PROGRESS;
        private RichTextBox _INFO;
    }
}
