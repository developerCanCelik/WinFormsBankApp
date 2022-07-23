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

namespace WinFormsBankApp
{
    public partial class Form2 : Form
    {
        public int money;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=BankDb; Integrated Security=True");
            GetData();
            money = Convert.ToInt32(data_grid_view.CurrentRow.Cells[1].Value);

        }

        public void GetData()
        {
            da = new SqlDataAdapter("Select customer_tc, customer_many From Customer", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Customer");
            data_grid_view.DataSource = ds.Tables["Customer"];
            con.Close();
        }
        private void add_money_Click(object sender, EventArgs e)
        {
            money += Convert.ToInt32(txt_many.Text);
            addAndDelete(money);

        }

        private void delete_money_Click(object sender, EventArgs e)
        {
            money -= Convert.ToInt32(txt_many.Text);
            if(money <= 0)
            {
                MessageBox.Show("Yetersiz Bakiye");
                txt_many.Text = "";
                GetData();
            }
            else
            {
                addAndDelete(money);
            }
        }
        public void addAndDelete(int v)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Customer SET customer_many = @money";
            cmd.Parameters.AddWithValue("@money", v);
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();
            txt_many.Text = "";
        }

        private void txt_many_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Sadece rakam girmelisiniz. Karater giremezsiniz!!!");
            }
        }
    }
}
