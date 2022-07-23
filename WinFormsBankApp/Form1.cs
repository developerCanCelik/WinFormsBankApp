

using System.Data.SqlClient;

namespace WinFormsBankApp
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        int deneme = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Customer where customer_tc=@tc AND cutomer_password=@pass";
            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=BankDb; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("pass", txt_userpassword.Text);

            con.Open();

            if (deneme > 0)
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form2 frm = new Form2();

                    frm.Show();
                    this.Hide();
                }
                else
                {
                    deneme--;
                    MessageBox.Show("Deneme hakkýnýz: "+deneme);

                }
            }
            else
            {
                this.Close();
            }
            con.Close();
        }
    }
}