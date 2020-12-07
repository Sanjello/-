using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Module
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Auto.mdf;Integrated Security=True";
        SqlConnection connection;


        private void Form1_Load(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from AutoInfo", ConnectionString);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void checkSevenButton_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from AutoInfo", ConnectionString);
                SqlCommand command = new SqlCommand($"SELECT COUNT(Number) AS [Count] FROM AutoInfo WHERE [Number] LIKE '%7%' and Model = '{comboBox1.Text}'", connection);
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.Rows[0];
                textBox1.Text = row[0].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from AutoInfo", ConnectionString);
                SqlCommand command = new SqlCommand($"SELECT SUM(Price) FROM AutoInfo WHERE Model ='{chooseModelForPrice.Text}'", connection);
                adapter.SelectCommand = command;
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.Rows[0];
                textBox2.Text = row[0].ToString();
            }
        }
    }
}
