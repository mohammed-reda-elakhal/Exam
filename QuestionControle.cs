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

namespace Exam
{
    public partial class QuestionControle : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NMEA8DS;Initial Catalog=Exam;Integrated Security=True");
        public QuestionControle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NouveauQCMBtn_Click(object sender, EventArgs e)
        {
            textchoix1QuestionQCM.Enabled = true;
            textchoix2QuestionQCM.Enabled = true;
            textchoix3QuestionQCM.Enabled = true;
            textRepandQuestionQCM.Enabled = true;
            textQuestionQCM.Enabled = true;
            AjouterQuestionQCM.Enabled = true;
            dataGridViewQCM.Enabled = true;
            AfficheQuestionQCM.Enabled = true;
            TextNumeroQCM.Enabled = true;



            textQuestionOuvert.Enabled = false;
            textRepandQuestionOuvert.Enabled = false;
            AjouterQuestionOuvert.Enabled = false;
            dataGridViewOuvert.Enabled = false;
            afficheQuestionOuvert.Enabled = false;
            textNumeroOuvert.Enabled = false;
        }

        private void QuestionControle_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textQuestionOuvert.Enabled = true;
            textRepandQuestionOuvert.Enabled = true;
            AjouterQuestionOuvert.Enabled = true;
            dataGridViewOuvert.Enabled = true;
            afficheQuestionOuvert.Enabled = true;
            textNumeroOuvert.Enabled = true;


            textchoix1QuestionQCM.Enabled = false;
            textchoix2QuestionQCM.Enabled = false;
            textchoix3QuestionQCM.Enabled = false;
            textRepandQuestionQCM.Enabled = false;
            textQuestionQCM.Enabled = false;
            AjouterQuestionQCM.Enabled = false;
            dataGridViewQCM.Enabled = false;
            AfficheQuestionQCM.Enabled = false;
            TextNumeroQCM.Enabled = false;
        }

        private void AjouterQuestionQCM_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Question_QCM values(@Id_QuestionQcm,@Question_Qcm,@Repand,@choix1,@choix2,@choix3)",con);
            cmd.Parameters.AddWithValue("@Id_QuestionQcm", int.Parse(TextNumeroQCM.Text));
            cmd.Parameters.AddWithValue("@Question_Qcm",textQuestionQCM.Text);
            cmd.Parameters.AddWithValue("@Repand",textRepandQuestionQCM.Text);
            cmd.Parameters.AddWithValue("@choix1",textchoix1QuestionQCM.Text);
            cmd.Parameters.AddWithValue("@choix2", textchoix2QuestionQCM.Text);
            cmd.Parameters.AddWithValue("@choix3", textchoix3QuestionQCM.Text);
            cmd.ExecuteNonQuery();
            TextNumeroQCM.Clear();
            textRepandQuestionQCM.Clear();
            textQuestionQCM.Clear();
            textchoix1QuestionQCM.Clear();
            textchoix2QuestionQCM.Clear();
            textchoix3QuestionQCM.Clear();
            con.Close();
        }

        private void AjouterQuestionOuvert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Question_Ouvert values(@Id_Question,@Question,@Repand)", con);
            cmd.Parameters.AddWithValue("@Id_Question", int.Parse(textNumeroOuvert.Text));
            cmd.Parameters.AddWithValue("@Question", textQuestionOuvert.Text);
            cmd.Parameters.AddWithValue("@Repand", textRepandQuestionOuvert.Text);
            cmd.ExecuteNonQuery();
            textRepandQuestionOuvert.Clear();
            textNumeroOuvert.Clear();
            textQuestionOuvert.Clear();
            con.Close();
        }

        private void AfficheQuestionQCM_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * From Question_QCM ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewQCM.DataSource = dt;
            con.Close();
        }

        private void afficheQuestionOuvert_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * From Question_Ouvert ", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewOuvert.DataSource = dt;
            con.Close();
        }
    }
}
