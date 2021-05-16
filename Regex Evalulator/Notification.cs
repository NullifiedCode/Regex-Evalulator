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
using System.Diagnostics;

namespace Regex_Evalulator
{
    public partial class Notification : MetroForm
    {
        Main frm1 = null;
        public Notification(string g, string g2, Color g3, Color g4, Main frm)
        {
            InitializeComponent();
            metroLabel1.ForeColor = g4;
            metroLabel1.Text = g2;
            this.Text = g;
            this.ForeColor = g3;

            if (frm1 == null)
                frm1 = frm;

            this.AccentColor = frm1.AccentColor;

            for (int i = 0; i < this.Controls.Count; i++)
            {
                Control c = this.Controls[i];
                if (c.GetType() == typeof(MetroButton))
                    ((MetroButton)c).PressedColor = frm1.AccentColor;
            }

            if(g2 == "Please restart the application for changes to be active.")
            {
                metroButton1.Visible = true;
                metroButton9.Visible = true;
            }
        }

        private void Notification_Load(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            frm1.Close();
            this.Close();
            Process process = Process.GetCurrentProcess(); // Or whatever method you are using
            string fullPath = process.MainModule.FileName;
            Process.Start(fullPath);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
