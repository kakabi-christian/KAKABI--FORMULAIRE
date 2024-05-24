namespace test7
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
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_save = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_envoyer = new System.Windows.Forms.Button();
            this.CKB_CINEMA = new System.Windows.Forms.CheckBox();
            this.CKB_tv = new System.Windows.Forms.CheckBox();
            this.rbt_female = new System.Windows.Forms.RadioButton();
            this.rbt_male = new System.Windows.Forms.RadioButton();
            this.txt_hobbies = new System.Windows.Forms.TextBox();
            this.txt_genre = new System.Windows.Forms.TextBox();
            this.txt_salaire = new System.Windows.Forms.TextBox();
            this.txt_profession = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.DTGVIEW = new System.Windows.Forms.DataGridView();
            this.colon_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colon_profession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colon_salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colon_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colon_hobbies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVIEW)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-25, 580);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1167, 87);
            this.label6.TabIndex = 24;
            this.label6.Text = "KAKABI CHRISTIAN 😎👽👽";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_save
            // 
            this.LBL_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LBL_save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_save.Location = new System.Drawing.Point(-13, 7);
            this.LBL_save.Name = "LBL_save";
            this.LBL_save.Size = new System.Drawing.Size(1167, 38);
            this.LBL_save.TabIndex = 23;
            this.LBL_save.Text = "ENREGISTREMENT";
            this.LBL_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.Black;
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(652, 245);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(250, 112);
            this.btn_annuler.TabIndex = 22;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_envoyer
            // 
            this.btn_envoyer.BackColor = System.Drawing.Color.Black;
            this.btn_envoyer.ForeColor = System.Drawing.Color.White;
            this.btn_envoyer.Location = new System.Drawing.Point(652, 69);
            this.btn_envoyer.Name = "btn_envoyer";
            this.btn_envoyer.Size = new System.Drawing.Size(250, 113);
            this.btn_envoyer.TabIndex = 21;
            this.btn_envoyer.Text = "Envoyer";
            this.btn_envoyer.UseVisualStyleBackColor = false;
            this.btn_envoyer.Click += new System.EventHandler(this.btn_envoyer_Click);
            // 
            // CKB_CINEMA
            // 
            this.CKB_CINEMA.AutoSize = true;
            this.CKB_CINEMA.BackColor = System.Drawing.Color.White;
            this.CKB_CINEMA.Location = new System.Drawing.Point(463, 336);
            this.CKB_CINEMA.Name = "CKB_CINEMA";
            this.CKB_CINEMA.Size = new System.Drawing.Size(77, 21);
            this.CKB_CINEMA.TabIndex = 20;
            this.CKB_CINEMA.Text = "Cinema";
            this.CKB_CINEMA.UseVisualStyleBackColor = false;
            // 
            // CKB_tv
            // 
            this.CKB_tv.AutoSize = true;
            this.CKB_tv.BackColor = System.Drawing.Color.White;
            this.CKB_tv.Location = new System.Drawing.Point(357, 336);
            this.CKB_tv.Name = "CKB_tv";
            this.CKB_tv.Size = new System.Drawing.Size(48, 21);
            this.CKB_tv.TabIndex = 19;
            this.CKB_tv.Text = "TV";
            this.CKB_tv.UseVisualStyleBackColor = false;
            // 
            // rbt_female
            // 
            this.rbt_female.AutoSize = true;
            this.rbt_female.BackColor = System.Drawing.Color.White;
            this.rbt_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_female.Location = new System.Drawing.Point(463, 272);
            this.rbt_female.Name = "rbt_female";
            this.rbt_female.Size = new System.Drawing.Size(81, 21);
            this.rbt_female.TabIndex = 17;
            this.rbt_female.TabStop = true;
            this.rbt_female.Text = "Female";
            this.rbt_female.UseVisualStyleBackColor = false;
            // 
            // rbt_male
            // 
            this.rbt_male.AutoSize = true;
            this.rbt_male.BackColor = System.Drawing.Color.White;
            this.rbt_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_male.Location = new System.Drawing.Point(358, 272);
            this.rbt_male.Name = "rbt_male";
            this.rbt_male.Size = new System.Drawing.Size(70, 21);
            this.rbt_male.TabIndex = 18;
            this.rbt_male.TabStop = true;
            this.rbt_male.Text = "MALE";
            this.rbt_male.UseVisualStyleBackColor = false;
            // 
            // txt_hobbies
            // 
            this.txt_hobbies.BackColor = System.Drawing.Color.White;
            this.txt_hobbies.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hobbies.Location = new System.Drawing.Point(333, 323);
            this.txt_hobbies.Name = "txt_hobbies";
            this.txt_hobbies.Size = new System.Drawing.Size(279, 43);
            this.txt_hobbies.TabIndex = 16;
            // 
            // txt_genre
            // 
            this.txt_genre.BackColor = System.Drawing.Color.White;
            this.txt_genre.Font = new System.Drawing.Font("Algerian", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_genre.Location = new System.Drawing.Point(333, 260);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(279, 43);
            this.txt_genre.TabIndex = 15;
            // 
            // txt_salaire
            // 
            this.txt_salaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_salaire.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salaire.Location = new System.Drawing.Point(343, 197);
            this.txt_salaire.Name = "txt_salaire";
            this.txt_salaire.Size = new System.Drawing.Size(269, 30);
            this.txt_salaire.TabIndex = 14;
            this.txt_salaire.Text = "votre salaire ici";
            // 
            // txt_profession
            // 
            this.txt_profession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_profession.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_profession.Location = new System.Drawing.Point(343, 126);
            this.txt_profession.Name = "txt_profession";
            this.txt_profession.Size = new System.Drawing.Size(269, 30);
            this.txt_profession.TabIndex = 13;
            this.txt_profession.Text = "votre profession ici";
            // 
            // txt_nom
            // 
            this.txt_nom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_nom.Font = new System.Drawing.Font("Algerian", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nom.Location = new System.Drawing.Point(343, 69);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(269, 30);
            this.txt_nom.TabIndex = 12;
            this.txt_nom.Text = "votre nom ici";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 46);
            this.label5.TabIndex = 11;
            this.label5.Text = "HOBBIES";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 46);
            this.label4.TabIndex = 10;
            this.label4.Text = "GENRE";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "SALAIRE";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "PROFESSION";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOM";
            // 
            // DTGVIEW
            // 
            this.DTGVIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colon_nom,
            this.Colon_profession,
            this.Colon_salaire,
            this.colon_genre,
            this.Colon_hobbies});
            this.DTGVIEW.Location = new System.Drawing.Point(1, 426);
            this.DTGVIEW.Name = "DTGVIEW";
            this.DTGVIEW.RowTemplate.Height = 24;
            this.DTGVIEW.Size = new System.Drawing.Size(943, 115);
            this.DTGVIEW.TabIndex = 25;
            this.DTGVIEW.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVIEW_CellContentClick);
            // 
            // colon_nom
            // 
            this.colon_nom.HeaderText = "NOM";
            this.colon_nom.MaxInputLength = 35000;
            this.colon_nom.MinimumWidth = 10;
            this.colon_nom.Name = "colon_nom";
            this.colon_nom.Width = 200;
            // 
            // Colon_profession
            // 
            this.Colon_profession.HeaderText = "PROFESSION";
            this.Colon_profession.Name = "Colon_profession";
            this.Colon_profession.Width = 200;
            // 
            // Colon_salaire
            // 
            this.Colon_salaire.HeaderText = "SALAIRE";
            this.Colon_salaire.Name = "Colon_salaire";
            this.Colon_salaire.Width = 200;
            // 
            // colon_genre
            // 
            this.colon_genre.HeaderText = "GENRE";
            this.colon_genre.Name = "colon_genre";
            this.colon_genre.Width = 150;
            // 
            // Colon_hobbies
            // 
            this.Colon_hobbies.HeaderText = "HOBBIES";
            this.Colon_hobbies.Name = "Colon_hobbies";
            this.Colon_hobbies.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::test7.Properties.Resources._7447;
            this.ClientSize = new System.Drawing.Size(942, 676);
            this.Controls.Add(this.DTGVIEW);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_save);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_envoyer);
            this.Controls.Add(this.CKB_CINEMA);
            this.Controls.Add(this.CKB_tv);
            this.Controls.Add(this.rbt_female);
            this.Controls.Add(this.rbt_male);
            this.Controls.Add(this.txt_hobbies);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.txt_salaire);
            this.Controls.Add(this.txt_profession);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVIEW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_save;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_envoyer;
        private System.Windows.Forms.CheckBox CKB_CINEMA;
        private System.Windows.Forms.CheckBox CKB_tv;
        private System.Windows.Forms.RadioButton rbt_female;
        private System.Windows.Forms.RadioButton rbt_male;
        private System.Windows.Forms.TextBox txt_hobbies;
        private System.Windows.Forms.TextBox txt_genre;
        private System.Windows.Forms.TextBox txt_salaire;
        private System.Windows.Forms.TextBox txt_profession;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DTGVIEW;
        private System.Windows.Forms.DataGridViewTextBoxColumn colon_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colon_profession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colon_salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colon_genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colon_hobbies;
    }
}

