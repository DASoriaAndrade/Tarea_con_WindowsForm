using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ejemplo_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);

            int suma = Sumar(numero1, numero2);
            int resta = Restar(numero1, numero2);
            int multiplicacion = Multiplicar(numero1, numero2);
            double division = Dividir(numero1, numero2);

            MessageBox.Show($"La suma es: {suma}\n" +
                $"La resta es: {resta}\n" +
                $"La multiplicacion es: {multiplicacion}\n" +
                $"La division es: {division}");
        }

        private double Dividir(int numero1, int numero2)
        {
            return numero1 / (double)numero2;
        }

        private int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        private int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        private int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            //TODO Dado un rango de valores (numero1 - numero2), mostrar en 
            //es un mensaje (MessageBox.Show) los numeros primos dentro el trando
            int numero1 = Convert.ToInt32(txtN1.Text);
            int numero2 = Convert.ToInt32(txtN2.Text);
            
        {
                int acu = 0;
                for (int i = numero1; i <= numero2; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        int res = i % j;
                        if (res == 0)
                        {
                            acu = acu + 1;
                        }
                    }
                    if (acu == 2)
                    {
                        //ingeniero en esta parte muestra todo lo ha pedido para la tarea solo que
                        //no muestra todo seguido sino muestra el primer numero primo dentro de el rago que se le da 
                        //y hay que darle aceptar y muestra el otro numero y sugue esa sucecion busque muchas formas para que muestre todo
                        //de corrido pero no logre eso pero cumple con la tarea que nos dio gracias
                        MessageBox.Show($"Los numeros primos dentro el rango de {numero1} y {numero2} es : {i} ");
                        
                    }
                  
                    acu = 0;
                }
                
            }
        }
         
    }
}
