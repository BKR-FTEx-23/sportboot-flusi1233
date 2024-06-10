using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sportboot
{
    public class Sportboot
    {
        double bootsnummer;
        double länge;
        double leistung;
        double gewicht;
        bool führerscheinpflicht;
       

        public Sportboot(string p_bootsnummer, string p_länge, string p_leistung)
        {
            bootsnummer = Convert.ToDouble(p_bootsnummer);
            länge = Convert.ToDouble(p_länge);
            leistung = Convert.ToDouble(p_leistung);

        }
        public Sportboot(string p)
        {
            String[] zerlegung=p.Split(';');
            bootsnummer = Convert.ToDouble(zerlegung[0]);
            länge=Convert.ToDouble(zerlegung[1]);
            leistung=Convert.ToDouble(zerlegung[2]);
        }

        public Sportboot()
        {
            bootsnummer=0;
            länge=0;
            leistung=0;
        }

        public bool Fuhrerscheinpflicht
        {
            get
            {

                return Fuhrerscheinpflicht;



            }
                
                
                
                
            set
            {
                if(leistung>11)
                {


                    führerscheinpflicht = true;


                }
                else
                {


                    führerscheinpflicht=false;



                }





            }
        }

        public double Gewicht
        {
            get
            {
                return gewicht;

            }
            set
            {

                gewicht = 275 * länge - 1125;


            }
        }

        public override string ToString()
        {
            return "Bootsnummer:" + bootsnummer+ "; Länge:" + länge+"m"+ "; Motorleistung:"+ leistung+"kw"+"\r\n" ;
        }
    }
}