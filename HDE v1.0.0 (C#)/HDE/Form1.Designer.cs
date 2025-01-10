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
            toolStrip1 = new ToolStrip();
            _FILE_MENU = new ToolStripDropDownButton();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            compileToolStripMenuItem = new ToolStripMenuItem();
            compileAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            _TASK_PROGRESS = new ToolStripProgressBar();
            _GLOBAL_TASK_LABEL = new ToolStripLabel();
            toolStripSeparator4 = new ToolStripSeparator();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            _INFO = new RichTextBox();
            _STRUCT = new TreeView();
            splitContainer3 = new SplitContainer();
            _CODE = new RichTextBox();
            _CURRENT_TASK = new GroupBox();
            _CURRENT_PROGRESS = new ProgressBar();
            _CMD = new RichTextBox();
            toolStrip1.SuspendLayout();
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { _FILE_MENU, _TASK_PROGRESS, _GLOBAL_TASK_LABEL, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1484, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // _FILE_MENU
            // 
            _FILE_MENU.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, toolStripSeparator1, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator2, compileToolStripMenuItem, compileAsToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem });
            //_FILE_MENU.Image = (Image)resources.GetObject("_FILE_MENU.Image");
            _FILE_MENU.ImageTransparentColor = Color.Magenta;
            _FILE_MENU.Name = "_FILE_MENU";
            _FILE_MENU.Size = new Size(54, 22);
            _FILE_MENU.Text = "File";
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
            // 
            // _TASK_PROGRESS
            // 
            _TASK_PROGRESS.Alignment = ToolStripItemAlignment.Right;
            _TASK_PROGRESS.Name = "_TASK_PROGRESS";
            _TASK_PROGRESS.Size = new Size(300, 22);
            // 
            // _GLOBAL_TASK_LABEL
            // 
            _GLOBAL_TASK_LABEL.Alignment = ToolStripItemAlignment.Right;
            _GLOBAL_TASK_LABEL.Name = "_GLOBAL_TASK_LABEL";
            _GLOBAL_TASK_LABEL.Size = new Size(29, 22);
            _GLOBAL_TASK_LABEL.Text = "N/A";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
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
            splitContainer1.SplitterDistance = 493;
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
            splitContainer2.Size = new Size(493, 736);
            splitContainer2.SplitterDistance = 354;
            splitContainer2.TabIndex = 0;
            // 
            // _INFO
            // 
            _INFO.BackColor = Color.White;
            _INFO.Dock = DockStyle.Fill;
            _INFO.Location = new Point(0, 0);
            _INFO.Name = "_INFO";
            _INFO.Size = new Size(493, 354);
            _INFO.TabIndex = 1;
            _INFO.Text = "";
            // 
            // _STRUCT
            // 
            _STRUCT.Dock = DockStyle.Fill;
            _STRUCT.Location = new Point(0, 0);
            _STRUCT.Name = "_STRUCT";
            _STRUCT.Size = new Size(493, 378);
            _STRUCT.TabIndex = 0;
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
            splitContainer3.Panel2.Controls.Add(_CURRENT_TASK);
            splitContainer3.Panel2.Controls.Add(_CMD);
            splitContainer3.Size = new Size(987, 736);
            splitContainer3.SplitterDistance = 494;
            splitContainer3.TabIndex = 0;
            // 
            // _CODE
            // 
            _CODE.BackColor = Color.FromArgb(224, 224, 224);
            _CODE.Dock = DockStyle.Fill;
            _CODE.Location = new Point(0, 0);
            _CODE.Name = "_CODE";
            _CODE.Size = new Size(987, 494);
            _CODE.TabIndex = 0;
            _CODE.Text = "";
            // 
            // _CURRENT_TASK
            // 
            _CURRENT_TASK.Controls.Add(_CURRENT_PROGRESS);
            _CURRENT_TASK.Dock = DockStyle.Bottom;
            _CURRENT_TASK.Location = new Point(0, 193);
            _CURRENT_TASK.Name = "_CURRENT_TASK";
            _CURRENT_TASK.Size = new Size(987, 45);
            _CURRENT_TASK.TabIndex = 1;
            _CURRENT_TASK.TabStop = false;
            _CURRENT_TASK.Text = "N/A";
            // 
            // _CURRENT_PROGRESS
            // 
            _CURRENT_PROGRESS.Dock = DockStyle.Fill;
            _CURRENT_PROGRESS.Location = new Point(3, 19);
            _CURRENT_PROGRESS.Name = "_CURRENT_PROGRESS";
            _CURRENT_PROGRESS.Size = new Size(981, 23);
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
            _CMD.ReadOnly = true;
            _CMD.Size = new Size(987, 238);
            _CMD.TabIndex = 0;
            _CMD.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 761);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "HDE v1.0.0";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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

        private ToolStrip toolStrip1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private TreeView _STRUCT;
        private RichTextBox _CODE;
        private GroupBox _CURRENT_TASK;
        private ProgressBar _CURRENT_PROGRESS;
        private RichTextBox _CMD;
        private RichTextBox _INFO;
        private ToolStripDropDownButton _FILE_MENU;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem compileToolStripMenuItem;
        private ToolStripMenuItem compileAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripProgressBar _TASK_PROGRESS;
        private ToolStripLabel _GLOBAL_TASK_LABEL;
        private ToolStripSeparator toolStripSeparator4;
    }
}
