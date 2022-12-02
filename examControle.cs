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

namespace Exam
{
    public partial class examControle : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NMEA8DS;Initial Catalog=Exam;Integrated Security=True");
        public examControle()
        {
            InitializeComponent();
        }

        private void examControle_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void AfficherBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * From Exam_table", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void AjouterBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Exam_table values (@id_Exam,@nom,@temps,@durée)",con);
            cmd.Parameters.AddWithValue("@id_Exam", textNumeroEx.Text);
            cmd.Parameters.AddWithValue("@nom", textNomEx.Text);
            cmd.Parameters.AddWithValue("@durée",int.Parse(textDuréeEx.Text));
            cmd.Parameters.AddWithValue("@temps",dateTimePicker1.Value.ToString());
            textNumeroEx.Clear();
            textNumeroEx.Clear();
            textNomEx.Clear();
            textDuréeEx.Clear();
            cmd.ExecuteNonQuery();
            con.Close();


        }
    }
}
