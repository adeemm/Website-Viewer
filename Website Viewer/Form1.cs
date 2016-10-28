using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Website_Viewer
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (urlBox.Text == "" || urlBox.Text == " ")
            {
                MessageBox.Show("Enter A Website", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!urlBox.Text.Contains("."))
            {
                MessageBox.Show("Enter A Valid Website", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (bypass.Text == "")
            {
                MessageBox.Show("Select A Bypass Method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var names = typeof(Bypass_List).GetFields().Select(field => field.Name).ToArray();
                foreach (string x in names)
                {
                    if (x.Contains(bypass.Text))
                    {
                        string value = (string)typeof(Bypass_List).GetField(x).GetValue(x);
                        Form2 form2 = new Form2();
                        Website_Viewer.Bypass_List.site = "https://" + "translate.google" + value + "/translate?hl=en&sl=sq&tl=en&u=" + urlBox.Text;
                        form2.Show();
                    }
                }
            }
        }
    }
}
