using System.Drawing.Text;
using System.Speech.Synthesis;
namespace noteshi
{
    public partial class main : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public main()
        {
            synth.SetOutputToDefaultAudioDevice();
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
            }
            else
            {
                richTextBox1.WordWrap = false;
            }
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor += (float)0.1;
            }
            catch
            {
                MessageBox.Show("Can't zoom in further");
            }
        }
        private void setToDefaultZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.ZoomFactor -= (float)0.1;
            }
            catch
            {
                MessageBox.Show("Can't zoom out further");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Letters: " + Convert.ToString(Convert.ToInt32(richTextBox1.Text.Length));
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.SelectedText = string.Empty;
            }
            else
            {
                int pos = richTextBox1.SelectionStart;
                if (pos < richTextBox1.Text.Length)
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(pos, 1);
                    richTextBox1.SelectionStart = pos;
                }
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void righttoleftToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (righttoleftReadingToolStripMenuItem.Checked)
            {
                richTextBox1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                richTextBox1.RightToLeft = RightToLeft.No;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calc calc = new Calc();
            calc.Show();
        }

        private void ballMaybeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _8ball ball = new _8ball();
            ball.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            synth.Volume = 100;
            synth.SpeakAsync(richTextBox1.Text);
        }

        private void stopReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (synth != null)
            {
                synth.SpeakAsyncCancelAll();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();
                string cleanedText = clipboardText.TrimEnd();
                richTextBox1.SelectedText = cleanedText;
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (richTextBox1.SelectionLength > 0 && richTextBox1.SelectedText.EndsWith("\n"))
            {
                richTextBox1.SelectionLength -= 1;
            }
        }
    }
}
