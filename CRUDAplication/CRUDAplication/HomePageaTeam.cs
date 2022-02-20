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
    public partial class HomePageaTeam : Form
    {
        public object Aplication { get; private set; }

        public HomePageaTeam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTeam form = new AddTeam(this);
            form.ShowDialog();
        }

        private void TeamGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-62V61RT\\SQLEXPRESS; database=CRUD_Aplication; integrated security = SSPI");
                SqlDataAdapter cm = new SqlDataAdapter("SELECT * FROM Team", con);
                con.Open();

                DataSet ds = new DataSet();
                cm.Fill(ds, "Team");
                TeamGrid.DataSource = ds.Tables["Team"].DefaultView;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeamGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                SqlConnection con = null;
                try
                {
                    con = new SqlConnection("data source=DESKTOP-62V61RT\\SQLEXPRESS; database=CRUD_Aplication; integrated security=SSPI");
                    SqlCommand cm = new SqlCommand("delete from Team where TeamID =  @t", con);
                    cm.Parameters.Add("@t", System.Data.SqlDbType.NVarChar, 100).Value = TeamGrid.SelectedCells[0].Value;

                    con.Open();
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Deleted Succesful");
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

        private void TeamGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddMember a2 = new AddMember(int.Parse(TeamGrid.SelectedCells[0].Value.ToString()));
            a2.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) => Application.Exit();
    }
    }

