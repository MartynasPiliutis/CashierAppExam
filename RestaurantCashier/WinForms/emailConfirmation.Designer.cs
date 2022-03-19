namespace RestaurantCashier
{
    partial class EmailConfirmation
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.messageBoxField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(167, 209);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(80, 35);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // messageBoxField
            // 
            this.messageBoxField.Location = new System.Drawing.Point(12, 12);
            this.messageBoxField.Multiline = true;
            this.messageBoxField.Name = "messageBoxField";
            this.messageBoxField.ReadOnly = true;
            this.messageBoxField.Size = new System.Drawing.Size(398, 191);
            this.messageBoxField.TabIndex = 1;
            this.messageBoxField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EmailConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 256);
            this.Controls.Add(this.messageBoxField);
            this.Controls.Add(this.buttonOk);
            this.Name = "EmailConfirmation";
            this.Text = "Email Sent - Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox messageBoxField;
    }
}