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
    
    public partial class Form1 : Form
    {
        AddProduct f;
        IndexForm f2;
        
        public Form1()
        {
            InitializeComponent();
            SQLConnect.FillList(out ProductList.list);
            grid();
        }

        private void btadd_Click(object sender, EventArgs e) //add button
        {
            f = new AddProduct();
            f.ShowDialog();
            if (f.status)
            {
                grid();
            }
        }

        private void btdelete_Click(object sender, EventArgs e) //delete button
        {
            try
            {
                SQLConnect.ExecuteQuery("DELETE FROM Store WHERE id = " + dataGridView1.CurrentRow.Cells[0].Value);
                foreach (var x in ProductList.list.Where(x => x.Id == (long)dataGridView1.CurrentRow.Cells[0].Value))
                {
                    ProductList.list.Remove(x);
                    break;
                }
                grid();
            }
            catch
            {
                MessageBox.Show("НИЗЯ УДАЛИТ!!!111!!!1");
            }
        }

        private void btindex_Click(object sender, EventArgs e) //index button
        {
            f2 = new IndexForm();
            f2.ShowDialog();
            if (f2.status)
            {
                grid();
            }
        }
        private void grid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ProductList.list;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "#.##";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].FillWeight = 20;
            dataGridView1.Columns[2].FillWeight = 40;


            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Количество";
            dataGridView1.Columns[3].HeaderText = "Цена";
            dataGridView1.Columns[4].HeaderText = "Категория";
        }
    }
    public class ProductList
    {
        public static IList<Product> list;
    }
}
