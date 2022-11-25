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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C#\WPF\WindowsFormsApp1\WindowsFormsApp1\Curd.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSubject.Items.Clear();
            con.Open();
            string query = "Select name from data";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                cmbSubject.Items.Add(dr["name"].ToString());
            }
            con.Close();
        }

        //reset
        public void reset1()
        {
            name.Text = "";
            age.Text = "";
            address.Text = "";
            cmb.SelectedIndex = -1;
            cmbSubject.SelectedIndex = -1;
            rbtngreen.Checked = false;
            rbtnred.Checked = false;
            rbtnyellow.Checked = false;
            BackColor = Color.White;
        }

        //data show in grid view
        private void populate()
        {
            con.Open();
            string Query = "select * from fill";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            con.Close();
        }

        //reset button call
        private void reset_Click(object sender, EventArgs e)
        {
            reset1();
        }

        //Insert Code & Insert button call
        string Select;
        private void add_Click(object sender, EventArgs e)
        {
            string query = "Insert into fill values('" + name.Text + "', '" + age.Text + "', '" + address.Text + "', '" + cmb.SelectedItem.ToString() + "', '" + cmbSubject.SelectedItem.ToString() + "', '"+Select+"')";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert");
            con.Close();
            reset1();
            populate();
        }

        //view button call
        private void view_Click(object sender, EventArgs e)
        {
            populate();
        }

        //update data & button call
        private void update_Click(object sender, EventArgs e)
        {
            string query = "Update fill set name='" + name.Text + "',age='" + age.Text + "',gender='" + cmb.SelectedItem.ToString() + "',address='" + address.Text + "', subject='" + cmbSubject.SelectedIndex.ToString() + "', color='"+Select+"' where id=" + key + ";";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("update");
            con.Close();
            reset1();
            populate();
        }

        //selected data in form
        //gridview -> events -> cellclick
        int key = 0;
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset1();
            DataGridViewRow dgvRow = dgv.Rows[e.RowIndex];

            name.Text = dgvRow.Cells[1].Value.ToString();
            age.Text = dgvRow.Cells[2].Value.ToString();
            address.Text = dgvRow.Cells[3].Value.ToString();
            cmb.SelectedItem = dgvRow.Cells[4].Value.ToString();
            cmbSubject.SelectedItem = dgvRow.Cells[5].Value.ToString();

            //radiobtn value from datagrid view
            String color = dgvRow.Cells[6].Value.ToString();
            if (color == "red")
            {
                rbtnred.Checked = true;
            }else if(color == "green")
            {
                rbtngreen.Checked = true;
            }else if (color == "yellow")
            {
                rbtnyellow.Checked = true;
            }

            //for id
            if (name.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
            }
        }

        //delete data & button call
        private void delete_Click(object sender, EventArgs e)
        {
            string query = "Delete from fill where id=" + key + "";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete");
            con.Close();
            reset1();
            populate();
        }

        //radiobutton selected value
        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Select = "red";
            BackColor=Color.Red;
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Select = "green";
            BackColor = Color.Green;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Select = "yellow";
            BackColor = Color.Yellow;
        }
    }
}
