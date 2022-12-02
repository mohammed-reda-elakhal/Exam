namespace Exam
{
    partial class QuestionControle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NouveauQCMBtn = new System.Windows.Forms.Button();
            this.textQuestionQCM = new System.Windows.Forms.TextBox();
            this.textRepandQuestionQCM = new System.Windows.Forms.TextBox();
            this.textchoix1QuestionQCM = new System.Windows.Forms.TextBox();
            this.textchoix2QuestionQCM = new System.Windows.Forms.TextBox();
            this.textchoix3QuestionQCM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AjouterQuestionQCM = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textRepandQuestionOuvert = new System.Windows.Forms.TextBox();
            this.textQuestionOuvert = new System.Windows.Forms.TextBox();
            this.AjouterQuestionOuvert = new System.Windows.Forms.Button();
            this.dataGridViewQCM = new System.Windows.Forms.DataGridView();
            this.dataGridViewOuvert = new System.Windows.Forms.DataGridView();
            this.AfficheQuestionQCM = new System.Windows.Forms.Button();
            this.afficheQuestionOuvert = new System.Windows.Forms.Button();
            this.TextNumeroQCM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textNumeroOuvert = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQCM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOuvert)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 36);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(290, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questions ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.TextNumeroQCM);
            this.panel2.Controls.Add(this.AfficheQuestionQCM);
            this.panel2.Controls.Add(this.dataGridViewQCM);
            this.panel2.Controls.Add(this.AjouterQuestionQCM);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textchoix3QuestionQCM);
            this.panel2.Controls.Add(this.textchoix2QuestionQCM);
            this.panel2.Controls.Add(this.textchoix1QuestionQCM);
            this.panel2.Controls.Add(this.textRepandQuestionQCM);
            this.panel2.Controls.Add(this.textQuestionQCM);
            this.panel2.Controls.Add(this.NouveauQCMBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 464);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Questions QCM";
            // 
            // NouveauQCMBtn
            // 
            this.NouveauQCMBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NouveauQCMBtn.FlatAppearance.BorderSize = 0;
            this.NouveauQCMBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NouveauQCMBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NouveauQCMBtn.Location = new System.Drawing.Point(253, 6);
            this.NouveauQCMBtn.Name = "NouveauQCMBtn";
            this.NouveauQCMBtn.Size = new System.Drawing.Size(79, 25);
            this.NouveauQCMBtn.TabIndex = 2;
            this.NouveauQCMBtn.Text = "Nouveau";
            this.NouveauQCMBtn.UseVisualStyleBackColor = false;
            this.NouveauQCMBtn.Click += new System.EventHandler(this.NouveauQCMBtn_Click);
            // 
            // textQuestionQCM
            // 
            this.textQuestionQCM.Enabled = false;
            this.textQuestionQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuestionQCM.Location = new System.Drawing.Point(113, 72);
            this.textQuestionQCM.Name = "textQuestionQCM";
            this.textQuestionQCM.Size = new System.Drawing.Size(219, 29);
            this.textQuestionQCM.TabIndex = 3;
            // 
            // textRepandQuestionQCM
            // 
            this.textRepandQuestionQCM.Enabled = false;
            this.textRepandQuestionQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRepandQuestionQCM.Location = new System.Drawing.Point(113, 105);
            this.textRepandQuestionQCM.Name = "textRepandQuestionQCM";
            this.textRepandQuestionQCM.Size = new System.Drawing.Size(219, 29);
            this.textRepandQuestionQCM.TabIndex = 4;
            // 
            // textchoix1QuestionQCM
            // 
            this.textchoix1QuestionQCM.Enabled = false;
            this.textchoix1QuestionQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchoix1QuestionQCM.Location = new System.Drawing.Point(113, 140);
            this.textchoix1QuestionQCM.Name = "textchoix1QuestionQCM";
            this.textchoix1QuestionQCM.Size = new System.Drawing.Size(219, 29);
            this.textchoix1QuestionQCM.TabIndex = 5;
            // 
            // textchoix2QuestionQCM
            // 
            this.textchoix2QuestionQCM.Enabled = false;
            this.textchoix2QuestionQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchoix2QuestionQCM.Location = new System.Drawing.Point(113, 175);
            this.textchoix2QuestionQCM.Name = "textchoix2QuestionQCM";
            this.textchoix2QuestionQCM.Size = new System.Drawing.Size(219, 29);
            this.textchoix2QuestionQCM.TabIndex = 6;
            // 
            // textchoix3QuestionQCM
            // 
            this.textchoix3QuestionQCM.Enabled = false;
            this.textchoix3QuestionQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textchoix3QuestionQCM.Location = new System.Drawing.Point(113, 210);
            this.textchoix3QuestionQCM.Name = "textchoix3QuestionQCM";
            this.textchoix3QuestionQCM.Size = new System.Drawing.Size(219, 29);
            this.textchoix3QuestionQCM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Question";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Repand Crc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Choix1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Choix2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Choix3";
            // 
            // AjouterQuestionQCM
            // 
            this.AjouterQuestionQCM.Enabled = false;
            this.AjouterQuestionQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterQuestionQCM.Location = new System.Drawing.Point(16, 260);
            this.AjouterQuestionQCM.Name = "AjouterQuestionQCM";
            this.AjouterQuestionQCM.Size = new System.Drawing.Size(97, 31);
            this.AjouterQuestionQCM.TabIndex = 14;
            this.AjouterQuestionQCM.Text = "Ajouter";
            this.AjouterQuestionQCM.UseVisualStyleBackColor = true;
            this.AjouterQuestionQCM.Click += new System.EventHandler(this.AjouterQuestionQCM_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textNumeroOuvert);
            this.panel3.Controls.Add(this.afficheQuestionOuvert);
            this.panel3.Controls.Add(this.dataGridViewOuvert);
            this.panel3.Controls.Add(this.AjouterQuestionOuvert);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textRepandQuestionOuvert);
            this.panel3.Controls.Add(this.textQuestionOuvert);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(347, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 464);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Questions Ouvert";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Repand Crc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Question";
            // 
            // textRepandQuestionOuvert
            // 
            this.textRepandQuestionOuvert.Enabled = false;
            this.textRepandQuestionOuvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRepandQuestionOuvert.Location = new System.Drawing.Point(112, 152);
            this.textRepandQuestionOuvert.Multiline = true;
            this.textRepandQuestionOuvert.Name = "textRepandQuestionOuvert";
            this.textRepandQuestionOuvert.Size = new System.Drawing.Size(219, 85);
            this.textRepandQuestionOuvert.TabIndex = 16;
            // 
            // textQuestionOuvert
            // 
            this.textQuestionOuvert.Enabled = false;
            this.textQuestionOuvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuestionOuvert.Location = new System.Drawing.Point(112, 70);
            this.textQuestionOuvert.Multiline = true;
            this.textQuestionOuvert.Name = "textQuestionOuvert";
            this.textQuestionOuvert.Size = new System.Drawing.Size(219, 76);
            this.textQuestionOuvert.TabIndex = 15;
            // 
            // AjouterQuestionOuvert
            // 
            this.AjouterQuestionOuvert.Enabled = false;
            this.AjouterQuestionOuvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjouterQuestionOuvert.Location = new System.Drawing.Point(21, 258);
            this.AjouterQuestionOuvert.Name = "AjouterQuestionOuvert";
            this.AjouterQuestionOuvert.Size = new System.Drawing.Size(97, 31);
            this.AjouterQuestionOuvert.TabIndex = 15;
            this.AjouterQuestionOuvert.Text = "Ajouter";
            this.AjouterQuestionOuvert.UseVisualStyleBackColor = true;
            this.AjouterQuestionOuvert.Click += new System.EventHandler(this.AjouterQuestionOuvert_Click);
            // 
            // dataGridViewQCM
            // 
            this.dataGridViewQCM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQCM.Enabled = false;
            this.dataGridViewQCM.Location = new System.Drawing.Point(12, 297);
            this.dataGridViewQCM.Name = "dataGridViewQCM";
            this.dataGridViewQCM.Size = new System.Drawing.Size(319, 152);
            this.dataGridViewQCM.TabIndex = 15;
            // 
            // dataGridViewOuvert
            // 
            this.dataGridViewOuvert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOuvert.Enabled = false;
            this.dataGridViewOuvert.Location = new System.Drawing.Point(15, 297);
            this.dataGridViewOuvert.Name = "dataGridViewOuvert";
            this.dataGridViewOuvert.Size = new System.Drawing.Size(324, 151);
            this.dataGridViewOuvert.TabIndex = 19;
            // 
            // AfficheQuestionQCM
            // 
            this.AfficheQuestionQCM.Enabled = false;
            this.AfficheQuestionQCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfficheQuestionQCM.Location = new System.Drawing.Point(119, 259);
            this.AfficheQuestionQCM.Name = "AfficheQuestionQCM";
            this.AfficheQuestionQCM.Size = new System.Drawing.Size(97, 31);
            this.AfficheQuestionQCM.TabIndex = 16;
            this.AfficheQuestionQCM.Text = "Affiche";
            this.AfficheQuestionQCM.UseVisualStyleBackColor = true;
            this.AfficheQuestionQCM.Click += new System.EventHandler(this.AfficheQuestionQCM_Click);
            // 
            // afficheQuestionOuvert
            // 
            this.afficheQuestionOuvert.Enabled = false;
            this.afficheQuestionOuvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficheQuestionOuvert.Location = new System.Drawing.Point(124, 258);
            this.afficheQuestionOuvert.Name = "afficheQuestionOuvert";
            this.afficheQuestionOuvert.Size = new System.Drawing.Size(97, 31);
            this.afficheQuestionOuvert.TabIndex = 17;
            this.afficheQuestionOuvert.Text = "Affiche";
            this.afficheQuestionOuvert.UseVisualStyleBackColor = true;
            this.afficheQuestionOuvert.Click += new System.EventHandler(this.afficheQuestionOuvert_Click);
            // 
            // TextNumeroQCM
            // 
            this.TextNumeroQCM.Enabled = false;
            this.TextNumeroQCM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNumeroQCM.Location = new System.Drawing.Point(112, 37);
            this.TextNumeroQCM.Name = "TextNumeroQCM";
            this.TextNumeroQCM.Size = new System.Drawing.Size(41, 29);
            this.TextNumeroQCM.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "Numero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Numero";
            // 
            // textNumeroOuvert
            // 
            this.textNumeroOuvert.Enabled = false;
            this.textNumeroOuvert.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeroOuvert.Location = new System.Drawing.Point(112, 33);
            this.textNumeroOuvert.Name = "textNumeroOuvert";
            this.textNumeroOuvert.Size = new System.Drawing.Size(41, 29);
            this.textNumeroOuvert.TabIndex = 19;
            // 
            // QuestionControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuestionControle";
            this.Size = new System.Drawing.Size(700, 500);
            this.Load += new System.EventHandler(this.QuestionControle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQCM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOuvert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button NouveauQCMBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewQCM;
        private System.Windows.Forms.Button AjouterQuestionQCM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textchoix3QuestionQCM;
        private System.Windows.Forms.TextBox textchoix2QuestionQCM;
        private System.Windows.Forms.TextBox textchoix1QuestionQCM;
        private System.Windows.Forms.TextBox textRepandQuestionQCM;
        private System.Windows.Forms.TextBox textQuestionQCM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewOuvert;
        private System.Windows.Forms.Button AjouterQuestionOuvert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRepandQuestionOuvert;
        private System.Windows.Forms.TextBox textQuestionOuvert;
        private System.Windows.Forms.Button AfficheQuestionQCM;
        private System.Windows.Forms.Button afficheQuestionOuvert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TextNumeroQCM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textNumeroOuvert;
    }
}
