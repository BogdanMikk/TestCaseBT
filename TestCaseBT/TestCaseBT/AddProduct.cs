using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCaseBT
{
    public partial class AddProduct : Form
    {
        public bool status;
        public AddProduct()
        {
            InitializeComponent();
            comboBoxCateg.SelectedIndex = 0;
        }

        private void btcancel_Click(object sender, EventArgs e) //close
        {
            this.Close();
        }

        private void btadd_Click(object sender, EventArgs e) //add
        {
            if (textBoxName.Text != "" && textBoxNum.Text != "" && textBoxPrice.Text != "")
            {
                if (SQLConnect.ExecuteQuery(@"INSERT INTO Store(name, cnt, price, category) VALUES ('" + textBoxName.Text + "','" + textBoxNum.Text + "','"
                    + textBoxPrice.Text + "','" + comboBoxCateg.Text + "')"))
                {
                    string[] p = new[] { textBoxName.Text, textBoxNum.Text, textBoxPrice.Text, comboBoxCateg.Text };
                    long id = SQLConnect.GetLatestID(ref p);
                    status = true;
                    if (id != -1)
                    {
                        Product x = new Product(id, textBoxName.Text, Convert.ToDouble(textBoxNum.Text), Convert.ToDouble(textBoxPrice.Text), comboBoxCateg.Text);
                        ProductList.list.Add(x);
                    }
                    if(MessageBox.Show((comboBoxCateg.Text == "Товар"? "Товар": "Услуга")+" успешно добавлен(а),\nХотите добавить еще?", "info",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
                    {
                        this.Close();
                    }
                    textBoxName.Text = textBoxNum.Text = textBoxPrice.Text = "";
                }
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textBoxPrice.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

