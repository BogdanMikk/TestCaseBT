namespace TestCaseBT
{
    partial class IndexForm
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
            this.textboxindex = new System.Windows.Forms.TextBox();
            this.lbindex = new System.Windows.Forms.Label();
            this.btcancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textboxindex);
            this.groupBox1.Controls.Add(this.lbindex);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Провести индексацию";
            // 
            // textboxindex
            // 
            this.textboxindex.Location = new System.Drawing.Point(127, 27);
            this.textboxindex.Name = "textboxindex";
            this.textboxindex.Size = new System.Drawing.Size(237, 20);
            this.textboxindex.TabIndex = 1;
            this.textboxindex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxindex_KeyPress);
            // 
            // lbindex
            // 
            this.lbindex.AutoSize = true;
            this.lbindex.Location = new System.Drawing.Point(9, 30);
            this.lbindex.Name = "lbindex";
            this.lbindex.Size = new System.Drawing.Size(84, 13);
            this.lbindex.TabIndex = 0;
            this.lbindex.Text = "% индексации :";
            // 
            // btcancel
            // 
            this.btcancel.Location = new System.Drawing.Point(202, 92);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(180, 30);
            this.btcancel.TabIndex = 3;
            this.btcancel.Text = "Отмена";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(12, 92);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(180, 30);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "ОК";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 130);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btcancel);
            this.Controls.Add(this.btOK);
            this.Name = "IndexForm";
            this.Text = "IndexForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxindex;
        private System.Windows.Forms.Label lbindex;
        private System.Windows.Forms.Button btcancel;
        private System.Windows.Forms.Button btOK;
    }
}