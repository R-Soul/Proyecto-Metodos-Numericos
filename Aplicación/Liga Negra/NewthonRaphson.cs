using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga_Negra
{
    public partial class pNewthonRaphson : Form
    {
        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pNewthonRaphson instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;


        /*-----------------------------------------*/
        /*FUNCIONES OPERACIONALES (NEWTHON RAPHSON)*/
        /*-----------------------------------------*/


        /* Nombre: newtRaph
         * Descripción: Realiza el método de Newton Raphson, regresando la raiz una vez que la diferencia es tan baja que se considera 0.
         * 
         * Fecha de Creación: 28/04/2016
         * Autor Original: Ricardo Trevizo
         * 
         * Última Fecha de Modificación: 28/04/2016
         * Autor Última Moficiación: Ricardo Trevizo
         * 
         * Programas que Llama: horner
         * Programas que lo Llaman: bCalcRaph_Click
         * 
         * Este metodo hace uso de la recursividad para calcular un resultado.
        */
        public double newtRaph(double[] coeffs, double iniValue, int iter) {

            //Este arreglo son los valores evaluados por horner, para facilitar el obtener la evaluacion y derivadas.
            double[] data = pHorner.instance.horner(coeffs, iniValue);
   



            //Aqui vamos a asignarle variables a f(x) y a f'(x) para facilitar su uso
            int miLongitud = data.Length;
            double evaluacion = data[miLongitud-1];
            double firstder = data[miLongitud - 2];

            //Esta variable es lo que vamos a restarle a nuestro valor de x anterior para obtener el nuevo valor de x
            //Esta variable es la divicion entre f(x) y f'(x)
            double diferencia = evaluacion / firstder;

            //Este valor sirve para hacer una correccion facil de los digitos a los que voy a considerar que un numero es = 0
            int digDeadzone = 7;

            //Si la variable diferencia es menor a 1 x 10 ^ -digDeadzone pero mayor al mismo valor * -1 entonces lo consideraremos = 0
            if (diferencia >= (-1/(digDeadzone*10)) && diferencia <= (1 / (digDeadzone * 10)))
            {
                //Si la variable diferencia es = 0, entonces regresamos nuestro valor de x como resultado del metodo
                return iniValue;
            }

            //Si la diferencia es diferente a 0, entonces seguiremos iterando hasta encontrar una raiz.
            else
            {

                //Si el metodo no converge rapidamente, entonces establecemos un limite de 5000 iteraciones, si despues de 5000 no encuentra un resultado, el programa asume que la ecuacion no converge.
                if (iter >= 5000)
                {
                    throw new StackOverflowException();
                }

                //Si seguimos iterando:
                else
                {
                    //Se calcula nuestro nuevo valor de x
                    double nextValue = iniValue - diferencia;

                    //Volvemos a llamar el metodo de newtonRaphson con los mismos coeficientes pero con un nuevo valor de x inicial y aumentamos el contador de iteraciones.
                    //Este metodo se llama a si mismo, esto es lo que llamamos recursividad.
                    return newtRaph(coeffs, nextValue, iter +1);
                }
                
            }
            

        }//Fin de newtRaph


        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/
        
        public pNewthonRaphson()
        {
            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pNewthonRaphson

        private void init()
        {
            lFeedback.Text = "";
            rtbResults.Text = "";
        }//Fin de init
        
        private void lExit_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null) { Application.Exit(); }
        }//Fin de lExit_Click
        private void lMinimize_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null) { this.WindowState = FormWindowState.Minimized; }
        }//Fin de lMinimize_Click
        
        private void pNavbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isFormBeingDragged = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }//Fin de pNavbar_MouseDown
        private void pNavbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { isFormBeingDragged = false; }
        }//Fin de pNavbar_MouseUp
        private void pNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormBeingDragged)
            {
                Point tmp = new Point();
                tmp.X = this.Location.X + (e.X - mouseX);
                tmp.Y = this.Location.Y + (e.Y - mouseY);
                this.Location = tmp;
            }
        }//Fin de pNavbar_MouseMove

        /*------------------------------------------------------*/
        /*LLAMADAS DE INFERFAZ (BOTONES | LABELS | CAMPOS | ETC)*/
        /*------------------------------------------------------*/

        /* Nombre: bCalcRaph_Click
         * Descripción: Manda los valores de entrada el newton Raphson y regresa los valores de salida al usuario.
         * 
         * Fecha de Creación: 28/04/2016
         * Autor Original: Ricardo Trevizo
         * 
         * Última Fecha de Modificación: 28/04/2016
         * Autor Última Moficiación: Ricardo Trevizo
         * 
         * Programas que Llama: newtRaph
         * Programas que lo Llaman: Ninguno
         * 
         * Este metodo hace uso de la recursividad para calcular un resultado.
        */
        private void bCalcRaph_Click(object sender, EventArgs e)
        {
            rtbResults.Text = "";
            lFeedback.Text = "";

            try
            {
                if (tbXValue.Text.Equals("")) { tbXValue.Text = "1"; }
                double xValue = Double.Parse(tbXValue.Text);
                TextBox[] textBoxes = new TextBox[] { tbX5, tbX4, tbX3, tbX2, tbX, tbInd };
                double[] inputs = new double[6];

                //Guardar los inputs en un array, convirtiéndolos a double en el proceso
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (textBoxes[i].Text.Equals("")) { textBoxes[i].Text = "0"; }
                    inputs[i] = Double.Parse(textBoxes[i].Text);
                }

                //calculamos y redondeamos la raiz a 10 digitos
                double raiz = newtRaph(inputs, xValue, 0);
                raiz = Math.Round(raiz, 10);

                //mandamos llamar a horner para tener las derivadas a la mano y validar si existen raices multiples
                double[] hornerData = pHorner.instance.horner(inputs, raiz);

                rtbResults.Text = "Se utilizó la operación: " + tbX5.Text + "x^5 + " + tbX4.Text + "x^4 + " + tbX3.Text + "x^3 + " + tbX2.Text + "x^2 + " + tbX.Text + "x + " + tbInd.Text + " = 0" +
                "\nEvaluada con: x = " + xValue.ToString() +
                "\n\nObteniendo como resultado:" +
                "\nRaiz en x = " + raiz.ToString();

                
                if (hornerData[4] == 0 && hornerData[3] < 0)
                {
                    //Máximo en (xValue, función no derivada evaluada)
                    rtbResults.Text += "\n\nLo que indica un punto MÁXIMO en: (" + raiz + "," + hornerData[5] + ")";
                    rtbResults.Text += "\nPor lo cual, significa que es una raíz múltiple (2 veces)";

                }
                else if (hornerData[4] == 0 && hornerData[3] > 0)
                {
                    //Mínimo en (xValue, función no derivada evaluada)
                    rtbResults.Text += "\n\nLo que indica un punto MÍNIMO en: (" + raiz + "," + hornerData[5] + ")";
                    rtbResults.Text += "\nPor lo cual, significa que es una raíz múltiple (2 veces)";

                }
                else if (hornerData[4] == 0 && hornerData[3] == 0)
                {
                    ///Constante
                    rtbResults.Text += "\n\nLo que indica que trata de un PUNTO DE INFLEXION.";
                    rtbResults.Text += "\nPor lo cual, significa que es una raíz múltiple (3 o mas)";
                }

            }
            catch (StackOverflowException)
            {
                lFeedback.Text = "El programa se ha quedado sin memoria, es posible que esta ecuación no converja con este método";
            }
            catch (Exception exception)
            {
                lFeedback.Text = "Ha ocurrido un error, hay campos o inválidos.\nAsegúrese que todos los campos contengan valores numéricos. (Los decimales son válidos)";
            }
           
        }//Fin de bCalcRaph_Click  
        private void lBack_Click(object sender, EventArgs e)
        {
            fMain.instance.Show();
            this.Hide();
        }//Fin de lBack_Click
        private void bCleanCells_Click(object sender, EventArgs e)
        {
            lFeedback.Text = "";
            tbInd.Text = "";
            tbX.Text = "";
            tbX2.Text = "";
            tbX3.Text = "";
            tbX4.Text = "";
            tbX5.Text = "";
            tbXValue.Text = "";
            rtbResults.Text = "";
        }//Fin de bCleanCells_Click
    }
}
