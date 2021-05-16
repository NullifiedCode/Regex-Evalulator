using System;
using System.Drawing;
using System.Windows.Forms;
using MetroSuite;

namespace Regex_Evalulator
{
    public partial class Settings : MetroForm
    {
        Main frm1 = null;
        Notification notification;

        public Settings(Main f)
        {
            InitializeComponent();
            if (frm1 == null)
                frm1 = f;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            metroChecker1.Checked = frm1.randomColor;
            metroChecker2.Checked = frm1.autoCheckRegex;
            if (metroChecker1.Checked)
            {
                this.AccentColor = frm1.AccentColor;
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Control c = this.Controls[i];
                    if (c.GetType() == typeof(MetroButton)) {
                        ((MetroButton)c).PressedColor = frm1.AccentColor;
                    }
                    if (c.GetType() == typeof(MetroChecker))
                    {
                        ((MetroChecker)c).CheckColor = frm1.AccentColor;
                        ((MetroChecker)c).PressedColor = frm1.AccentColor;
                    }
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void metroButton1_Click(object sender, EventArgs e)
        {
            frm1.metroTextbox1.Text = "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\-\\.\\?\\,\\'\\/\\\\\\+&%\\$#_]*)?$";
            frm1.ValidateRegex();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            frm1.metroTextbox1.Text = "^((?:https?:)?\\/\\/)?((?:www|m)\\.)?((?:youtube\\.com|youtu.be))(\\/(?:[\\w\\-]+\\?v=|embed\\/|v\\/)?)([\\w\\-]+)(\\S+)?$";
            frm1.ValidateRegex();
        }

        private void metroChecker2_Click(object sender, EventArgs e)
        {
            frm1.autoCheckRegex = metroChecker2.Checked;
            if (frm1.autoCheckRegex)
                frm1.ValidateRegex();
        }

        private void metroChecker1_Click(object sender, EventArgs e)
        {
            frm1.randomColor = metroChecker1.Checked;
            if (notification != null) notification.Close();
            notification = new Notification("Info", "Please restart the application for changes to be active.", Color.Green, Color.Green, frm1);
            notification.TopMost = true;
            notification.Show();
        }

        private void metroChecker2_CheckedChanged(object sender, bool isChecked)
        {

        }

        private void metroChecker1_CheckedChanged(object sender, bool isChecked)
        {

        }
    }
}
