namespace RestaurantCashier
{
    partial class OrderingForm
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
            this.buttonFood = new System.Windows.Forms.Button();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.RowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityAdd = new System.Windows.Forms.NumericUpDown();
            this.buttonMenuBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFood
            // 
            this.buttonFood.Location = new System.Drawing.Point(12, 10);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(75, 23);
            this.buttonFood.TabIndex = 0;
            this.buttonFood.Text = "Food";
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.Location = new System.Drawing.Point(93, 10);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(75, 23);
            this.buttonDrinks.TabIndex = 1;
            this.buttonDrinks.Text = "Drinks";
            this.buttonDrinks.UseVisualStyleBackColor = true;
            this.buttonDrinks.Click += new System.EventHandler(this.buttonDrinks_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(126, 422);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(104, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add to order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.totalPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.totalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPrice.Location = new System.Drawing.Point(1085, 376);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(221, 29);
            this.totalPrice.TabIndex = 6;
            this.totalPrice.Text = "Total Price";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(715, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total order price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(715, 13);
            this.label2.MaximumSize = new System.Drawing.Size(250, 25);
            this.label2.MinimumSize = new System.Drawing.Size(110, 25);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Table Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AllowUserToAddRows = false;
            this.dataGridViewMenu.AllowUserToDeleteRows = false;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowNo,
            this.ItemName,
            this.ItemId,
            this.ItemUnit,
            this.ItemPrice});
            this.dataGridViewMenu.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.ReadOnly = true;
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.RowTemplate.Height = 25;
            this.dataGridViewMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenu.Size = new System.Drawing.Size(683, 375);
            this.dataGridViewMenu.TabIndex = 9;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // RowNo
            // 
            this.RowNo.FillWeight = 30F;
            this.RowNo.HeaderText = "No.";
            this.RowNo.Name = "RowNo";
            this.RowNo.ReadOnly = true;
            this.RowNo.Width = 30;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 300F;
            this.ItemName.HeaderText = "Product Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 300;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "Product ID";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            // 
            // ItemUnit
            // 
            this.ItemUnit.HeaderText = "Units";
            this.ItemUnit.Name = "ItemUnit";
            this.ItemUnit.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AllowUserToDeleteRows = false;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.MenuName,
            this.dataGridViewTextBoxColumn1,
            this.ItemQuantity,
            this.dataGridViewTextBoxColumn2,
            this.LinePrice});
            this.dataGridViewOrder.Location = new System.Drawing.Point(715, 41);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.ReadOnly = true;
            this.dataGridViewOrder.RowHeadersVisible = false;
            this.dataGridViewOrder.RowTemplate.Height = 25;
            this.dataGridViewOrder.Size = new System.Drawing.Size(591, 329);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // ItemNo
            // 
            this.ItemNo.FillWeight = 30F;
            this.ItemNo.HeaderText = "No.";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.ReadOnly = true;
            this.ItemNo.Width = 30;
            // 
            // MenuName
            // 
            this.MenuName.FillWeight = 50F;
            this.MenuName.HeaderText = "Menu";
            this.MenuName.Name = "MenuName";
            this.MenuName.ReadOnly = true;
            this.MenuName.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 270F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 270;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.FillWeight = 50F;
            this.ItemQuantity.HeaderText = "Qnty";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            this.ItemQuantity.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 50F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // LinePrice
            // 
            this.LinePrice.FillWeight = 90F;
            this.LinePrice.HeaderText = "Total Price";
            this.LinePrice.Name = "LinePrice";
            this.LinePrice.ReadOnly = true;
            this.LinePrice.Width = 90;
            // 
            // quantityAdd
            // 
            this.quantityAdd.Enabled = false;
            this.quantityAdd.Location = new System.Drawing.Point(67, 422);
            this.quantityAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityAdd.Name = "quantityAdd";
            this.quantityAdd.Size = new System.Drawing.Size(53, 23);
            this.quantityAdd.TabIndex = 11;
            this.quantityAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonMenuBack
            // 
            this.buttonMenuBack.Location = new System.Drawing.Point(1136, 466);
            this.buttonMenuBack.Name = "buttonMenuBack";
            this.buttonMenuBack.Size = new System.Drawing.Size(170, 23);
            this.buttonMenuBack.TabIndex = 12;
            this.buttonMenuBack.Text = "BACK";
            this.buttonMenuBack.UseVisualStyleBackColor = true;
            this.buttonMenuBack.Click += new System.EventHandler(this.buttonMenuBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1196, 13);
            this.label3.MaximumSize = new System.Drawing.Size(250, 25);
            this.label3.MinimumSize = new System.Drawing.Size(110, 25);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seats";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentTime
            // 
            this.CurrentTime.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.CurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentTime.Location = new System.Drawing.Point(548, 460);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.ReadOnly = true;
            this.CurrentTime.Size = new System.Drawing.Size(221, 29);
            this.CurrentTime.TabIndex = 14;
            this.CurrentTime.Text = "Time";
            this.CurrentTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OrderingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 501);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMenuBack);
            this.Controls.Add(this.quantityAdd);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDrinks);
            this.Controls.Add(this.buttonFood);
            this.Name = "OrderingForm";
            this.Text = "Ordering Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFood;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.NumericUpDown quantityAdd;
        private System.Windows.Forms.Button buttonMenuBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MenuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CurrentTime;
    }
}