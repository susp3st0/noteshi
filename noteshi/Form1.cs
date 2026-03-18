using System.Drawing.Text;

namespace noteshi
{
    public partial class Form1 : Form
    {
        public Form1()
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
            // Show the Apply button so the user can apply without closing the dialog.
            fontDialog1.ShowApply = true;

            // Show dialog with this form as owner and apply the font if the user clicks OK.
            if (fontDialog1.ShowDialog(this) == DialogResult.OK && fontDialog1?.Font is not null)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }
    }
}
