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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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
                    string Telefoon = TelefoonBox.Text;
                    

                    var Arts = new Arts
                    {
                        Naam = Naam ,
                        Email = Email ,
                        Adresgegevens = Adresgegevens ,
                        Telefoon = Telefoon
                       
                    };

                    db.Artsen.Add(Arts);
                    db.SaveChanges();

                    var query = from b in db.Artsen
                                orderby b.ArtsId
                                select b;

                    var Form1 = new Form1();
                    Form1.dataGridView3.DataSource = query.ToList();
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
