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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new KlantContext())
                {
                    
                    string Naam = NaamBox.Text;
                    string Email = EmailBox.Text;
                    string Adresgegevens = AdresBox.Text;
                    string Zorgverzekering = VerzekeringBox.Text;

                    var klant = new Klant
                    {
                        
                        Naam = Naam,
                        Email = Email,
                        Adresgegevens = Adresgegevens,
                        Verzekering = Zorgverzekering.ToString()
                    };

                    db.Klanten.Add(klant);
                    db.SaveChanges();

                    var query = from b in db.Klanten
                                orderby b.KlantId
                                select b;
                    var Form1 = new Form1();
                    Form1.dataGridView1.DataSource = query.ToList();
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
