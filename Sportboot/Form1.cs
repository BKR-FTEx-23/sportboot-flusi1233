using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sportboot
{
    
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> listboote = new List<string>();

        
        string Nummer;
        string Länge;
        string leistung;

        
        public Form1()
        {

            InitializeComponent();


            for (int i = 0; i < 4; i++)
            {
                listboote.Add(random.Next(999)+";" + random.Next(100)+";"+ random.Next(200));
                Sportboot sportboot = new Sportboot(listboote[i]);
                txtAusgabe.Text+= sportboot.ToString();
                                
            }
        }

        private void btnBootabspeichern_Click(object sender, EventArgs e)
        {
            Nummer=txtNummer.Text;
            Länge=txtLänge.Text;
            leistung=txtLeistung.Text;
            Sportboot Boot = new Sportboot(Nummer,Länge,leistung);

            txtAusgabe.Text+=Boot.ToString();
            listboote.Add(txtNummer.Text+ ";" + txtLänge.Text + ";" +  txtLeistung.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sportboot Testboot = new Sportboot(listboote[0]);
            if(Testboot.Fuhrerscheinpflicht == true)
            {

                lbl_Führerscheinpflicht.Text = "Führerscheinpflicht";

            }
            else
            {
                lbl_Führerscheinpflicht.Text = "Keine Führerscheinpflicht";


            }
        }

        private void btnGewicht_Click(object sender, EventArgs e)
        {
            Sportboot Testboot = new Sportboot(listboote[0]);
            lblGewicht.Text = Convert.ToString(Testboot.Gewicht);

        }
    }
}
