using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MOSTRAR_Click(object sender, EventArgs e)
        {   
            
            // variable 
            decimal numero ;

            numero = Convert.ToDecimal(Text);


            MessageBox.Show(Mensaje( numero));
            MessageBox.Show(Aviso( numero));
        }

        private string Mensaje(decimal num1) {
            string mensaje = "";
            if (num1%2==0) {

                mensaje ="EL NUMERO ES IMPAR ";
            
            
            }else if (num1%2==1)
            {

                mensaje = "EL NUMERO ES PAR ";
            }

            return mensaje;
        }


        private string Aviso( decimal n1) {
            string avis = "";

            if (n1 > 0)
            {

                avis = "ES POSITIVO ";


            }
            else if (n1 < 0)
            {

               avis = "ES NEGATIVO ";
            }

            return avis;



        }



    }
}
