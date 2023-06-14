using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicks
{
    public partial class Form1 : Form
    {
        int clicks = 0;
        public Form1()
        {
            InitializeComponent();
            Click += new EventHandler(ClickHandler);
        }
        private void ClickHandler(object sender, EventArgs e)
        {
            clicks++;
            label1.Text = "Clicks: " + clicks.ToString();
        }
    }
}
