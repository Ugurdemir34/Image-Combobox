namespace ImageComboboxDeneme
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
            this.myCombo1 = new ImageComboboxDeneme.myCombo();
            this.SuspendLayout();
            // 
            // myCombo1
            // 
            this.myCombo1.BackColor = System.Drawing.Color.Transparent;
            this.myCombo1.Genişlik = 0;
            this.myCombo1.Location = new System.Drawing.Point(333, 170);
            this.myCombo1.Name = "myCombo1";
            this.myCombo1.Size = new System.Drawing.Size(235, 39);
            this.myCombo1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 526);
            this.Controls.Add(this.myCombo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private myCombo myCombo1;
    }
}

