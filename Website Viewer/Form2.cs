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
    public partial class Form2 : DevComponents.DotNetBar.Office2007Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Website_Viewer.Bypass_List.site);
        }
    }
}
