using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjectZorgverzekering.Classes;

namespace ProjectZorgverzekering
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new MedicatieContext())
                {
                    string Naam = NaamBox.Text;
                    string Beschrijving = BeschrijvingBox.Text;
                    string Bijwerkingen = BijwerkingBox.Text;

                    var medicijn = new Medicatie
                    {
                        
                        Naam = Naam ,
                        Beschrijving = Beschrijving ,
                        Bijwerking = Bijwerkingen
                       
                    };

                    db.Medicijnen.Add(medicijn);
                    db.SaveChanges();

                    var query = from b in db.Medicijnen
                                orderby b.MedicatieId
                                select b;
                    var Form1 = new Form1();
                    Form1.dataGridView2.DataSource = query.ToList();
                    Hide();
                }
            }
            catch (Exception Eerror)
            {

                MessageBox.Show(Eerror.Message);
            }
        }
    }
}
