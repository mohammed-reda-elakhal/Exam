namespace Exam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExamBtn = new System.Windows.Forms.Button();
            this.QuestionBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.examControle2 = new Exam.examControle();
            this.examControle1 = new Exam.examControle();
            this.questionControle1 = new Exam.QuestionControle();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.QuestionBtn);
            this.panel1.Controls.Add(this.ExamBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 511);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion d\'Exam";
            // 
            // ExamBtn
            // 
            this.ExamBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExamBtn.FlatAppearance.BorderSize = 0;
            this.ExamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExamBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamBtn.Location = new System.Drawing.Point(7, 106);
            this.ExamBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExamBtn.Name = "ExamBtn";
            this.ExamBtn.Size = new System.Drawing.Size(125, 46);
            this.ExamBtn.TabIndex = 2;
            this.ExamBtn.Text = "Exams";
            this.ExamBtn.UseVisualStyleBackColor = false;
            this.ExamBtn.Click += new System.EventHandler(this.ExamBtn_Click);
            // 
            // QuestionBtn
            // 
            this.QuestionBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.QuestionBtn.FlatAppearance.BorderSize = 0;
            this.QuestionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionBtn.Location = new System.Drawing.Point(7, 164);
            this.QuestionBtn.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionBtn.Name = "QuestionBtn";
            this.QuestionBtn.Size = new System.Drawing.Size(125, 46);
            this.QuestionBtn.TabIndex = 3;
            this.QuestionBtn.Text = "Question";
            this.QuestionBtn.UseVisualStyleBackColor = false;
            this.QuestionBtn.Click += new System.EventHandler(this.QuestionBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Créer :";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(7, 441);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(125, 46);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // examControle2
            // 
            this.examControle2.Location = new System.Drawing.Point(151, 4);
            this.examControle2.Name = "examControle2";
            this.examControle2.Size = new System.Drawing.Size(720, 495);
            this.examControle2.TabIndex = 2;
            // 
            // examControle1
            // 
            this.examControle1.Location = new System.Drawing.Point(146, 4);
            this.examControle1.Name = "examControle1";
            this.examControle1.Size = new System.Drawing.Size(688, 506);
            this.examControle1.TabIndex = 1;
            // 
            // questionControle1
            // 
            this.questionControle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.questionControle1.Location = new System.Drawing.Point(151, 4);
            this.questionControle1.Name = "questionControle1";
            this.questionControle1.Size = new System.Drawing.Size(720, 502);
            this.questionControle1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.questionControle1);
            this.Controls.Add(this.examControle2);
            this.Controls.Add(this.examControle1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button QuestionBtn;
        private System.Windows.Forms.Button ExamBtn;
        private System.Windows.Forms.Label label1;
        private examControle examControle1;
        private examControle examControle2;
        private System.Windows.Forms.Button ExitBtn;
        private QuestionControle questionControle1;
    }
}

