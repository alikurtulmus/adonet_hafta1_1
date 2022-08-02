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


namespace adonet_hafta1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source=DESKTOP-QBFPK40\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True
        private void btnList_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QBFPK40\\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("select*from TblCategory",connection);
            SqlDataAdapter adapter=new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            
            dataGridView1.DataSource = datatable;


            connection.Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QBFPK40\\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True");
            
            connection.Open();

            SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) Values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", txtCategoryname.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori başarılı bir şekilde eklendi");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QBFPK40\\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("delete from tblcategory where categoryID=@p1",connection);
            command.Parameters.AddWithValue("@p1", txtCategoryid.Text);
            command.ExecuteNonQuery ();
            connection.Close();
            MessageBox.Show("Kategori başarılı bir şekilde silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QBFPK40\\SQLEXPRESS;Initial Catalog=DbistanbulAkademi;Integrated Security=True");

            connection.Open();

            SqlCommand command = new SqlCommand("Update tblcategory set categoryname=@p1 where categoryid=@p2",connection);
            command.Parameters.AddWithValue("@p1", txtCategoryname.Text);
            command.Parameters.AddWithValue("@p2", txtCategoryid.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kategori güncellemesi başarı ile tamamlandı.");
        
        }
    }
}
