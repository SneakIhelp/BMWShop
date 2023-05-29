namespace BMWShop
{
    partial class Orders
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
            this.ordersTable = new System.Windows.Forms.DataGridView();
            this.BacktoMain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.GoodsQuant = new System.Windows.Forms.TextBox();
            this.GoodsNumbers = new System.Windows.Forms.TextBox();
            this.ClientAddress = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientDeliveryTime = new System.Windows.Forms.TextBox();
            this.ClientSurname = new System.Windows.Forms.TextBox();
            this.ClientPhoneNumber = new System.Windows.Forms.TextBox();
            this.ClientPatr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.DeclineBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTable
            // 
            this.ordersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersTable.Location = new System.Drawing.Point(12, 13);
            this.ordersTable.Name = "ordersTable";
            this.ordersTable.Size = new System.Drawing.Size(776, 277);
            this.ordersTable.TabIndex = 0;
            this.ordersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersTable_CellClick);
            // 
            // BacktoMain
            // 
            this.BacktoMain.Location = new System.Drawing.Point(713, 415);
            this.BacktoMain.Name = "BacktoMain";
            this.BacktoMain.Size = new System.Drawing.Size(75, 23);
            this.BacktoMain.TabIndex = 1;
            this.BacktoMain.Text = "Назад";
            this.BacktoMain.UseVisualStyleBackColor = true;
            this.BacktoMain.Click += new System.EventHandler(this.BacktoMain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DeclineBtn);
            this.groupBox1.Controls.Add(this.AcceptBtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ClientPhoneNumber);
            this.groupBox1.Controls.Add(this.ClientPatr);
            this.groupBox1.Controls.Add(this.ClientDeliveryTime);
            this.groupBox1.Controls.Add(this.ClientSurname);
            this.groupBox1.Controls.Add(this.ClientAddress);
            this.groupBox1.Controls.Add(this.ClientName);
            this.groupBox1.Controls.Add(this.GoodsQuant);
            this.groupBox1.Controls.Add(this.ChangeBtn);
            this.groupBox1.Controls.Add(this.GoodsNumbers);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение заказа";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Location = new System.Drawing.Point(529, 66);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(241, 23);
            this.ChangeBtn.TabIndex = 0;
            this.ChangeBtn.Text = "Изменить";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // GoodsQuant
            // 
            this.GoodsQuant.Location = new System.Drawing.Point(20, 71);
            this.GoodsQuant.Name = "GoodsQuant";
            this.GoodsQuant.Size = new System.Drawing.Size(100, 20);
            this.GoodsQuant.TabIndex = 4;
            // 
            // GoodsNumbers
            // 
            this.GoodsNumbers.Location = new System.Drawing.Point(20, 31);
            this.GoodsNumbers.Name = "GoodsNumbers";
            this.GoodsNumbers.Size = new System.Drawing.Size(100, 20);
            this.GoodsNumbers.TabIndex = 3;
            // 
            // ClientAddress
            // 
            this.ClientAddress.Location = new System.Drawing.Point(146, 71);
            this.ClientAddress.Name = "ClientAddress";
            this.ClientAddress.Size = new System.Drawing.Size(100, 20);
            this.ClientAddress.TabIndex = 6;
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(146, 31);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(100, 20);
            this.ClientName.TabIndex = 5;
            // 
            // ClientDeliveryTime
            // 
            this.ClientDeliveryTime.Location = new System.Drawing.Point(272, 71);
            this.ClientDeliveryTime.Name = "ClientDeliveryTime";
            this.ClientDeliveryTime.Size = new System.Drawing.Size(100, 20);
            this.ClientDeliveryTime.TabIndex = 8;
            // 
            // ClientSurname
            // 
            this.ClientSurname.Location = new System.Drawing.Point(272, 31);
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.Size = new System.Drawing.Size(100, 20);
            this.ClientSurname.TabIndex = 7;
            // 
            // ClientPhoneNumber
            // 
            this.ClientPhoneNumber.Location = new System.Drawing.Point(398, 71);
            this.ClientPhoneNumber.Name = "ClientPhoneNumber";
            this.ClientPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.ClientPhoneNumber.TabIndex = 10;
            // 
            // ClientPatr
            // 
            this.ClientPatr.Location = new System.Drawing.Point(398, 31);
            this.ClientPatr.Name = "ClientPatr";
            this.ClientPatr.Size = new System.Drawing.Size(100, 20);
            this.ClientPatr.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номера товаров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Количество товаров";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Время и дата доставки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Номер телефона";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Location = new System.Drawing.Point(652, 29);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(118, 23);
            this.AcceptBtn.TabIndex = 21;
            this.AcceptBtn.Text = "Подтвердить";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // DeclineBtn
            // 
            this.DeclineBtn.Location = new System.Drawing.Point(529, 29);
            this.DeclineBtn.Name = "DeclineBtn";
            this.DeclineBtn.Size = new System.Drawing.Size(117, 23);
            this.DeclineBtn.TabIndex = 22;
            this.DeclineBtn.Text = "Отклонить";
            this.DeclineBtn.UseVisualStyleBackColor = true;
            this.DeclineBtn.Click += new System.EventHandler(this.DeclineBtn_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BacktoMain);
            this.Controls.Add(this.ordersTable);
            this.Name = "Orders";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.ordersTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersTable;
        private System.Windows.Forms.Button BacktoMain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientPhoneNumber;
        private System.Windows.Forms.TextBox ClientPatr;
        private System.Windows.Forms.TextBox ClientDeliveryTime;
        private System.Windows.Forms.TextBox ClientSurname;
        private System.Windows.Forms.TextBox ClientAddress;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox GoodsQuant;
        private System.Windows.Forms.TextBox GoodsNumbers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeclineBtn;
        private System.Windows.Forms.Button AcceptBtn;
    }
}