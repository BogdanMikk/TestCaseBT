namespace TestCaseBT
{
    partial class AddProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lbcateg = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbnum = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCateg);
            this.groupBox1.Controls.Add(this.textBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxNum);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.lbcateg);
            this.groupBox1.Controls.Add(this.lbprice);
            this.groupBox1.Controls.Add(this.lbnum);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить товар";
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Items.AddRange(new object[] {
            "Товар",
            "Услуга"});
            this.comboBoxCateg.Location = new System.Drawing.Point(124, 127);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(237, 21);
            this.comboBoxCateg.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(124, 97);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(237, 20);
            this.textBoxPrice.TabIndex = 1;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(124, 67);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(237, 20);
            this.textBoxNum.TabIndex = 1;
            this.textBoxNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNum_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(237, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // lbcateg
            // 
            this.lbcateg.AutoSize = true;
            this.lbcateg.Location = new System.Drawing.Point(10, 130);
            this.lbcateg.Name = "lbcateg";
            this.lbcateg.Size = new System.Drawing.Size(66, 13);
            this.lbcateg.TabIndex = 0;
            this.lbcateg.Text = "Категория :";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(10, 100);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(99, 13);
            this.lbprice.TabIndex = 0;
            this.lbprice.Text = "Закупочная цена :";
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.Location = new System.Drawing.Point(10, 70);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(72, 13);
            this.lbnum.TabIndex = 0;
            this.lbnum.Text = "Количество :";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(10, 40);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(63, 13);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Название :";
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(202, 241);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(180, 30);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "Отмена";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(12, 241);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(180, 30);
            this.btadd.TabIndex = 4;
            this.btadd.Text = "Добавить";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btadd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxCateg;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lbcateg;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btadd;
    }
}