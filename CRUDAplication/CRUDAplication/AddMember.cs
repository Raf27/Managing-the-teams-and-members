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
    public partial class AddMember : Form
    {

        private int teamid;
        public AddMember(int id)
        {
            teamid = id;
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-62V61RT\\SQLEXPRESS; database=CRUD_Aplication; integrated security = SSPI");
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Member where TeamId = " + teamid, con);
                con.Open();

                DataSet ds = new DataSet();
                cm.Fill(ds, "Member");
                dataGridView2.DataSource = ds.Tables["Member"].DefaultView;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong." + ex);
            }

            finally
            {
                con.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            HomePageaTeam main = new HomePageaTeam();
            main.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
      
                // InsertTeam();
                SqlConnection con = null;
                try
                {
                con = new SqlConnection("data source=DESKTOP-62V61RT\\SQLEXPRESS; database=CRUD_Aplication; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("insert into Member (FirstName, LastName, TeamId, RoleId) values (@f, @l, @t, @r)", con);
                cm.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 100).Value = textBox2.Text;
                cm.Parameters.Add("@l", System.Data.SqlDbType.NVarChar, 100).Value = textBox3.Text;
                cm.Parameters.Add("@t", System.Data.SqlDbType.Int).Value = teamid;
                cm.Parameters.Add("@r", System.Data.SqlDbType.Int).Value = textBox5.Text;

                con.Open();
                cm.ExecuteNonQuery();

                LoadData();

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
    }
}
