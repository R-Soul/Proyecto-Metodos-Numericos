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
    public partial class pInverseMatrix : Form
    {
        /*------------------------*/
        /*DECLARACIÓN DE VARIABLES*/
        /*------------------------*/

        public static pInverseMatrix instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;
        private int rows;

        /*----------------------------------------*/
        /*FUNCIONES OPERACIONALES (MATRIZ INVERSA)*/
        /*----------------------------------------*/
        
        public MMatrix invMatrix(MMatrix coeffs, MMatrix ind)
        {
            //Aqui calculamos la matriz inversa de la que necesitamos
            MMatrix matrizInversa = new MMatrix(pMatrixOperations.instance.inverse(coeffs));

            //Aqui hacemos una multiplicacion de matrices entre la matriz inversa y la matriz de los terminos independientes
            MMatrix resultado = new MMatrix(pMatrixOperations.instance.multiply(matrizInversa, ind));


            return resultado;
        }//Fin de invMatrix

        /*---------------------------------------------------------------*/
        /*CONTROL DE FORM (LLAMADAS A OTROS FORMS | INICIALIZACIÓN | ETC)*/
        /*---------------------------------------------------------------*/

        public pInverseMatrix()
        {
            if (instance == null) { instance = this; } else { this.Close(); }
            InitializeComponent();
            init();
        }//Fin de pInverseMatrix

        private void init()
        {
            lFeedback.Text = "";
            mvMatrixB.Data = new MMatrix(3, 1);
            mvMatrixA.Data = new MMatrix(3, 3);
            rtbResults.Text = "";
            cbColumnsA.SelectedIndex = 1;

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

        private void cbColumnsA_SelectedIndexChanged(object sender, EventArgs e)
        {
            rows = int.Parse(cbColumnsA.SelectedItem.ToString());
            mvMatrixA.Data = new MMatrix(rows, rows);
            mvMatrixB.Data = new MMatrix(rows, 1);

        }//Fin de cbColumnsA_SelectedIndexChanged

        /*------------------------------------------------------*/
        /*LLAMADAS DE INFERFAZ (BOTONES | LABELS | CAMPOS | ETC)*/
        /*------------------------------------------------------*/
        
        /* Nombre: bCalcOperation_Click
        * Descripción: Actualiza los valores y actua como interprete entre invMatrix y la interfaz
        * 
        * Fecha de Creación: 29/04/2016
        * Autor Original: Ricardo Trevizo
        * 
        * Última Fecha de Modificación: 29/04/2016
        * Autor Última Moficiación: Ricardo Trevizo
        * 
        * Programas que Llama: invMatrix
        * Programas que lo Llaman: ninguno
       */
        private void bCalcOperation_Click(object sender, EventArgs e)
        {
            //Este arreglo es solo para saber el nombre de las variables y en ese orden se presentaran
            char[] myVariables =  new char[] {  'a', 'b', 'c', 'd', 'e', };

            lFeedback.Text = "";
            rtbResults.Text = "";

            //Se construye la matriz con los resultados
            MMatrix resultado = invMatrix(mvMatrixA.Data, mvMatrixB.Data);
            rtbResults.Text += "\nSe han calculado los siguientes valores:";

            //Este ciclo se ejecutara tantas veces como longitud tenga la matriz de resultados para mostrar cada resultado
            for (int x = 0; x < resultado.Matrix.Length; x++)
            {
                rtbResults.Text += "\n"+myVariables[x]+" = " + resultado.Matrix[x, 0];
            }


        }//Fin de bCalcOperation_Click
    }
}
