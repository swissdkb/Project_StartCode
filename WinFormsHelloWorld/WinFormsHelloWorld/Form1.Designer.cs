namespace WinFormsHelloWorld
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
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.textBoxShowHello = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.AccessibleName = "";
            this.buttonSayHello.Location = new System.Drawing.Point(81, 180);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(396, 23);
            this.buttonSayHello.TabIndex = 0;
            this.buttonSayHello.Text = "Click Me";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxShowHello
            // 
            this.textBoxShowHello.Location = new System.Drawing.Point(81, 153);
            this.textBoxShowHello.Name = "textBoxShowHello";
            this.textBoxShowHello.Size = new System.Drawing.Size(396, 21);
            this.textBoxShowHello.TabIndex = 1;
            this.textBoxShowHello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.textBoxShowHello);
            this.Controls.Add(this.buttonSayHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSayHello;
        private System.Windows.Forms.MaskedTextBox textBoxShowHello;
    }
}

