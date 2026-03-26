using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noteshi
{
    public partial class _8ball : Form
    {
        public _8ball()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ans = { "Yes", "No", "Maybe", "I'm not sure", "Don't","go die", "hi"};
            Random answer = new Random();
            int randomIndex = answer.Next(0, ans.Length);
            string output = ans[randomIndex];
            label1.Text = output;
        }
    }
}
