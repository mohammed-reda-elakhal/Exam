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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NMEA8DS;Initial Catalog=Exam;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExamBtn_Click(object sender, EventArgs e)
        {
            examControle1.Visible = true;
            questionControle1.Visible= false;
            ExamBtn.ForeColor = System.Drawing.Color.Green;
            QuestionBtn.ForeColor = System.Drawing.Color.White;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuestionBtn_Click(object sender, EventArgs e)
        {
            questionControle1.Visible = true;
            examControle1.Visible = false;
            ExamBtn.ForeColor = System.Drawing.Color.White;
            QuestionBtn.ForeColor = System.Drawing.Color.Green;
        }
    }
}
