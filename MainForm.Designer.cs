namespace BMWShop
{
    partial class MainForm
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
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPhoto = new System.Windows.Forms.Button();
            this.CategoryAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IdModelAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CostAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductTitleAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.OrdersBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdatePhoto = new System.Windows.Forms.Button();
            this.CategoryUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdModelUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CostUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductTitleUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsTable
            // 
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsTable.Location = new System.Drawing.Point(12, 12);
            this.productsTable.Name = "productsTable";
            this.productsTable.Size = new System.Drawing.Size(568, 544);
            this.productsTable.TabIndex = 0;
            this.productsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsTable_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPhoto);
            this.groupBox1.Controls.Add(this.CategoryAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IdModelAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.CostAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ProductTitleAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Location = new System.Drawing.Point(586, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление записи";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AddPhoto
            // 
            this.AddPhoto.Location = new System.Drawing.Point(10, 192);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(219, 31);
            this.AddPhoto.TabIndex = 11;
            this.AddPhoto.Text = "Добавить фото товара";
            this.AddPhoto.UseVisualStyleBackColor = true;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // CategoryAdd
            // 
            this.CategoryAdd.Location = new System.Drawing.Point(10, 166);
            this.CategoryAdd.Name = "CategoryAdd";
            this.CategoryAdd.Size = new System.Drawing.Size(219, 20);
            this.CategoryAdd.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Категория товара";
            // 
            // IdModelAdd
            // 
            this.IdModelAdd.Location = new System.Drawing.Point(10, 122);
            this.IdModelAdd.Name = "IdModelAdd";
            this.IdModelAdd.Size = new System.Drawing.Size(219, 20);
            this.IdModelAdd.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Номер модели";
            // 
            // CostAdd
            // 
            this.CostAdd.Location = new System.Drawing.Point(10, 82);
            this.CostAdd.Name = "CostAdd";
            this.CostAdd.Size = new System.Drawing.Size(219, 20);
            this.CostAdd.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Стоимость";
            // 
            // ProductTitleAdd
            // 
            this.ProductTitleAdd.Location = new System.Drawing.Point(10, 41);
            this.ProductTitleAdd.Name = "ProductTitleAdd";
            this.ProductTitleAdd.Size = new System.Drawing.Size(219, 20);
            this.ProductTitleAdd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название продукта";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(10, 232);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(219, 31);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(586, 562);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(235, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить запись";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Location = new System.Drawing.Point(12, 562);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Size = new System.Drawing.Size(568, 23);
            this.OrdersBtn.TabIndex = 4;
            this.OrdersBtn.Text = "Заказы";
            this.OrdersBtn.UseVisualStyleBackColor = true;
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdatePhoto);
            this.groupBox2.Controls.Add(this.CategoryUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IdModelUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.CostUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ProductTitleUpdate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Location = new System.Drawing.Point(586, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 269);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение записи";
            // 
            // UpdatePhoto
            // 
            this.UpdatePhoto.Location = new System.Drawing.Point(10, 195);
            this.UpdatePhoto.Name = "UpdatePhoto";
            this.UpdatePhoto.Size = new System.Drawing.Size(219, 31);
            this.UpdatePhoto.TabIndex = 11;
            this.UpdatePhoto.Text = "Изменить фото товара";
            this.UpdatePhoto.UseVisualStyleBackColor = true;
            this.UpdatePhoto.Click += new System.EventHandler(this.UpdatePhoto_Click);
            // 
            // CategoryUpdate
            // 
            this.CategoryUpdate.Location = new System.Drawing.Point(10, 166);
            this.CategoryUpdate.Name = "CategoryUpdate";
            this.CategoryUpdate.Size = new System.Drawing.Size(219, 20);
            this.CategoryUpdate.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Категория товара";
            // 
            // IdModelUpdate
            // 
            this.IdModelUpdate.Location = new System.Drawing.Point(10, 122);
            this.IdModelUpdate.Name = "IdModelUpdate";
            this.IdModelUpdate.Size = new System.Drawing.Size(219, 20);
            this.IdModelUpdate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер модели";
            // 
            // CostUpdate
            // 
            this.CostUpdate.Location = new System.Drawing.Point(10, 82);
            this.CostUpdate.Name = "CostUpdate";
            this.CostUpdate.Size = new System.Drawing.Size(219, 20);
            this.CostUpdate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Стоимость";
            // 
            // ProductTitleUpdate
            // 
            this.ProductTitleUpdate.Location = new System.Drawing.Point(10, 41);
            this.ProductTitleUpdate.Name = "ProductTitleUpdate";
            this.ProductTitleUpdate.Size = new System.Drawing.Size(219, 20);
            this.ProductTitleUpdate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Название продукта";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(10, 232);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(219, 31);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Изменить";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 597);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.OrdersBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.productsTable);
            this.Name = "MainForm";
            this.Text = "Окно администратора";
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CostAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductTitleAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button OrdersBtn;
        private System.Windows.Forms.TextBox CategoryAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdModelAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CategoryUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdModelUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductTitleUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddPhoto;
        private System.Windows.Forms.Button UpdatePhoto;
    }
}