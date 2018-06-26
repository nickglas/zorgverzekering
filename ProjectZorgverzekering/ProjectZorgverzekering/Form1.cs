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
            var artsform = new Form3();
            artsform.ShowDialog();
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new KlantContext())
            {
                var query = from b in db.Klanten
                            orderby b.Email
                            select b;
                dataGridView1.DataSource = query.ToList();
            }
        }
    }
}
