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
    public partial class IndexForm : Form
    {
        public bool status;
        public IndexForm()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e) //close
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            double percent = double.Parse(textboxindex.Text.Replace('.', ','))/100 + 1;
            Console.WriteLine(percent);
            SQLConnect.ExecuteQuery(@"UPDATE Store SET price = price * " + (percent.ToString().Replace(',', '.')));
            foreach (var x in ProductList.list)
            {
               x.Price = x.Price * percent;
            }   
            status = true;
            this.Close();
        }

        private void textboxindex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && textboxindex.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
