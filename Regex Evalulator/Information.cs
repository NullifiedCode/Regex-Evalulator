using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite;

namespace Regex_Evalulator
{
    public partial class Information : MetroForm
    {
        Main frm1 = null;
        public Information(Main frm)
        {
            InitializeComponent();
            frm1 = frm;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            if (frm1.randomColor)
            {
                this.AccentColor = frm1.AccentColor;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Control c = this.Controls[i];
                    if (c.GetType() == typeof(MetroLabel))
                        ((MetroLabel)c).ForeColor = frm1.AccentColor;
                    if (c.GetType() == typeof(MetroButton))
                        ((MetroButton)c).PressedColor = frm1.AccentColor;
                    if (c.GetType() == typeof(LinkLabel))
                    {
                        ((LinkLabel)c).LinkColor = frm1.AccentColor;
                        ((LinkLabel)c).VisitedLinkColor = frm1.AccentColor;
                        ((LinkLabel)c).ActiveLinkColor = frm1.AccentColor;
                    }
                }


            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NullifiedCode/");
        }
    }
}
