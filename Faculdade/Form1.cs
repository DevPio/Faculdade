using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace Faculdade
{
    public partial class Form1 : Form
    {
        public SqlConnection conection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string stringConectio = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=User;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
             this.conection = new SqlConnection(stringConectio);


            var comandoAll = this.conection.CreateCommand();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();



            adapter = new SqlDataAdapter("select * from Users",conection);
            adapter.Fill(ds, "Users");

            TableUsers.DataSource = ds;

            TableUsers.DataMember = "Users";


           

           
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var comando = this.conection.CreateCommand();


                comando.CommandText = "INSERT INTO Users(name,email,password)";

                comando.CommandText += $"VALUES ('{NomeTXT.Text}','{EmailTXT.Text}','{PasswordTXT.Text}')";

                this.conection.Open();

                

                comando.ExecuteNonQuery();

                this.conection.Close();
            }
            catch (Exception ex)
            {

               
            }
        }

    
    }
}
