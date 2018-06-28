using System;
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
            try
            {
                using (var db = new KlantContext())
                {

                    var query = from b in db.Klanten
                                orderby b.Email
                                select b;
                    dataGridView1.DataSource = query.ToList();
                }

                using (var db = new KlantContext())
                {
                    var query = from b in db.Medicijnen
                                orderby b.MedicatieId
                                select b;
                    dataGridView3.DataSource = query.ToList();
                }

                using (var db = new KlantContext())
                {
                    var query = from b in db.Artsen
                                orderby b.ArtsId
                                select b;
                    dataGridView3.DataSource = query.ToList();
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
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
            var artsform = new Form3();
            artsform.ShowDialog();
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

            using (var db = new KlantContext())
            {
                var query = from b in db.Medicijnen
                            orderby b.MedicatieId
                            select b;
                dataGridView2.DataSource = query.ToList();
            }

            using (var db = new KlantContext())
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
                try
                {
                    if (MessageBox.Show("Weet je zeker dat je dit record wilt verwijderen ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //code uitvoeren om te verwijderen
                        using (var ctx = new KlantContext())
                        {
                            int rowindex = dataGridView1.CurrentCell.RowIndex;
                            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
                            var klant = new Klant { KlantId = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[columnindex].Value) };
                            ctx.Klanten.Attach(klant);
                            ctx.Klanten.Remove(klant);
                            ctx.SaveChanges();
                        }
                        MessageBox.Show("Succesvol verwijderd");
                    }
                    else
                    {
                        MessageBox.Show("Selecteer het id om te verwijderen");
                    }
                }
                catch (FormatException Ferror)
                {
                    MessageBox.Show("U moet expliciet een id cell selecteren. \n\n\n\n\n" + "De uitgebreide error is : " + Ferror);
                }









            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MedicatieForm = new Form4();
            MedicatieForm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
