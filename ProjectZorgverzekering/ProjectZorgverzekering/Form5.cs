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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (var db = new KlantContext())
                {
                    string artsbox = ArtsBox.Text;
                    string functie = FunctieBox.Text;
                    string email = EmailBox.Text;
                    DateTime aflooptdatum = dateTimePicker1.Value.Date;



                    var contract = new Contract
                    {
                       Dokter = artsbox ,
                       Functie = functie ,
                       Afloopdatum = aflooptdatum,
                       Email = email
                    };

                    db.Contracten.Add(contract);
                    db.SaveChanges();

                    var query = from b in db.Contracten
                                orderby b.Afloopdatum
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
