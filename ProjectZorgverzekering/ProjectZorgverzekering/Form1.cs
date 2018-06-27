﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static ProjectZorgverzekering.Classes;

namespace ProjectZorgverzekering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            using (var db = new KlantContext())
            {
                
                var query = from b in db.Klanten
                            orderby b.Email
                            select b;
                dataGridView1.DataSource = query.ToList();
            }

            using (var db = new MedicatieContext())
            {
                var query = from b in db.Medicijnen
                            orderby b.MedicatieId
                            select b;
                dataGridView3.DataSource = query.ToList();
            }

            using (var db = new ArtsContext())
            {
                var query = from b in db.Artsen
                            orderby b.ArtsId
                            select b;
                dataGridView3.DataSource = query.ToList();
            }

        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void label11_Click(object sender, EventArgs e)
        {

        }

        public void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.KLANT' table. You can move, or remove it, as needed.
            using (var db = new KlantContext())
            {

                var query = from b in db.Klanten
                            orderby b.Email
                            select b;
                dataGridView1.DataSource = query.ToList();
            }

            using (var db = new MedicatieContext())
            {
                var query = from b in db.Medicijnen
                            orderby b.MedicatieId
                            select b;
                dataGridView3.DataSource = query.ToList();
            }

            using (var db = new ArtsContext())
            {
                var query = from b in db.Artsen
                            orderby b.ArtsId
                            select b;
                dataGridView3.DataSource = query.ToList();
            }
        }

        public void KlantInvoegenKNOP_Click(object sender, EventArgs e)
        {
            //klanten
            var klantform = new Form2();
            klantform.ShowDialog();
        }

        public void ArtsInvoegenKNOP_Click(object sender, EventArgs e)
        {
            //artsen
            
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new KlantContext())
            {
                var query = from b in db.Klanten
                            orderby b.KlantId
                            select b;
                dataGridView1.DataSource = query.ToList();
            }

            using (var db = new MedicatieContext())
            {
                var query = from b in db.Medicijnen
                            orderby b.MedicatieId
                            select b;
                dataGridView2.DataSource = query.ToList();
            }

            using (var db = new ArtsContext())
            {
                var query = from b in db.Artsen
                            orderby b.ArtsId
                            select b;
                dataGridView3.DataSource = query.ToList();
            }

           
        }

        private void VerwijderBUTTON_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
               if(MessageBox.Show("Weet je zeker dat je dit record wilt verwijderen ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    //code uitvoeren om te verwijderen
                    
                    MessageBox.Show("Succesvol verwijderd");
                } else
                {
                    MessageBox.Show("Verwijderen geannuleerd !");
                }
            }
            else
            {
                MessageBox.Show("Selecteer het id om te verwijderen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MedicatieForm = new Form4();
            MedicatieForm.ShowDialog();
        }
    }
}
