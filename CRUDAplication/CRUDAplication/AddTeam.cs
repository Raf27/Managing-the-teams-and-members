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

namespace CRUDAplication
{
    public partial class AddTeam : Form
    {
        public object TeamGrid { get; private set; }

        private HomePageaTeam home;
        public AddTeam(HomePageaTeam homePage)
        {
           home = homePage;
            InitializeComponent();
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // InsertTeam();
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-62V61RT\\SQLEXPRESS; database=CRUD_Aplication; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("insert into Team (TeamName, LeaderName) values (@t, @l)", con);
                cm.Parameters.Add("@t", System.Data.SqlDbType.NVarChar, 100).Value = textBox1.Text;
                cm.Parameters.Add("@l", System.Data.SqlDbType.NVarChar, 100).Value = textBox2.Text;

                con.Open();
                cm.ExecuteNonQuery();

                home.LoadData();
         
                MessageBox.Show("Succes");
                this.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            HomePageaTeam main = new HomePageaTeam();
            main.Show();
            this.Hide();    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}