using davaleba_1.DB;
using davaleba_1.products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace davaleba_1
{
    public partial class Form1 : Form
    {
        public List<Products> productslist = new List<Products>();
        decimal total3;
        


        public Form1()
        {
            InitializeComponent();

        }
       public void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = GetProductTableFromDb();
        }

        private void damatebabtn_Click_1(object sender, EventArgs e)
        {
            Products p = new Products(saxelitxt.Text, Convert.ToDecimal(fasitxt.Text), Convert.ToInt32(raodenobatxt.Text));
            productslist.Add(p);
            DBproduct dBproduct = new DBproduct();
            dBproduct.AddProduct(p);
            decimal num1 = 0;
            foreach (var item in productslist)
            {
                decimal cnt=item.Productprice * item.Raodenoba;
                num1 += cnt;
                
            }
            label4.Text = num1.ToString();
            refresh();
        }

        public List<Products> GetProductTableFromDb() 
        {
            DBproduct dbproduct = new DBproduct();
            return dbproduct.GetAllProducts();

        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetProductTableFromDb();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

   
}
