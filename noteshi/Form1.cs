using System.Drawing.Text;

namespace noteshi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            this.Text = "noteshi";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Save";
                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.OverwritePrompt = true;

                if (saveFileDialog.ShowDialog(this) == DialogResult.OK
                    && !string.IsNullOrWhiteSpace(saveFileDialog.FileName))
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Open";
                if (openFileDialog.ShowDialog(this) == DialogResult.OK
                    && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                    this.Text = "noteshi - " + System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                var url = e?.LinkText;
                if (string.IsNullOrWhiteSpace(url))
                {
                    return;
                }

                if (!System.Uri.IsWellFormedUriString(url, System.UriKind.Absolute))
                {
                    url = "http://" + url;
                }

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };

                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to open link: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            if (fontDialog1?.Font is not null)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowApply = true;

            if (fontDialog1.ShowDialog(this) == DialogResult.OK && fontDialog1?.Font is not null)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void transparentbutton_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            toolStripMenuItem3.Checked = true;
            if (toolStripMenuItem5.Checked = true || toolStripMenuItem2.Checked == true || toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem5.Checked = false;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem4.Checked = false;
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
            toolStripMenuItem5.Checked = true;
            if (toolStripMenuItem3.Checked = true || toolStripMenuItem2.Checked == true || toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem4.Checked = false;
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.75;
            toolStripMenuItem5.Checked = true;
            if (toolStripMenuItem3.Checked = true || toolStripMenuItem2.Checked == true || toolStripMenuItem5.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem2.Checked = false;
                toolStripMenuItem5.Checked = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.25;
            toolStripMenuItem5.Checked = true;
            if (toolStripMenuItem3.Checked = true || toolStripMenuItem5.Checked == true || toolStripMenuItem4.Checked == true)
            {
                toolStripMenuItem3.Checked = false;
                toolStripMenuItem5.Checked = false;
                toolStripMenuItem4.Checked = false;
            }
        }

        private void wordWarpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //word warp
            if (wordWarpToolStripMenuItem.Checked == true)
            {
                richTextBox1.WordWrap = true;
            } else
            {
                richTextBox1.WordWrap = false;
            }
        }
    }
}
