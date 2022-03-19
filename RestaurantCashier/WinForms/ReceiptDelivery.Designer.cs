namespace RestaurantCashier
{
    partial class ReceiptDelivery
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
            this.payButton = new System.Windows.Forms.Button();
            this.emailClientButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.clientPrintReceipt = new System.Windows.Forms.CheckBox();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(12, 116);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(150, 30);
            this.payButton.TabIndex = 0;
            this.payButton.Text = "Pay";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // emailClientButton
            // 
            this.emailClientButton.Enabled = false;
            this.emailClientButton.Location = new System.Drawing.Point(12, 259);
            this.emailClientButton.Name = "emailClientButton";
            this.emailClientButton.Size = new System.Drawing.Size(150, 30);
            this.emailClientButton.TabIndex = 1;
            this.emailClientButton.Text = "Email To Client";
            this.emailClientButton.UseVisualStyleBackColor = true;
            this.emailClientButton.Click += new System.EventHandler(this.emailClientButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Email To Restaurant";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.emailRestaurantButton_Click);
            // 
            // clientEmail
            // 
            this.clientEmail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientEmail.Location = new System.Drawing.Point(12, 230);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(150, 22);
            this.clientEmail.TabIndex = 3;
            this.clientEmail.Text = "Client Mailbox";
            this.clientEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientEmail.Click += new System.EventHandler(this.clientEmail_Click);
            this.clientEmail.TextChanged += new System.EventHandler(this.clientEmail_TextChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 411);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(150, 30);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // clientPrintReceipt
            // 
            this.clientPrintReceipt.AutoSize = true;
            this.clientPrintReceipt.Location = new System.Drawing.Point(12, 152);
            this.clientPrintReceipt.Name = "clientPrintReceipt";
            this.clientPrintReceipt.Size = new System.Drawing.Size(149, 19);
            this.clientPrintReceipt.TabIndex = 5;
            this.clientPrintReceipt.Text = "Client Receipt Required";
            this.clientPrintReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clientPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.totalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPrice.Location = new System.Drawing.Point(12, 42);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(150, 29);
            this.totalPrice.TabIndex = 7;
            this.totalPrice.Text = "Total Price";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceiptDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 450);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.clientPrintReceipt);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.emailClientButton);
            this.Controls.Add(this.payButton);
            this.Name = "ReceiptDelivery";
            this.Text = "ReceiptDelivery";
            this.Click += new System.EventHandler(this.ReceiptDelivery_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.Button emailClientButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox clientEmail;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.CheckBox clientPrintReceipt;
        private System.Windows.Forms.TextBox totalPrice;
    }
}