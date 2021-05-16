using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSuite;

namespace Regex_Evalulator
{
    public partial class Main : MetroForm
    {
        Regex g = new Regex("");
        bool IsValidRegex = false;
        
        Notification notification = null;
        Information information = null;
        Settings settings = null;
        public bool randomColor;
        public bool autoCheckRegex;
        public Main()
        {
            InitializeComponent();
            metroTextbox1.ForeColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTextbox1.Focus();
            LoadLastOutput();
            ValidateRegex();
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadLastOutput()
        {
            if (File.Exists(@"r-config.txt"))
            {
                string[] line = File.ReadAllLines(@"r-config.txt");

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].StartsWith("O-Regex: "))
                    {
                        try
                        {
                            g = new Regex(line[i]);
                            metroTextbox1.Text = line[i].Replace("O-Regex: ", "");
                        }
                        catch
                        {
                            metroTextbox1.Text = "";
                        }
                    }
                    if (line[i].StartsWith("O-RandomColor: "))
                    {
                        string g = line[i].Replace("O-RandomColor: ", "");
                        try
                        {
                            randomColor = bool.Parse(g);
                        }
                        catch
                        {
                            randomColor = false;
                        }
                    }
                    if (line[i].StartsWith("O-AutoCheckRegex: "))
                    {
                        string g = line[i].Replace("O-AutoCheckRegex: ", "");
                        try
                        {
                            autoCheckRegex = bool.Parse(g);
                        }
                        catch
                        {
                            autoCheckRegex = false;
                        }
                    }
                }
                if (randomColor)
                {
                    Random rnd = new Random();
                    Color col = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    this.AccentColor = col;
                    metroPanelCategory1.AccentColor = col;
                    metroPanelCategory2.AccentColor = col;
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        Control c = this.Controls[i];
                        if (c.GetType() == typeof(MetroButton))
                            ((MetroButton)c).PressedColor = col;
                    }
                    this.Text = "Regex Evaluator (BETA) - Color: " + string.Format("{0}, {1}, {2}", col.R, col.G, col.B);
                }
                ValidateRegex();
            }
        }

        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public void ValidateRegex()
        {
            if (string.IsNullOrEmpty(metroTextbox1.Text)) { 
                metroLabel3.Text = "No Expression"; 
                metroLabel3.ForeColor = Color.White; 
            }
            else
            {
                try
                {
                    g = new Regex(metroTextbox1.Text);
                    IsValidRegex = true;
                    metroTextbox1.ForeColor = Color.Green;
                    metroLabel3.ForeColor = Color.Green;
                    metroLabel3.Text = "Valid Regex";
                }
                catch
                {
                    metroTextbox1.ForeColor = Color.Red; metroLabel3.ForeColor = Color.Red;
                    metroLabel3.Text = "Invalid Regex";
                    IsValidRegex = false;
                }
            }
        }



        public void AppendRegex()
        {
            ValidateRegex();
            richTextBox2.SelectionStart = 0;
            richTextBox2.SelectionLength = 0;
            richTextBox2.Text = "";
            string[] line = richTextBox1.Lines;
            for (int i = 0; i < line.Length; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                if (g.IsMatch(line[i]) && line[i].Length > 0)
                {
                    AppendText(richTextBox2, line[i] + " -> ", Color.White);
                    AppendText(richTextBox2, "Valid", Color.Green);
                    sw.Stop();
                    AppendText(richTextBox2, " -> ", Color.White);
                    AppendText(richTextBox2, sw.ElapsedMilliseconds + "m/s\n", Color.Orange);
                }
                else if (line[i].Length > 0)
                {
                    AppendText(richTextBox2, line[i] + " -> ", Color.White);
                    AppendText(richTextBox2, "Invalid", Color.Red);
                    sw.Stop();
                    AppendText(richTextBox2, " -> ", Color.White);
                    AppendText(richTextBox2, sw.ElapsedMilliseconds + "m/s\n", Color.Orange);
                }
                else
                {
                    AppendText(richTextBox2, "\n", Color.White);
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTextbox1.Text = "([(\\/V|I\\/I|)nN𝔫𝔑η𝓃𝒩𝕟ℕｎＮɴNunN🄽Ͷᴎ🅽ₙⁿᴺⓝⓃภɳNռᏁŋຖ𝐧𝐍𝘯𝘕𝙣𝙉𝚗𝙽Пηñ₦几刀ղហᑎᘉ\\s]+[iI1𝔦ℑ𝖎𝕴𝓲𝓘𝒾𝐼𝕚𝕀ｉＩ𝒾𝐼ɪɪIıiI🄸Ii🅸ᵢᵢⁱᴵⓘⒾเιIɨᎥıi𝐢𝐈𝘪𝘐𝙞𝙄𝚒𝙸IIιιïÌł丨ﾉìįIᓰ\\s]+[𝔤𝔊96𝖌𝕲96𝓰ᵍ➈➅𝓰𝓖𝑔𝒢𝕘𝔾𝟡𝟞ｇＧ９６𝑔𝒢ɢ⅁ɓgG🄶9Ꭾǫ🅶g₉₆ᵍᴳ⁹⁶ⓖⒼ⑨⑥ﻮɠᎶງ₲ᎶgGqQf3F\\s]+[aA𝔞𝔄4𝖆𝕬4Δค➃𝓪𝓐𝒶𝒜𝕒𝔸𝟜ａＡ４ᴀ∀ɐ🄰ɒ:a:ₐₐ₄ᵃᴬ⁴ⓐⒶ④คαAǟąค𝐚𝐀𝟒𝘢𝘈4𝙖𝘼4𝚊𝙰𝟺ΛαåÄ₳卂ﾑąȺᗩⒶⓐ➃❹ά➃@euU3\\s]+([rR𝔯ℜ𝖗𝕽ℝⓡ𝓻𝓡𝓇𝑅𝕣ℝｒＲ𝓇𝑅ʀᴚɹ🅁Яɿ🆁ᵣʳᴿⓡⓇгɾRʀᏒr𝐫𝐑𝘳𝘙𝙧𝙍𝚛𝚁ЯяⱤ尺ɾའᖇᏗ\\s]+|)(\\s|)+|([rR𝔯ℜ𝖗𝕽ℝⓡ𝓻𝓡𝓇𝑅𝕣ℝｒＲ𝓇𝑅ʀᴚɹ🅁Яɿ🆁ᵣʳᴿⓡⓇгɾRʀᏒr𝐫𝐑𝘳𝘙𝙧𝙍𝚛𝚁ЯяⱤ尺ɾའᖇᏗ\\s]+|)(\\s|)+[aA𝔞𝔄4𝖆𝕬4Δค➃𝓪𝓐𝒶𝒜𝕒𝔸𝟜ａＡ４ᴀ∀ɐ🄰ɒ:a:ₐₐ₄ᵃᴬ⁴ⓐⒶ④คαAǟąค𝐚𝐀𝟒𝘢𝘈4𝙖𝘼4𝚊𝙰𝟺ΛαåÄ₳卂ﾑąȺᗩⒶⓐ➃❹ά➃@euU3\\s]+[𝔤𝔊96𝖌𝕲96𝓰ᵍ➈➅𝓰𝓖𝑔𝒢𝕘𝔾𝟡𝟞ｇＧ９６𝑔𝒢ɢ⅁ɓgG🄶9Ꭾǫ🅶g₉₆ᵍᴳ⁹⁶ⓖⒼ⑨⑥ﻮɠᎶງ₲ᎶgGq3QfF\\s]+[iI1𝔦ℑ𝖎𝕴𝓲𝓘𝒾𝐼𝕚𝕀ｉＩ𝒾𝐼ɪɪIıiI🄸Ii🅸ᵢᵢⁱᴵⓘⒾเιIɨᎥıi𝐢𝐈𝘪𝘐𝙞𝙄𝚒𝙸IIιιïÌł丨ﾉìįIᓰ\\s]+[(\\/V|I\\/I|)nN𝔫𝔑η𝓃𝒩𝕟ℕｎＮɴNunN🄽Ͷᴎ🅽ₙⁿᴺⓝⓃภɳNռᏁŋຖ𝐧𝐍𝘯𝘕𝙣𝙉𝚗𝙽Пηñ₦几刀ղហᑎᘉ\\s])";
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroTextbox1.Text = "^(ht|f)tp(s?)\\:\\/\\/[0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*(:(0-9)*)*(\\/?)([a-zA-Z0-9\\-\\.\\?\\,\\'\\/\\\\\\+&%\\$#_]*)?$";
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroTextbox1.Text = "(#|)[cC\\s]+[oO0\\s]+[nN\\s]+[tT7\\s]+[rR\\s]+[oO0\\s]+[lIL\\|\\s]+[\\|iIIl1]+[nN\\s]+[gG96]";
        }
        private void metroButton10_Click(object sender, EventArgs e)
        {
            metroTextbox1.Text = "(#|)+[eE3\\s]+[zZ\\s]+[oO0\\s]+[iIl1\\|]+[lLI\\|1]";
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            OpenFileDialog g = new OpenFileDialog();
            g.Filter = "Text files (*.txt)|*.txt";
            if (g.ShowDialog() == DialogResult.OK)
            {
                // Check if the file exists before trying to open it 
                if (File.Exists(g.FileName))
                {
                    richTextBox1.AppendText(File.ReadAllText(g.FileName));
                    AppendRegex();
                }
                else
                {
                    
                }
            }
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private string reverseStringRegex()
        {
            string g = Reverse(metroTextbox1.Text);
            char[] arr = g.ToCharArray();
            string returnval = "";
            for(int i = 0; i < arr.Length; i++)
            {
                switch (arr[i].ToString())
                {
                    case "]":
                        returnval += "[";
                        break;
                    case "[":
                        returnval += "]";
                        break;
                    case "(":
                        returnval += ")";
                        break;
                    case ")":
                        returnval += "(";
                        break;
                    case "}":
                        returnval += "{";
                        break;
                    case "{":
                        returnval += "}";
                        break;
                    default:
                        returnval += arr[i].ToString();
                        break;
                }
            }
            returnval = returnval.Replace("s\\","\\s");
            returnval = returnval.Replace("b\\", "\\b");
            returnval = returnval.Replace("d\\", "\\d");
            returnval = returnval.Replace("|\\", "\\|");
            returnval = returnval.Replace("w\\", "\\w");
            return returnval;
        }
            
        private void metroButton5_Click(object sender, EventArgs e)
        {
            if (metroTextbox1.Text.Length > 0 && IsValidRegex)
            {
                try
                {
                    g = new Regex("(" + metroTextbox1.Text + "|" + reverseStringRegex() + ")");
                    metroTextbox1.Text = "(" + metroTextbox1.Text + "|" + reverseStringRegex() + ")";
                }
                catch
                {
                    if (notification != null) notification.Close();
                    notification = new Notification("Error!", "Produced invalid expression. Falling back....", Color.Red, Color.Red, this);
                    notification.TopMost = true;
                    notification.Show();
                    IsValidRegex = false;
                }
            }
        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.Focus();
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            string result = $"O-Regex: {metroTextbox1.Text}\nO-RandomColor: {randomColor}\nO-AutoCheckRegex: {autoCheckRegex}\n\n{richTextBox2.Text}\n\n";
            File.WriteAllText(@"r-config.txt", result);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            string result = $"O-Regex: {metroTextbox1.Text}\nO-RandomColor: {randomColor}\nO-AutoCheckRegex: {autoCheckRegex}\n\n{richTextBox2.Text}\n\n";
            File.WriteAllText(@"r-config.txt", result);
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = Application.StartupPath;
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    if (notification != null) notification.Close();
                    notification = new Notification("Success", "Saved the word list.", Color.Green, Color.Green, this);
                    notification.TopMost = true;
                    notification.Show();
                }
            }
            else
            {
                if (notification != null) notification.Close();
                notification = new Notification("Error!", "Nothing to save.", Color.Red, Color.Red, this);
                notification.TopMost = true;
                notification.Show();
            }
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            if (settings != null) settings.Close();
            settings = new Settings(this); 
            settings.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            AppendRegex();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            metroTextbox1.Text = "";
            ValidateRegex();
        }

        private void metroTextbox1_TextChanged(object sender, EventArgs e)
        {
            if (autoCheckRegex)
                AppendRegex();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(autoCheckRegex)
                AppendRegex();
        }

        private void metroButton6_Click_1(object sender, EventArgs e)
        {
            if (information != null) information.Close();
            information = new Information(this);
            information.Show();
        }
    }
}
