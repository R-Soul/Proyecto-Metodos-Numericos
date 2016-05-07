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
    public partial class fMain : Form
    {
        //Esto permite accesar a esta forma desde cualquier lado, se define en fMain()
        public static fMain instance = null;

        //Estas variables son solo para mover la pantalla de la aplicación.
        private bool isFormBeingDragged = false;
        private int mouseX = 0;
        private int mouseY = 0;


        public fMain()
        {
            if (instance == null) { instance = this;}
            InitializeComponent();
            init();
        }

        /* Nombre: init
         * Descripción: Inicializa los campos, labels, etc, a los valores que se requieren al iniciar.
         * 
         * Fecha de Creación: 24/04/2016
         * Autor Original: Luis Arzola
         * 
         * Última Fecha de Modificación: 24/04/2016
         * Autor Última Moficiación: Luis Arzola
         * 
         * Programas que Llama: Ninguno
         * Programas que lo Llaman: fMain()
        */
        private void init()
        {
            new pHorner();
            new pNewthonRaphson();
            new pNewthonMultivariable();
            new pMatrixOperations();
            new pInverseMatrix();
            new pCurveAdjustment();
        }

        /* Nombre: lExit_Click | lMinimize_Click
         * Descripción: Hace la llamada para salir y minimizar la apliación respectivamente.
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
        private void lExit_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null){Application.Exit();}
        }//Fin de lExit_Click()
        private void lMinimize_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null) { this.WindowState = FormWindowState.Minimized; }
        }//Fin de lMinimize_Click()

        /* Nombre: pNavbar_MouseDown | pNavbar_Up | pNavbar_Move
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
        }//Fin de pNavbar_MouseDown()
        private void pNavbar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left){isFormBeingDragged = false;}
        }//Fin de pNavbar_MouseUp()
        private void pNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormBeingDragged)
            {
                Point tmp = new Point();
                tmp.X = this.Location.X + (e.X - mouseX);
                tmp.Y = this.Location.Y + (e.Y - mouseY);
                this.Location = tmp;
            }
        }//Fin de pNavbar_MouseMove()

        private void bHorner_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pHorner.instance.Show();
            pHorner.instance.Location = this.Location;
        }

        private void bNewthonRaphson_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pNewthonRaphson.instance.Show();
            pNewthonRaphson.instance.Location = this.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pMatrixOperations.instance.Show();
            pMatrixOperations.instance.Location = this.Location;
        }

        private void bInverse_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pInverseMatrix.instance.Show();
            pInverseMatrix.instance.Location = this.Location;
        }

        private void bCurveAdjustment_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pCurveAdjustment.instance.Show();
            pCurveAdjustment.instance.Location = this.Location;
        }

        private void bNewthonMultivariable_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.CenterToScreen();
            pNewthonMultivariable.instance.Show();
            pNewthonMultivariable.instance.Location = this.Location;
        }
    }
}
