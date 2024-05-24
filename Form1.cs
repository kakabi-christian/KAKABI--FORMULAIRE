using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            string nom = txt_nom.Text;
            string profession = txt_profession.Text;
            int salaire = int.Parse(txt_salaire.Text);
            string genre = txt_genre.Text;
            string hobbies = txt_hobbies.Text;

            if(rbt_female.Checked)
            {
                genre = "feminin";
            }
            else if(rbt_male.Checked)
            {
                genre = "masculin";
            }

            if(CKB_tv.Checked)
            {
                hobbies = "la television";
            }
            else if(CKB_CINEMA.Checked)
            {
                hobbies = "le cinema";
            }


            DTGVIEW.Rows.Add(nom, profession, salaire + " FCFA" , genre, hobbies);

            

            
            
            
        }

        private void DTGVIEW_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            txt_nom.Text = "entrer votre nom ici";
            txt_profession.Text = "entrer votre profession ici";
            txt_salaire.Text = "entrer votre salire";
            rbt_female.Checked = false;
            rbt_male.Checked = false;
            CKB_CINEMA.Checked = false;
            CKB_tv.Checked = false;
            DTGVIEW.Rows.Clear();
         
        }
    }
}
