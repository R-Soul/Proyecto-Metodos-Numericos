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
    public partial class pMatrixOperations : Form
    {
        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pMatrixOperations instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;
        private int rowsA, colsA, rowsB, colsB;

        //Identificadores de las opciones
        public enum SelectedMatrix : int
        {
            A = 0,
            B,
            AB
        }

        public enum Operations1 : int
        {
            Determinante = 0,
            Inversa,
            SoloEscalar,
            Transpuesta,
        }
        public enum Operations2 : int
        {
            MultiplicaciónAB = 0,
            MultiplicaciónBA,
            RestaAB,
            RestaBA,
            Suma
        }

        /*--------------------------------------------------*/
        /*FUNCIONES OPERACIONALES (OPERACIONES CON MATRICES)*/
        /*--------------------------------------------------*/

        /* Nombre: scalar
         * Descripción: Regresa una matriz aumentada a un valor escalar.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 24/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcOperation_Click | inverse */
        public double[,] scalar(MMatrix matrix, double scalarValue)
        {
            double[,] tmpMatrix = matrix.Matrix;

            //Por cada fila
            for (int row = 0; row < matrix.Matrix.GetLength(0); row++)
            {
                //Por cada Columna
                for (int col = 0; col < matrix.Matrix.GetLength(1); col++)
                {
                    tmpMatrix[row, col] *= scalarValue;
                }
            }

            return tmpMatrix;
        }//Fin de scalar

        /* Nombre: sum
         * Descripción: Regresa la suma de dos matrices.
         * 
         * Fecha de Creación: 26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcOperation_Click
        */
        public double[,] sum(MMatrix matrixA, MMatrix matrixB)
        {
            double[,] tmpMatrix = matrixA.Matrix;

            //Por cada fila
            for (int row = 0; row < matrixA.Matrix.GetLength(0); row++)
            {
                //Por cada Columna
                for (int col = 0; col < matrixA.Matrix.GetLength(1); col++)
                {
                    tmpMatrix[row, col] += matrixB.Matrix[row, col];
                }
            }

            return tmpMatrix;
        }//Fin de sum

        /* Nombre: substract
         * Descripción: Regresa la resta de la matriz A menos la B.
         * 
         * Fecha de Creación:26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcOperation_Click
        */
        public double[,] substract(MMatrix matrixA, MMatrix matrixB)
        {
            double[,] tmpMatrix = matrixA.Matrix;

            //Por cada fila
            for (int row = 0; row < matrixA.Matrix.GetLength(0); row++)
            {
                //Por cada Columna
                for (int col = 0; col < matrixA.Matrix.GetLength(1); col++)
                {
                    tmpMatrix[row, col] -= matrixB.Matrix[row, col];
                }
            }

            return tmpMatrix;
        }//Fin de substract

        /* Nombre: multiply
         * Descripción: Regresa el producto punto de la matriz A por la B.
         * 
         * Fecha de Creación: 26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcOperation_Click | invMatrix | multivariable
        */
        public double[,] multiply(MMatrix matrixA, MMatrix matrixB)
        {
            double[,] tmpMatrix = new double[matrixA.Matrix.GetLength(0), matrixB.Matrix.GetLength(1)];
            double tmpAns = 0;

            //Por cada fila de la matriz resultante
            for (int row = 0; row < tmpMatrix.GetLength(0); row++)
            {
                //Por cada Columna de la matriz resultante
                for (int col = 0; col < tmpMatrix.GetLength(1); col++)
                {
                    //Esto itera a lo largo de una fila de A, por lo tanto de una columna de B, ya que tienen el mismo numero de elementos.
                    for (int colArowA = 0; colArowA < matrixA.Matrix.GetLength(1); colArowA++)
                    {
                        tmpAns += matrixA.Matrix[row, colArowA] * matrixB.Matrix[colArowA, col];
                    }
                    tmpMatrix[row, col] = tmpAns;
                    tmpAns = 0;
                }
            }

            return tmpMatrix;
        }//Fin de multiply

        /* Nombre: transposed
         * Descripción: Regresa la matriz transpuesta.
         * 
         * Fecha de Creación: 26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: bCalcOperation_Click | inverse*/
        public double[,] transposed(MMatrix matrix)
        {
            double[,] tmpMatrix = new double[matrix.Matrix.GetLength(1), matrix.Matrix.GetLength(0)];

            //Por cada fila
            for (int row = 0; row < tmpMatrix.GetLength(0); row++)
            {
                //Por cada Columna
                for (int col = 0; col < tmpMatrix.GetLength(1); col++)
                {
                    tmpMatrix[row, col] = matrix.Matrix[col, row];
                }
            }


            return tmpMatrix;
        }//Fin de transposed

        /* Nombre: inverse
         * Descripción: Regresa la inversa de la matriz seleccionada.
         * 
         * Fecha de Creación: 26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: determinant | scalar | transposed
         * Programas que lo Llaman: bCalcOperation_Click | invMatrix| multivariable*/
        public double[,] inverse(MMatrix matrix)
        {

            double det;
            double[,] tmpMat = (double[,])matrix.Matrix.Clone();

            if ((det = determinant(tmpMat)) == 0) { return new MMatrix(tmpMat).Matrix; }//No hay inversa si no hay determinante.

            int matSize = tmpMat.GetLength(0);

            double[,] tmpDetMat = new double[matSize - 1, matSize - 1];//Matriz para almacenar submatrices
            double[,] nMatrix = new double[matSize, matSize];//Matriz de determinantes
            int colIgnored = 0;
            int rowIgnored = 0;
            //Calcular la matriz n, elaborada a base de determinantes de submatrices
            for (int rowN = 0; rowN < matSize; rowN++)
            {
                for (int colN = 0; colN < matSize; colN++)
                {
                    //[rowN,colN] nos permitirá recorrer cada casilla de nMatrix, para ir calculando los determinantes de sus submatrices
                    //Ahora, por cada celda, se recorrerá toda la matriz con los datos, sacando la submatriz que no toca ni su columna o fila
                    for (int row = 0; row < matSize; row++)
                    {
                        if (row == rowN)
                        {
                            rowIgnored = -1;
                        }
                        else
                        {
                            for (int col = 0; col < matSize; col++)
                            {

                                if (colN == col)
                                {
                                    colIgnored = -1;
                                }
                                else
                                {
                                    tmpDetMat[row + rowIgnored, col + colIgnored] = tmpMat[row, col];
                                }
                            }
                            colIgnored = 0;
                        }
                    }
                    rowIgnored = 0;
                    nMatrix[rowN, colN] = determinant(tmpDetMat);
                }
            }

            //Alternar signos desde la esquina superior izquierda, hasta la inferior derecha, empezando con +.
            int sign = -1;
            if (matSize % 2 == 0) { sign = 1; }
            for (int row = 0; row < matSize; row++)
            {
                if (matSize % 2 == 0)
                {
                    sign *= -1;
                }

                for (int col = 0; col < matSize; col++)
                {
                    nMatrix[row, col] *= (sign *= -1);
                }
            }

            nMatrix = transposed(new MMatrix(nMatrix));

            nMatrix = scalar(new MMatrix(nMatrix), (1 / det));

            return nMatrix;
        }//Fin de inverse

        /* Nombre: determinant
         * Descripción: Regresa la determinante de la matriz cuadrada seleccionada, utilizando recursividad.
         * Esto se hace sabiendo que una matriz de 2x2 tiene un determinante elaborado a través de la resta de sus diagonales.
         * 
         * Fecha de Creación: 26/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 29/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: determinant
         * Programas que lo Llaman: bCalcOperation_Click | inverse*/
        public double determinant(double[,] matrix)
        {
            
            double sum = 0;
            int sign;

            if (matrix.GetUpperBound(0) == 0)
            {
                //Al momento de llegar al tamaño mínimo posible para uns submatriz (que van disminuyendo de magnitud), se la siguiente submatriz es si misma.
                return matrix[0, 0];
            }

            for (int diag = 0; diag <= (matrix.GetLength(0) - 1); diag++)
            {
                
                double[,] smaller = new double[(matrix.GetLength(0) - 1), (matrix.GetLength(1) - 1)];

                //Se crea una sub matriz que tiene los datos que NO están en la fila o columna de la celda en cuestión.
                for (int row = 1; row <= (matrix.GetLength(0) - 1); row++)
                {
                    for (int col = 0; col <= (matrix.GetLength(1) - 1); col++)
                    {
                        if (col < diag)
                        {
                            smaller[row - 1, col] = matrix[row, col];
                        }
                        else if (col > diag)
                        {
                            smaller[row - 1, col - 1] = matrix[row, col];
                        }
                    }
                }

                //Esto le permite saber a cada iteración cual signo deben utilizar para agregar o restar al total.
                if (diag % 2 == 0) { sign = 1; }
                else{sign = -1;}

                //Inicio de recursión, para sacar el total de una submatriz grande, se obtiene el resultado de sus submatrices más pequeñas primero.
                sum += sign * matrix[0, diag] * (determinant(smaller));
            }
            return (sum); //Regresa el determinante de la matriz o submatriz que se está analizando.
        }//Fin de determinant

        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/

        public pMatrixOperations()
        {
            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pMatrixOperations
        
        private void init()
        {
            lFeedback.Text = "";
            mvMatrixB.Data = new MMatrix(1, 1);
            mvMatrixA.Data = new MMatrix(1, 1);
            mvResult.Data = new MMatrix(1, 1);//Si no tiene al menos una columna, va a fallar;
            mvResult.Hide();
            rtbResults.Text = "";
            cbMatrixToUse.SelectedIndex = 0;
            cbColumnsA.SelectedIndex = 0;
            cbColumnsB.SelectedIndex = 0;
            cbRowsA.SelectedIndex = 0;
            cbRowsB.SelectedIndex = 0;
            cbOperation1.SelectedIndex = 0;
            cbOperation2.SelectedIndex = 0;
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
         * Descripción: Realiza la operación seleccionada acorde a la cantidad de matrices disponibles.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 26/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: scalar | sum | substract | multiply | transposed | inverse | determinant*/
        private void bCalcOperation_Click(object sender, EventArgs e)
        {
            lFeedback.Text = "";
            rtbResults.Text = "";
            mvResult.Hide();
            if (tbScalarA.Text.Equals("")) { tbScalarA.Text = "1"; }
            if (tbScalarB.Text.Equals("")) { tbScalarB.Text = "1"; }
            
            double det = 0;
            try
            {

                MMatrix tmpR = new MMatrix(1, 1);//Debe tener al menos una columna al momento de sobreescribirla
                MMatrix tmpA = new MMatrix(scalar(mvMatrixA.Data, double.Parse(tbScalarA.Text)));
                MMatrix tmpB = new MMatrix(scalar(mvMatrixB.Data, double.Parse(tbScalarB.Text)));

                if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A || cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.B)
                {
                    switch (cbOperation1.SelectedIndex)
                    {
                        case (int)Operations1.Determinante:
                            if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A)
                            {
                                if (rowsA != colsA) { throw new NotSquareException(); }
                                tmpR = tmpA;
                                if ((det = determinant(tmpA.Matrix)) != 0)
                                {
                                    rtbResults.Text = "Se obtuvo el determinante de la matriz A.\nTiene un valor de " + det;
                                }
                                else
                                {
                                    rtbResults.Text = "El valor determinante de la matriz A es 0.\nHay demasiados datos iguales o cercanos a 0, lo que impide que tenga determinante.";
                                }
                            }
                            else
                            {
                                if (rowsB != colsB) { throw new NotSquareException(); }
                                tmpR = tmpB;
                                if (( det = determinant(tmpB.Matrix)) != 0)
                                {
                                    rtbResults.Text = "Se obtuvo el determinante de la matriz B.\nTiene un valor de " + det;
                                }
                                else
                                {
                                    rtbResults.Text = "El valor determinante de la matriz B es 0.\nHay demasiados datos iguales o cercanos a 0, lo que impide que tenga determinante.";
                                }
                            }
                            break;
                        case (int)Operations1.Inversa:
                            if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A)
                            {
                                if (rowsA != colsA) { throw new NotSquareException(); }
                                tmpR = new MMatrix(inverse(tmpA));
                                rtbResults.Text += "Se obtuvo la matriz inversa de A.\n\nEs la mostrada a continuación.";
                            }
                            else {
                                if (rowsB != colsB) { throw new NotSquareException(); }
                                tmpR = new MMatrix(inverse(tmpB));
                                rtbResults.Text += "Se obtuvo la matriz inversa de B.\n\nEs la mostrada a continuación.";
                            }
                            break;
                        case (int)Operations1.Transpuesta:
                            rtbResults.Text = "Se obtuvo la matriz transpuesta de ";
                            if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A) { tmpR = new MMatrix(transposed(tmpA)); rtbResults.Text += "A.\nSiendo esta una matriz de " + rowsA + "x" + colsA + ".\n\nLo que da por resultado una matriz de " + colsA + "x" + rowsA + "."; }
                            else { tmpR = new MMatrix(transposed(tmpB)); rtbResults.Text += "B.\nSiendo esta una matriz de " + rowsB + "x" + colsB + ".\n\nLo que da por resultado una matriz de " + colsB + "x" + rowsB + "."; }
                            break;
                        case (int)Operations1.SoloEscalar:
                            rtbResults.Text = "Se obtuvo la matriz con un valor escalar de: ";
                            if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A) { tmpR = tmpA; rtbResults.Text += "" + tbScalarA.Text + " de la matriz A.\n\nEs la mostrada a continuación."; }
                            else { tmpR = tmpB; rtbResults.Text += "" + tbScalarB.Text + " de la matriz B.\n\nEs la mostrada a continuación."; }
                            break;
                        default:
                            break;
                    }
                }// Fin de if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A || cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.B)
                else if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.AB)
                {
                    switch (cbOperation2.SelectedIndex)
                    {
                        case (int)Operations2.MultiplicaciónAB:
                            if (colsA != rowsB) { throw new NotSameNException(); }

                            rtbResults.Text = "Se realizó la operación: " + tbScalarA.Text + "A x " + tbScalarB.Text + "B." +
                            "\n\nDonde A es una matriz de " + rowsA + "x" + colsA + "." +
                            "\nY B una matriz de " + rowsB + "x" + colsB + "." +
                            "\n\nDando como resultado una matriz de " + rowsA + "x" + colsB + ".";

                            tmpR = new MMatrix(multiply(tmpA, tmpB));
                            break;
                        case (int)Operations2.MultiplicaciónBA:
                            if (colsB != rowsA) { throw new NotSameNException(); }

                            rtbResults.Text = "Se realizó la operación: " + tbScalarB.Text + "B x " + tbScalarA.Text + "A." +
                            "\n\nDonde A es una matriz de " + rowsA + "x" + colsA + "." +
                            "\nY B una matriz de " + rowsB + "x" + colsB + "." +
                            "\n\nDando como resultado una matriz de " + rowsB + "x" + colsA + ".";

                            tmpR = new MMatrix(multiply(tmpB, tmpA));
                            break;
                        case (int)Operations2.RestaAB:
                            if (rowsA != rowsB || colsA != colsB) { throw new NotSameSizeException(); }

                            rtbResults.Text = "Se realizó la operación: " + tbScalarA.Text + "A - " + tbScalarB.Text + "B." +
                            "\n\nDonde A es una matriz de " + rowsA + "x" + colsA + "." +
                            "\nY B una matriz de " + rowsB + "x" + colsB + "." +
                            "\n\nDando como resultado una matriz de " + rowsB + "x" + colsA + ".";

                            tmpR = new MMatrix(substract(tmpA, tmpB));
                            break;
                        case (int)Operations2.RestaBA:
                            if (rowsA != rowsB || colsA != colsB) { throw new NotSameSizeException(); }

                            rtbResults.Text = "Se realizó la operación: " + tbScalarB.Text + "B - " + tbScalarA.Text + "A."  +
                            "\n\nDonde A es una matriz de " + rowsA + "x" + colsA + "." +
                            "\nY B una matriz de " + rowsB + "x" + colsB + "." +
                            "\n\nDando como resultado una matriz de " + rowsB + "x" + colsA + ".";

                            tmpR = new MMatrix(substract(tmpB, tmpA));
                            break;
                        case (int)Operations2.Suma:
                            if (rowsA != rowsB || colsA != colsB) { throw new NotSameSizeException(); }

                            rtbResults.Text = "Se realizó la operación: " + tbScalarA.Text + "A + " + tbScalarB.Text + "B." +
                            "\n\nDonde A es una matriz de " + rowsA + "x" + colsA + "." +
                            "\nY B una matriz de " + rowsB + "x" + colsB + "." +
                            "\n\nDando como resultado una matriz de " + rowsB + "x" + colsA + ".";

                            tmpR = new MMatrix(sum(tmpA, tmpB));
                            break;
                        default:
                            break;
                    }//Fin de Switch
                }//Fin de else if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.AB)
                mvResult.Data = tmpR;
                mvResult.Show();
            }//Fin de try
            catch (NotSameSizeException nsse)
            {
                lFeedback.Text = "Ha ocurrido un error. Las matrices son de tamaños diferentes.\nPara realizar esta operacion las matrices deben tener el mismo número de filas y columnas.";
            }
            catch (NotSameNException nsne)
            {
                lFeedback.Text = "Ha ocurrido un error. Las matrices no son compatibles para multiplicación.\nPara realizar esta operación, la cantidad de columnas de la 1ra matriz debe ser igual a la cantidad de filas de la 2da.";
            }
            catch (NotSquareException nse)
            {
                lFeedback.Text = "Ha ocurrido un error. La matriz debe ser cuadrada para esta operación.\nRevise el número de filas y columnas de la matriz seleccionada.";
            }
            catch (Exception exception)
            {
                lFeedback.Text = "Ha ocurrido un error. Se ha introducido un valor inválido.\nAsegúrese que todos los campos contengan valores numéricos. (Los decimales son válidos)";
            }

        }//Fin de bCalcOperation_Click

        private void cbMatrixToUse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.AB)
            {
                pOperation2.Show();
                pOperation1.Hide();
            }
            else if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.A)
            {
                pOperation2.Hide();
                pOperation1.Show();
            }
            else if (cbMatrixToUse.SelectedIndex == (int)SelectedMatrix.B)
            {
                pOperation2.Hide();
                pOperation1.Show();
            }

        }//Fin de cbMatrixToUse_SelectedIndexChanged
        private void cbColumnsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            colsA = int.Parse(cbColumnsA.SelectedItem.ToString());
            mvMatrixA.Data = new MMatrix(rowsA, colsA);
        }//Fin de cbColumnsA_SelectedIndexChanged
        private void cbRowsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowsA = int.Parse(cbRowsA.SelectedItem.ToString());
            mvMatrixA.Data = new MMatrix(rowsA, colsA);
        }//Fin de cbRowsA_SelectedIndexChanged
        private void cbColumnsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            colsB = int.Parse(cbColumnsB.SelectedItem.ToString());
            mvMatrixB.Data = new MMatrix(rowsB, colsB);
        }//Fin de cbColumnsB_SelectedIndexChanged
        private void cbRowsB_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowsB = int.Parse(cbRowsB.SelectedItem.ToString());
            mvMatrixB.Data = new MMatrix(rowsB, colsB);
        }//Fin de cbRowsB_SelectedIndexChanged
    }//End of form

    public class NotSameSizeException : Exception { }
    public class NotSameNException : Exception { }
    public class NotSquareException : Exception { }
}
