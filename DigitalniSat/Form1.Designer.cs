namespace DigitalniSat
{
    partial class Form1
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
            this.vrijeme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kulture = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // vrijeme
            // 
            this.vrijeme.AutoSize = true;
            this.vrijeme.Location = new System.Drawing.Point(230, 89);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.Size = new System.Drawing.Size(41, 13);
            this.vrijeme.TabIndex = 0;
            this.vrijeme.Text = "Vrijeme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrijeme: ";
            // 
            // kulture
            // 
            this.kulture.FormattingEnabled = true;
            this.kulture.Items.AddRange(new object[] {
            "hr",
            "en",
            "de"});
            this.kulture.Location = new System.Drawing.Point(82, 12);
            this.kulture.Name = "kulture";
            this.kulture.Size = new System.Drawing.Size(223, 21);
            this.kulture.TabIndex = 2;
            this.kulture.SelectedIndexChanged += new System.EventHandler(this.kulture_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kulture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vrijeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kulture;
    }
}

