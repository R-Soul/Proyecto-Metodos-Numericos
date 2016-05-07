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
    public partial class pCurveAdjustment : Form
    {
        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pCurveAdjustment instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;

        /*-----------------------------------------*/
        /*FUNCIONES OPERACIONALES (AJUSTE DE CURVA)*/
        /*-----------------------------------------*/

        /* Nombre: polynomialRegression
         * Descripción: Calcula una función polinomial para ajustarse a una serie de puntos
         * (regresión polinomial) con el método de mínimos cuadrados.
         * La precisión del polinomio con relación a los puntos se define por el grado del polinomio.
         * 
         * Los parametros indican que se debe especificar un arreglo con los puntos "x, y".
         * y el valor del grado de polinomio a calcular: si es 1 es lineal, 2 es cuadrado, etc.
         * 
         * Fecha de creación 29/04/2016
         * 
         * Autor original: Jonathan Sotelo
         * 
         * Última fecha de modificación: 1/05/2016
         * Autor última modificación: Jonathan Sotelo
         * 
         * Programas que llama: pInverseMatrix.invMatrix()
         * Programas que lo Llaman: Ninguno
         */
        private void polynomialRegression(double[,] points, int degree)
        {

            /* Declaración de variables */
            int n = points.GetUpperBound(1) + 1;            // Número de puntos "n".
            double x_m = 0;                                 // Variables para almacenar el promedio de los valores de puntos
            double y_m = 0;
            double[] diffSquare = new double[n];            // Arreglo que almacena los valores de (y_i - y_m)^2.
            double sumDiffSquare = 0;                       // Variable que almacena el valor de suma de (y_i - y_m)^2.
            double[,] x_values = new double[n, degree * 2]; // Arreglo de dos dimensiones que almacena las potencias de valores de "x".
            double[] x_totals = new double[degree * 2];     // Arreglo que almacena la suma de los valores "y".
            double y_total = 0;                             // Variable que que almacena las sumas de los valores de "y".
            double[,] xy_values = new double[n, degree];    // Arreglo que almacena potencias de valores de "x" multiplicado por "y".
            double[] xy_totals = new double[degree];        // Arreglo que almacena las sumas de las potencias de x multiplicado por "y".
            double[,] eqResult = new double[degree + 1, 1]; // Arreglo que almacena los coeficientes de la funcion polinomial (resultado).
            double correlationR = 0;                        // Variable que almacena el valor de correlación "r^2" (resultado).

            //Matriz para almacenar valores de coeficientes de la ecuacion a resolver más adelante.
            double[,] coefficientsMatrix = new double[degree + 1, degree + 1];
            //Arreglo para almacenar términos independientes.
            double[,] independentTerms = new double[degree + 1, 1];

            /* Obtener promedios de los puntos. */
            // Suma
            for (int i = 0; i <= points.GetUpperBound(1); i++)
            {
                x_m += points[0, i];
                y_m += points[1, i];
            }

            y_total = y_m; // Almacenar la suma ya realizada de valores de "y"

            // Division (calcular el promedio)
            x_m = x_m / n;
            y_m = y_m / n;


            /* Obtener los valores de (y_i - y_m)^2 y la suma */
            for (int i = 0; i <= points.GetUpperBound(1); i++)
            {
                diffSquare[i] = Math.Pow(points[1, i] - y_m, 2); // Diferencia y cuadrado de cada punto
                sumDiffSquare += diffSquare[i];                  // Sumar
            }

            // Obtener las potencias de x.
            for (int i = 0; i <= points.GetUpperBound(1); i++)
            {
                double x = points[0, i];
                double y = points[1, i];
                int power = 1; // iniciando con potencia de 1 de "x"
                for (int j = 0; j <= x_values.GetUpperBound(1); j++)
                {
                    x_values[i, j] = Math.Pow(x, power);
                    power++; // aumentar el valor de potencia más 1
                }
            }

            // Suma de los valores de x y sus potencias.
            for (int i = 0; i <= x_values.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= x_values.GetUpperBound(0); j++)
                {
                    x_totals[i] += x_values[j, i];
                }
            }

            /* Obtener y resolver ecuación */
            coefficientsMatrix[0, 0] = n; // El primer elemento de la matriz es igual al número de puntos

            int a = -1; // Variables auxiliares para ordenamiento de elementos en diagonal
            int b = 0;
            for (int i = 0; i <= degree; i++)
            {
                for (int j = 0; j <= degree; j++)
                {
                    if (i == 0 && j == 0) { a++; continue; } // Omitir el primer elemento, que ya fue asignado
                    coefficientsMatrix[i, j] = x_totals[a];  // Asignar valores a la matriz de coeficientes
                    a++;
                }
                a = b;
                b++;
            }

            // Obtener los valores de multiplicar los valores de "x" con sus potencias por "y" (xy,  x^2 * y, x^3 * y, etc.).
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < degree; j++)
                {
                    xy_values[i, j] = x_values[i, j] * points[1, i];
                }
            }

            // Suma de los valores de "x" con potencias multiplicado por "y"
            for (int i = 0; i < degree; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    xy_totals[i] += xy_values[j, i];
                }
            }

            // Obtener los términos independientes del sistema de ecuaciones.
            independentTerms[0, 0] = y_total;
            for (int i = 1; i <= independentTerms.GetUpperBound(0); i++)
            {
                independentTerms[i, 0] = xy_totals[i - 1];
            }

            // Resolver el sistema usando el procedimiento de matriz inversa.
            eqResult = pInverseMatrix.instance.invMatrix(new MMatrix(coefficientsMatrix), new MMatrix(independentTerms)).Matrix;

            /* Calcular el valor de correlación "r^2" */
            double c = 0; // variable auxiliar, contiene la suma de (y_i - P(x))^2
            for (int i = 0; i <= points.GetUpperBound(1); i++)
            {
                double d = 0;
                for (int j = 0; j <= eqResult.GetUpperBound(0); j++)
                {
                    // a_0 ^ p * y
                    if (j == 0)
                    {
                        d += eqResult[j, 0];
                    }
                    else
                    {
                        d += Math.Pow(points[0, i], j) * eqResult[j, 0];
                    }
                }

                c += Math.Pow(d - points[1, i], 2);

            }

            correlationR = (sumDiffSquare - c) / sumDiffSquare;

            /* Mostrar resultados */

            // Mostrar una pequeña tabla de coeficientes con precisión númerica.
            mvResult.Data = new MMatrix(eqResult);

            rtbResults.Text = "Se han utilizado los puntos seleccionados en la tabla de arriba.\nDichos puntos dan como resultado a la función:\n\n";

            // Lógica detrás para mostrar el polinomio
            string polynomial = string.Empty;

            for (int i = eqResult.GetUpperBound(0); i > 0; i--)
            {
                if (eqResult[i, 0] == 0) continue;
                polynomial += polynomial == string.Empty ? "(" : " + (";
                polynomial += eqResult[i, 0].ToString("N4") + " * x";
                polynomial += (i == 1) ? ")" : " ^ " + i + ")";
            }

            if (eqResult[0, 0] > 0)
            {
                polynomial += " + " + eqResult[0, 0].ToString("N4");
            }
            else if (eqResult[0, 0] < 0)
            {
                polynomial += " - " + Math.Abs(eqResult[0, 0]).ToString("N4");
            }
            rtbResults.Text += "f(x) = " + polynomial;

            // Mostrar el valor de correlación "r^2"
            rtbResults.Text += "\nR^2 = " + correlationR;
        }//Fin de polynomialRegression

        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/

        public pCurveAdjustment()
        {

            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pCurveAdjustment
        
        private void init()
        {
            lFeedback.Text = "";

            cbPoints.Text = "6";
            cbDegree.Text = "3";

            mvPoints.Data = new MMatrix(2, 6);
            mvResult.Data = new MMatrix(4, 1);
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

        /* Nombre: bCalcOperation_Click
         * Descripción: Valida los datos de entrada y hace la llamada a
         * calcular la operación de ajuste de curvas.
         * 
         * Fecha de creación: 30/4/2016
         * Autor original: Jonathan Sotelo
         * 
         * Última fecha de modificación: 1/5/2016
         * Autor última moficiación: Jonathan Sotelo
         * 
         * Programas que Llama: polynomialRegression()
         * Programas que lo Llaman: Ninguno
         */
        private void bCalcOperation_Click(object sender, EventArgs e)
        {
            int degree = 0;

            if (!Int32.TryParse(cbDegree.Text, out degree))
            {
                lFeedback.Text = "Seleccione un valor de grado de polinomio.";
                return;
            }

            double[,] points = mvPoints.Data.Matrix;

            if (!(degree < points.GetUpperBound(1) + 1))
            {
                lFeedback.Text = "El grado de polinomio tiene que ser menor al número de puntos." +
                    "\nIntente aumentar el número de puntos o disminuya el grado de polinomio.";
                return;
            }

            lFeedback.Text = "";
            try
            {
                polynomialRegression(points, degree);
            }
            catch (Exception ex)
            {
                lFeedback.Text = "Hubo un error al procesar la información, revise sus valores de entrada.";
            }
            /*lFeedback.Text = "";
            polynomialRegression();*/
        }//Fin de bCalcOperation_Click
        
        private void cbPoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nPoints = Int32.Parse(cbPoints.Text);
            mvPoints.Data = new MMatrix(2, nPoints);
        }//Fin de cbPoints_SelectedIndexChanged
    }
}

