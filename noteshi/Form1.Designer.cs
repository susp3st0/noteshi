namespace noteshi
{
    partial class main
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInToolStripMenuItem = new ToolStripMenuItem();
            zoomOutToolStripMenuItem = new ToolStripMenuItem();
            setToDefaultZoomToolStripMenuItem = new ToolStripMenuItem();
            windowsTransparencyToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            wordWarpToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, selectToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(164, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(164, 22);
            saveToolStripMenuItem.Text = "Save...";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(164, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem });
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(43, 20);
            selectToolStripMenuItem.Text = "Edit";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(103, 22);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, windowsTransparencyToolStripMenuItem, wordWarpToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(52, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInToolStripMenuItem, zoomOutToolStripMenuItem, setToDefaultZoomToolStripMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(227, 22);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+=";
            zoomInToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomInToolStripMenuItem.Size = new Size(203, 22);
            zoomInToolStripMenuItem.Text = "Zoom in";
            zoomInToolStripMenuItem.Click += zoomInToolStripMenuItem_Click;
            // 
            // zoomOutToolStripMenuItem
            // 
            zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
            zoomOutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomOutToolStripMenuItem.Size = new Size(203, 22);
            zoomOutToolStripMenuItem.Text = "Zoom out";
            zoomOutToolStripMenuItem.Click += zoomOutToolStripMenuItem_Click;
            // 
            // setToDefaultZoomToolStripMenuItem
            // 
            setToDefaultZoomToolStripMenuItem.Name = "setToDefaultZoomToolStripMenuItem";
            setToDefaultZoomToolStripMenuItem.Size = new Size(203, 22);
            setToDefaultZoomToolStripMenuItem.Text = "Set to default zoom";
            setToDefaultZoomToolStripMenuItem.Click += setToDefaultZoomToolStripMenuItem_Click;
            // 
            // windowsTransparencyToolStripMenuItem
            // 
            windowsTransparencyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5 });
            windowsTransparencyToolStripMenuItem.Name = "windowsTransparencyToolStripMenuItem";
            windowsTransparencyToolStripMenuItem.Size = new Size(227, 22);
            windowsTransparencyToolStripMenuItem.Text = "Windows transparency";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.CheckOnClick = true;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(99, 22);
            toolStripMenuItem2.Text = "25%";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.CheckOnClick = true;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(99, 22);
            toolStripMenuItem3.Text = "50%";
            toolStripMenuItem3.Click += transparentbutton_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.CheckOnClick = true;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(99, 22);
            toolStripMenuItem4.Text = "75%";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Checked = true;
            toolStripMenuItem5.CheckOnClick = true;
            toolStripMenuItem5.CheckState = CheckState.Checked;
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(99, 22);
            toolStripMenuItem5.Text = "100%";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // wordWarpToolStripMenuItem
            // 
            wordWarpToolStripMenuItem.CheckOnClick = true;
            wordWarpToolStripMenuItem.Name = "wordWarpToolStripMenuItem";
            wordWarpToolStripMenuItem.Size = new Size(227, 22);
            wordWarpToolStripMenuItem.Text = "Word warp";
            wordWarpToolStripMenuItem.Click += wordWarpToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveBorder;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 426);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            richTextBox1.LinkClicked += richTextBox1_LinkClicked;
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // fontDialog1
            // 
            fontDialog1.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(72, 17);
            toolStripStatusLabel1.Text = "Letters: 0";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private FontDialog fontDialog1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem windowsTransparencyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem wordWarpToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem setToDefaultZoomToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
