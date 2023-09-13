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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LanchonetedoDudu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Usuario";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["Id"];
                    string Name = (string)dr["Name"];
                    string CPF = (string)dr["CPF"];
                    string Password = (string)dr["Password"];
                    string Email = (string)dr["Email"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(Name);
                    lv.SubItems.Add(CPF);
                    lv.SubItems.Add(Password);
                    lv.SubItems.Add(Email);
                    listView1.Items.Add(lv);    

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Usuario VALUES (@name, @CPF, @Password, @Email)";

            sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", mtbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            mtbCPF.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
