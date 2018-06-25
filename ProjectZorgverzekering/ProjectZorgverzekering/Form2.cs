using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    string Naam = NaamBox.ToString();
                    string Email = EmailBox.ToString();
                    string Adresgegevens = AdresBox.ToString();
                    string Zorgverzekering = VerzekeringBox.ToString();

                    var klant = new Klant { Naam = Naam , Email = Email , Adresgegevens = Adresgegevens , ZorgverzekeringId = 1  };
                    db.Klant.Add(klant);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
