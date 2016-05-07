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
    public partial class pHorner : Form
    {

        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pHorner instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;

        /*--------------------------------*/
        /*FUNCIONES OPERACIONALES (HORNER)*/
        /*--------------------------------*/

        /* Nombre: horner
         * Descripción: Realiza el método de horner, regresando en forma de array los valores (sin multiplicar por factorial) de las derivadas evaluadas.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 24/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcHorner_Click | newtRaph | multivariable
        */
        public double[] horner(double[] inputs, double value)
        {
            int arraySize = inputs.Length;

            double[] tmpInputs = new double[arraySize];
            for (int x = 0; x < inputs.Length; x++)
            {
                tmpInputs[x] = inputs[x];
            }

            //El residuo es el valor que va a ser cargado a lo largo de la división sintética
            double residium = 0;

            //Ej: En este caso el array es siempre de 6 máx. Por lo que va a ir desde 6 hasta detenerse en 1.
            for (; arraySize >= 1 ; arraySize--)
            {
                /* Por el for de arriba, las iteraciones aqui siempre serán de 0 al número de arriba.
                 * Esto deja intacto el último valor de la iteración pasada, osea que guarda todas las derivadas evaluadas
                 * Siguiendo el ejemplo de arriba, iría de 0 a 5, luego 0 a 4, hasta 0 a 1.
                 * Siendo la primera posición el*/
                for (int pos = 0; pos < arraySize; pos++)
                {
                    residium += tmpInputs[pos];// Agregar al residuo pasado el valor de la posición actual
                    tmpInputs[pos] = residium;// Una vez sumado el valor de la celda con el residuo anterior, nos da el nuevo valor de la celda.
                    residium *= value;//Multiplicar el resultado de la suma del valor de la celda y el residuo por el valor deseado de x.
                }
                residium = 0;
            }
            return tmpInputs;

        }//Fin de horner

        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/

        public pHorner()
        {
            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pHorner
        
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
        
        /* Nombre: pNavbar_MouseDown | pNavbar_Up | pNavbar_Move | lBack_Click
         * Descripción: Estos controles son para permitir mover la aplicación de lugar.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 24/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: Ninguno
        */
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
        private void lBack_Click(object sender, EventArgs e)
        {
            fMain.instance.Show();
            this.Hide();
        }//Fin de lBack_Click

        /*------------------------------------------------------*/
        /*LLAMADAS DE INFERFAZ (BOTONES | LABELS | CAMPOS | ETC)*/
        /*------------------------------------------------------*/

        /* Nombre: bCalcHorner_Click
         * Descripción: Realiza el llamado para realizar la operación de Horner.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 25/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: horner
         * Programas que lo Llaman: Ninguno
        */
        private void bCalcHorner_Click(object sender, EventArgs e)
        {
            rtbResults.Text = "";
            lFeedback.Text = "";
                        
            try
            {
                if (tbXValue.Text.Equals("")) { tbXValue.Text = "0"; }
                double xValue = Double.Parse(tbXValue.Text);
                TextBox[] textBoxes = new TextBox[] { tbX5, tbX4, tbX3, tbX2, tbX, tbInd };
                double[] inputs = new double[6];

                //Guardar los inputs en un array, convirtiéndolos a double en el proceso
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    if (textBoxes[i].Text.Equals("")) { textBoxes[i].Text = "0"; }
                    inputs[i] = Double.Parse(textBoxes[i].Text);
                }

                inputs = horner(inputs,xValue);

                rtbResults.Text = "Se utilizó la operación: " + tbX5.Text + "x^5 + " + tbX4.Text + "x^4 + " + tbX3.Text + "x^3 + " + tbX2.Text + "x^2 + " + tbX.Text + "x + " + tbInd.Text + " = 0"+
                "\nEvaluada con: x = " + xValue.ToString() +
                "\n\nObteniendo como resultados:" +
                "\nf   (" + xValue.ToString() + ") = " + inputs[5].ToString() +
                "\nf'  (" + xValue.ToString() + ") = " + inputs[4].ToString() +
                "\nf'' (" + xValue.ToString() + ") = " + (inputs[3]*2).ToString();

                if (inputs[4] == 0 && inputs[3] < 0)
                {
                    //Máximo en (xValue, función no derivada evaluada)
                    rtbResults.Text += "\n\nLo que indica un punto MÁXIMO en: (" + xValue+ "," + inputs[5] + ")";
                }
                else if (inputs[4] == 0 && inputs[3] > 0)
                {
                    //Mínimo en (xValue, función no derivada evaluada)
                    rtbResults.Text += "\n\nLo que indica un punto MÍNIMO en: (" + xValue + "," + inputs[5] + ")";
                }
                else if (inputs[4] == 0 && inputs[3] == 0)
                {
                    ///Constante
                    rtbResults.Text += "\n\nLo que indica que se calculó una constante.";
                }
            }

            catch (Exception exception)
            {
                lFeedback.Text = "Ha ocurrido un error. Operación no válida por datos inválidos. \nAsegúrese que todos los campos contengan valores numéricos. (Los decimales son válidos)";
            }
        }//Fin de bCalcHorner_Click

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
