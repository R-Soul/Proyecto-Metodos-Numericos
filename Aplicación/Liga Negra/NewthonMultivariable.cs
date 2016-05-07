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
    public partial class pNewthonMultivariable : Form
    {
        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pNewthonMultivariable instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;


        /*-----------------------------------------------*/
        /*FUNCIONES OPERACIONALES (NEWTHON MULTIVARIABLE)*/
        /*-----------------------------------------------*/

        /* Nombre: multivariable()
         * Descripción: Obtiene un valor de X como intersección de ambas funciones, devolviendo "falso" de no convergir.
         * 
         * Fecha de Creación: 28/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 30/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: horner | inverse | multiply
         * Programas que lo Llaman: bCalcNewthonM_Click()*/
        public bool multivariable(double xValue, double[]inputsFirst, double[] inputsSecond, out double xResult)
        {
            double ERRORTRESHOLD = 0.000001;//Para saber cuando parar si converge
            int ITERATIONTRESHOLD = 300;//Si para este número de iteraciones no hay un resultado fijo, se determina que la ecuación no converge.

            int inputsSize = inputsFirst.Length;

            double tmpX = xValue;
            double tmpY = pHorner.instance.horner(inputsFirst, tmpX)[inputsSize-2];
            xResult = tmpX;

            double[,] jacobian = new double[,] { { 0, -1 }, { 0, -1 } }; //Esta función no debe contener y, por lo cual su valor al despejar siempre va a ser -1, los -1 no se van a tocar0
            double[,] function = new double[,] { {0}, {0}};//Esto guarda las funciones evaluadas en los actuales valores de x.
            double[,] inverse = new double[,] { { 0 }, { 0 } };
            double[,] delta = new double[,] { { 0 }, { 0 } };

            double error = 1;

            while (error > ERRORTRESHOLD)
            {
                if (ITERATIONTRESHOLD <= 0){ xResult = tmpX; return false; }//Aún si no converge, se devuelve el dato cercano al que se llegó

                //Calculat la matriz jacobiana, donde la penúltima posición del array que se recibe es la primera derivada que buscamos.
                jacobian[0, 0] = pHorner.instance.horner(inputsFirst, tmpX)[inputsSize -2];
                jacobian[1, 0] = pHorner.instance.horner(inputsSecond, tmpX)[inputsSize -2];

                //Ahora se obtienen las funciones evaluadas en el actual valor de x.
                function[0, 0] = pHorner.instance.horner(inputsFirst, tmpX)[inputsSize-1] - tmpY;
                function[1, 0] = pHorner.instance.horner(inputsSecond, tmpX)[inputsSize-1] - tmpY;

                inverse = pMatrixOperations.instance.inverse(new MMatrix(jacobian));
                delta = pMatrixOperations.instance.multiply(new MMatrix (inverse),new MMatrix(function));

                tmpX -= delta[0, 0];
                tmpY -= delta[1, 0];

                //Calcular el error
                error = Math.Sqrt(Math.Pow(delta[0, 0], 2) + Math.Pow(delta[1, 0], 2));

                ITERATIONTRESHOLD--;
            }
            xResult = tmpX; 
            return true;
            
        }//multivariable


        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/

        public pNewthonMultivariable()
        {
            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pNewthonMultivariable

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

        private void lBack_Click(object sender, EventArgs e)
        {
            fMain.instance.Show();
            this.Hide();
        }//Fin de lBack_Click


        /*------------------------------------------------------*/
        /*LLAMADAS DE INFERFAZ (BOTONES | LABELS | CAMPOS | ETC)*/
        /*------------------------------------------------------*/

        /* Nombre: bCalcNewthonM_Click
         * Descripción: Obtiene el valor de x que representa el punto de corte de las dos ecuaciones dadas.
         * 
         * Fecha de Creación: 28/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 28/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: multivariable
         * Programas que lo Llaman: Ninguno*/
        private void bCalcNewthonM_Click(object sender, EventArgs e)
        {
            rtbResults.Text = "";
            lFeedback.Text = "";

            double resultX = 0;

            try
            {
                if (tbXValue.Text.Equals("")) { tbXValue.Text = "0"; }
                double xValue = Double.Parse(tbXValue.Text);
                TextBox[] textBoxesFirst = new TextBox[] { tbX5, tbX4, tbX3, tbX2, tbX, tbInd };
                TextBox[] textBoxesSecond = new TextBox[] { tbX52, tbX42, tbX32, tbX22, tbX12, tbInd2 };
                double[] inputsFirst = new double[6];
                double[] inputsSecond = new double[6];

                //Guardar los inputs en un array, convirtiéndolos a double en el proceso
                for (int i = 0; i < textBoxesFirst.Length; i++)
                {
                    if (textBoxesFirst[i].Text.Equals("")) { textBoxesFirst[i].Text = "0"; }
                    inputsFirst[i] = Double.Parse(textBoxesFirst[i].Text);

                    if (textBoxesSecond[i].Text.Equals("")) { textBoxesSecond[i].Text = "0"; }
                    inputsSecond[i] = Double.Parse(textBoxesSecond[i].Text);
                }


                if (multivariable(xValue, inputsFirst, inputsSecond, out resultX))
                {
                    rtbResults.Text = "Se utilizaron las  la operaciónes: " + tbX5.Text + "x^5 + " + tbX4.Text + "x^4 + " + tbX3.Text + "x^3 + " + tbX2.Text + "x^2 + " + tbX.Text + "x + " + tbInd.Text + " = 0" +
                    "\nY: " + tbX52.Text + "x^5 + " + tbX42.Text + "x^4 + " + tbX32.Text + "x^3 + " + tbX22.Text + "x^2 + " + tbX2.Text + "x + " + tbInd2.Text + " = 0" +
                    "\nUtilizando el valor de inicio: x = " + xValue.ToString() +
                    "\n\nObteniendo como intersección: x = " + resultX +
                    "\nDonde la función evaluada de ambas da: "+ pHorner.instance.horner(inputsFirst, resultX)[inputsFirst.Length - 1];
                }
                else
                {
                    rtbResults.Text = "La combinación presentada de funciones y valor inicial resultaron en un problema que no converge." +
                    "\nSe utilizaron las  la operaciónes: " + tbX5.Text + "x^5 + " + tbX4.Text + "x^4 + " + tbX3.Text + "x^3 + " + tbX2.Text + "x^2 + " + tbX.Text + "x + " + tbInd.Text + " = 0" +
                    "\nY: " + tbX52.Text + "x^5 + " + tbX42.Text + "x^4 + " + tbX32.Text + "x^3 + " + tbX22.Text + "x^2 + " + tbX2.Text + "x + " + tbInd2.Text + " = 0" +
                    "\nUtilizando el valor de inicio: x = " + xValue.ToString() +
                    "\n\nDando una intersección APROXIMADA en: x = " + resultX + " (Recordadndo que esta función no convergió)";
                }
            }

            catch (Exception exception)
            {
                lFeedback.Text = "Ha ocurrido un error. Operación no válida por datos inválidos. \nAsegúrese que todos los campos contengan valores numéricos. (Los decimales son válidos)";
            }
        }//Fin de bCalcNewthonM_Click
        private void bCleanCells_Click(object sender, EventArgs e)
        {
            lFeedback.Text = "";
            tbInd.Text = "";
            tbX.Text = "";
            tbX2.Text = "";
            tbX3.Text = "";
            tbX4.Text = "";
            tbX5.Text = "";
            tbInd2.Text = "";
            tbX12.Text = "";
            tbX22.Text = "";
            tbX32.Text = "";
            tbX42.Text = "";
            tbX52.Text = "";
            tbXValue.Text = "";
            rtbResults.Text = "";
        }//Fin debCleanCells_Click
    }
}
