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
        KlantContext db = new KlantContext();
        KlantContext db2 = new KlantContext();


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
                MessageBox.Show("Druk straks op de 'Manual Refresh' knop !");
                

                    var query = from b in db.Klanten
                                orderby b.Email
                                select b;
                    dataGridView1.DataSource = query.ToList();
                

               
                    var query1 = from b in db.Medicijnen
                                orderby b.MedicatieId
                                select b;
                    dataGridView3.DataSource = query1.ToList();
                

                
                    var query2 = from b in db.Artsen
                                orderby b.ArtsId
                                select b;
                    dataGridView4.DataSource = query2.ToList();
                
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

            using (var db = new KlantContext())
            {
                var query = from b in db.Contracten
                            orderby b.Afloopdatum
                            select b;
                dataGridView4.DataSource = query.ToList();
            }

        }

        private void VerwijderBUTTON_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows != null)
            {
                if(!RADIOverwijderarts.Checked && !RADIOverwijdercontract.Checked && !RADIOverwijderklant.Checked && !RADIOverwijdermedicijn.Checked)
                {
                    MessageBox.Show("Selecteer een item wat u wilt verwijderen");
                }
                else
                {
                    if (RADIOverwijderarts.Checked)
                    {
                        try
                        {
                            if (MessageBox.Show("Weet je zeker dat je dit record wilt verwijderen ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //code uitvoeren om te verwijderen
                                using (var ctx = new KlantContext())
                                {
                                    int rowindex = dataGridView3.CurrentCell.RowIndex;
                                    int columnindex = dataGridView3.CurrentCell.ColumnIndex;
                                    var arts = new Arts { ArtsId = Convert.ToInt32(dataGridView3.Rows[rowindex].Cells[columnindex].Value) };
                                    ctx.Artsen.Attach(arts);
                                    ctx.Artsen.Remove(arts);
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

                    if (RADIOverwijdercontract.Checked)
                    {
                        try
                        {
                            if (MessageBox.Show("Weet je zeker dat je dit record wilt verwijderen ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //code uitvoeren om te verwijderen
                                using (var ctx = new KlantContext())
                                {
                                    int rowindex = dataGridView4.CurrentCell.RowIndex;
                                    int columnindex = dataGridView4.CurrentCell.ColumnIndex;
                                    var contract = new Contract { ContractId = Convert.ToInt32(dataGridView4.Rows[rowindex].Cells[columnindex].Value) };
                                    ctx.Contracten.Attach(contract);
                                    ctx.Contracten.Remove(contract);
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

                    if (RADIOverwijderklant.Checked)
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

                    if (RADIOverwijdermedicijn.Checked)
                    {
                        try
                        {
                            if (MessageBox.Show("Weet je zeker dat je dit record wilt verwijderen ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                //code uitvoeren om te verwijderen
                                using (var ctx = new KlantContext())
                                {
                                    int rowindex = dataGridView2.CurrentCell.RowIndex;
                                    int columnindex = dataGridView2.CurrentCell.ColumnIndex;
                                    var medicatie = new Medicatie { MedicatieId = Convert.ToInt32(dataGridView2.Rows[rowindex].Cells[columnindex].Value) };
                                    ctx.Medicijnen.Attach(medicatie);
                                    ctx.Medicijnen.Remove(medicatie);
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

        private void button3_Click(object sender, EventArgs e)
        {
            var form5 = new Form5();
            form5.ShowDialog();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (RADIOadres != null && RADIOemail != null && RADIOid != null && RADIOtelefoon != null && RADIOnaam != null )
            {
                if (RADIOid.Checked)
                {
                    ArtszoekBox.Text = "";
                    MessageBox.Show("in onderhoud");
                    

                }

                if (RADIOadres.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Artsen
                                    where b.Adresgegevens.Contains(ArtszoekBox.Text)
                                    select b;
                        dataGridView3.DataSource = query.ToList();
                    }
                }

                if (RADIOemail.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Artsen
                                    where b.Email.Contains(ArtszoekBox.Text)
                                    select b;
                        dataGridView3.DataSource = query.ToList();
                    }
                }

                if (RADIOnaam.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Artsen
                                    where b.Naam.Contains(ArtszoekBox.Text)
                                    select b;
                        dataGridView3.DataSource = query.ToList();
                    }
                }

                if (RADIOtelefoon.Checked)
                {
                    ArtszoekBox.Text = "";
                    MessageBox.Show("in onderhoud");
                    
                }


            }
            else
            {
                MessageBox.Show("Selecteer het item waarop u wilt filteren.");
            }

            
        }

        private void klantzoekBox_TextChanged(object sender, EventArgs e)
        {
            if (RADIOadresklant != null && RADIOemailklant != null && RADIOidklant != null && RADIOverzekeringklant != null && RADIOnaamklant != null)
            {
                if (RADIOidklant.Checked)
                {
                    ArtszoekBox.Text = "";
                    MessageBox.Show("in onderhoud");


                }

                if (RADIOadresklant.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Klanten
                                    where b.Adresgegevens.Contains(klantzoekBox.Text)
                                    select b;
                        dataGridView1.DataSource = query.ToList();
                    }
                }

                if (RADIOemailklant.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Klanten
                                    where b.Email.Contains(klantzoekBox.Text)
                                    select b;
                        dataGridView1.DataSource = query.ToList();
                    }
                }

                if (RADIOnaamklant.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Klanten
                                    where b.Naam.Contains(klantzoekBox.Text)
                                    select b;
                        dataGridView1.DataSource = query.ToList();
                    }
                }

                if (RADIOverzekeringklant.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Klanten
                                    where b.Verzekering.Contains(klantzoekBox.Text)
                                    select b;
                        dataGridView1.DataSource = query.ToList();
                    }

                }


            }
            else
            {
                MessageBox.Show("Selecteer het item waarop u wilt filteren.");
            }
        }

        private void medicatiezoekBox_TextChanged(object sender, EventArgs e)
        {
           
                if (RADIOidmedicatie.Checked)
                {
                    ArtszoekBox.Text = "";
                    MessageBox.Show("in onderhoud");


                }

                if (RADIOnaammedicatie.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Medicijnen
                                    where b.Naam.Contains(medicatiezoekBox.Text)
                                    select b;
                        dataGridView2.DataSource = query.ToList();
                    }
                }

                if (RADIObeschrijvingmedicatie.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Medicijnen
                                    where b.Beschrijving.Contains(medicatiezoekBox.Text)
                                    select b;
                        dataGridView2.DataSource = query.ToList();
                    }
                }

                if (RADIObijwerkingmedicatie.Checked)
                {
                    using (var db = new KlantContext())
                    {
                        var query = from b in db.Medicijnen
                                    where b.Bijwerking.Contains(medicatiezoekBox.Text)
                                    select b;
                        dataGridView2.DataSource = query.ToList();
                    }
                }


            
            
        }

        private void contractzoekBox_TextChanged(object sender, EventArgs e)
        {
            if (RADIOidcontract.Checked)
            {
                ArtszoekBox.Text = "";
                MessageBox.Show("in onderhoud");


            }

            if (RADIOdoktercontract.Checked)
            {
                using (var db = new KlantContext())
                {
                    var query = from b in db.Contracten
                                where b.Dokter.Contains(contractzoekBox.Text)
                                select b;
                    dataGridView4.DataSource = query.ToList();
                }
            }

            if (RADIOfunctiecontract.Checked)
            {
                using (var db = new KlantContext())
                {
                    var query = from b in db.Contracten
                                where b.Functie.Contains(contractzoekBox.Text)
                                select b;
                    dataGridView4.DataSource = query.ToList();
                }
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentKlant.Naam = NaamBOX.Text.ToString();
            currentKlant.Verzekering = ZorgverzekeringBOX.Text.ToString();
            currentKlant.Adresgegevens = AdresBOX.Text.ToString();
            currentKlant.Email = EmailBOX.Text.ToString();

            db.SaveChanges();

            using (var db = new KlantContext())
            {
                var query = from b in db.Klanten
                            orderby b.KlantId
                            select b;
                dataGridView1.DataSource = query.ToList();
            }
        }
        Klant currentKlant;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentKlant = (Klant)dataGridView1.CurrentRow.DataBoundItem;

                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                klantid.Text = currentKlant.KlantId.ToString();
                ZorgverzekeringBOX.Text = currentKlant.Verzekering.ToString();
                NaamBOX.Text = currentKlant.Naam.ToString();
                AdresBOX.Text = currentKlant.Adresgegevens.ToString();
                EmailBOX.Text = currentKlant.Email.ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentArts.Naam = ArstNaamBOX.Text.ToString();
            //currentArts.Verzekering = ZorgverzekeringBOX.Text.ToString();
            currentArts.Adresgegevens = ArtsAdresBOX.Text.ToString();
            currentArts.Email = ArtsEmailBOX.Text.ToString();

            db2.SaveChanges();
        }

        Arts currentArts;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                currentArts = (Arts)dataGridView3.CurrentRow.DataBoundItem;

                ArtsIDBOX.Text = currentArts.ArtsId.ToString();
                // ArtsContractBOX.Text = currentArts. .ToString();
                ArtsEmailBOX.Text = currentArts.Email.ToString();
                ArtsAdresBOX.Text = currentArts.Adresgegevens.ToString();
                ArstNaamBOX.Text = currentArts.Naam.ToString();
                
            }
        }

        private void ArstNaamBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
