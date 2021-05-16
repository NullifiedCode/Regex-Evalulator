
namespace Regex_Evalulator
{
    partial class Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Information));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroLabel1 = new MetroSuite.MetroLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroButton1 = new MetroSuite.MetroButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(477, 316);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroLabel1.Location = new System.Drawing.Point(12, 356);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(158, 16);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Author: NullifiedCode |";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel1.Location = new System.Drawing.Point(170, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 16);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroButton1
            // 
            this.metroButton1.AutoStyle = false;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.metroButton1.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.metroButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metroButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.metroButton1.Location = new System.Drawing.Point(472, 4);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.metroButton1.Size = new System.Drawing.Size(24, 23);
            this.metroButton1.Style = MetroSuite.Design.Style.Custom;
            this.metroButton1.TabIndex = 27;
            this.metroButton1.Text = "X";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(501, 387);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Information";
            this.ResizeBorderWidth = 0;
            this.State = MetroSuite.MetroForm.FormState.Normal;
            this.Style = MetroSuite.Design.Style.Custom;
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSuite.MetroLabel metroLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroSuite.MetroButton metroButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}