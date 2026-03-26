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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAssoonToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            selectToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            selectAllToolStripMenuItem1 = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            calculatorToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            wordWarpToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem1 = new ToolStripMenuItem();
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
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cutToolStripMenuItem1 = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            righttoleftReadingToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ballMaybeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, selectToolStripMenuItem, toolsToolStripMenuItem, fToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAssoonToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(40, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(174, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(174, 22);
            saveToolStripMenuItem.Text = "Save...";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAssoonToolStripMenuItem
            // 
            saveAssoonToolStripMenuItem.Name = "saveAssoonToolStripMenuItem";
            saveAssoonToolStripMenuItem.Size = new Size(174, 22);
            saveAssoonToolStripMenuItem.Text = "Save as...(soon)";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(174, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // selectToolStripMenuItem
            // 
            selectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem1, pasteToolStripMenuItem1, deleteToolStripMenuItem1, toolStripSeparator2, selectAllToolStripMenuItem1 });
            selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            selectToolStripMenuItem.Size = new Size(43, 20);
            selectToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            cutToolStripMenuItem.Size = new Size(179, 22);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem1
            // 
            copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            copyToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+C";
            copyToolStripMenuItem1.Size = new Size(179, 22);
            copyToolStripMenuItem1.Text = "Copy";
            copyToolStripMenuItem1.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+P";
            pasteToolStripMenuItem1.Size = new Size(179, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.ShortcutKeyDisplayString = "Del";
            deleteToolStripMenuItem1.Size = new Size(179, 22);
            deleteToolStripMenuItem1.Text = "Delete";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem1
            // 
            selectAllToolStripMenuItem1.Name = "selectAllToolStripMenuItem1";
            selectAllToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+A";
            selectAllToolStripMenuItem1.Size = new Size(179, 22);
            selectAllToolStripMenuItem1.Text = "Select all";
            selectAllToolStripMenuItem1.Click += selectAllToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculatorToolStripMenuItem, ballMaybeToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(52, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // calculatorToolStripMenuItem
            // 
            calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            calculatorToolStripMenuItem.Size = new Size(180, 22);
            calculatorToolStripMenuItem.Text = "Calculator";
            calculatorToolStripMenuItem.Click += calculatorToolStripMenuItem_Click;
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { wordWarpToolStripMenuItem, fontToolStripMenuItem1 });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(67, 20);
            fToolStripMenuItem.Text = "Format";
            // 
            // wordWarpToolStripMenuItem
            // 
            wordWarpToolStripMenuItem.CheckOnClick = true;
            wordWarpToolStripMenuItem.Name = "wordWarpToolStripMenuItem";
            wordWarpToolStripMenuItem.Size = new Size(148, 22);
            wordWarpToolStripMenuItem.Text = "Word warp";
            wordWarpToolStripMenuItem.Click += wordWarpToolStripMenuItem_Click;
            // 
            // fontToolStripMenuItem1
            // 
            fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            fontToolStripMenuItem1.Size = new Size(148, 22);
            fontToolStripMenuItem1.Text = "Font...";
            fontToolStripMenuItem1.Click += fontToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem, windowsTransparencyToolStripMenuItem });
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
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(46, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(113, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveBorder;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.EnableAutoDragDrop = true;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator1, cutToolStripMenuItem1, pasteToolStripMenuItem, copyToolStripMenuItem, deleteToolStripMenuItem, selectAllToolStripMenuItem, righttoleftReadingToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 186);
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            undoToolStripMenuItem.Size = new Size(210, 22);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Z";
            redoToolStripMenuItem.Size = new Size(210, 22);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(207, 6);
            // 
            // cutToolStripMenuItem1
            // 
            cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            cutToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl+X";
            cutToolStripMenuItem1.Size = new Size(210, 22);
            cutToolStripMenuItem1.Text = "Cut";
            cutToolStripMenuItem1.Click += cutToolStripMenuItem1_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
            pasteToolStripMenuItem.Size = new Size(210, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            copyToolStripMenuItem.Size = new Size(210, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            deleteToolStripMenuItem.Size = new Size(210, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.ToolTipText = "why windows notepad have this\r\njust simply press backspace or del";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            selectAllToolStripMenuItem.Size = new Size(210, 22);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // righttoleftReadingToolStripMenuItem
            // 
            righttoleftReadingToolStripMenuItem.CheckOnClick = true;
            righttoleftReadingToolStripMenuItem.Name = "righttoleftReadingToolStripMenuItem";
            righttoleftReadingToolStripMenuItem.Size = new Size(210, 22);
            righttoleftReadingToolStripMenuItem.Text = "Right-to-left reading";
            righttoleftReadingToolStripMenuItem.CheckedChanged += righttoleftToolStripMenuItem_CheckedChanged;
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
            // ballMaybeToolStripMenuItem
            // 
            ballMaybeToolStripMenuItem.Name = "ballMaybeToolStripMenuItem";
            ballMaybeToolStripMenuItem.Size = new Size(180, 22);
            ballMaybeToolStripMenuItem.Text = "8-ball... maybe";
            ballMaybeToolStripMenuItem.Click += ballMaybeToolStripMenuItem_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "main";
            Text = "noteshi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private FontDialog fontDialog1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem windowsTransparencyToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInToolStripMenuItem;
        private ToolStripMenuItem zoomOutToolStripMenuItem;
        private ToolStripMenuItem setToDefaultZoomToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem1;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem cutToolStripMenuItem1;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem wordWarpToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem1;
        private ToolStripMenuItem selectAllToolStripMenuItem1;
        private ToolStripMenuItem righttoleftReadingToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem calculatorToolStripMenuItem;
        private ToolStripMenuItem saveAssoonToolStripMenuItem;
        private ToolStripMenuItem ballMaybeToolStripMenuItem;
    }
}
