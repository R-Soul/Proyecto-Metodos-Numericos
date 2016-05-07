namespace Liga_Negra
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pNavbar = new System.Windows.Forms.Panel();
            this.lMinimize = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lIcon = new System.Windows.Forms.Label();
            this.lExit = new System.Windows.Forms.Label();
            this.pOptions = new System.Windows.Forms.Panel();
            this.lApplication = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lInstructions = new System.Windows.Forms.Label();
            this.bCurveAdjustment = new System.Windows.Forms.Button();
            this.bNewthonMultivariable = new System.Windows.Forms.Button();
            this.bInverse = new System.Windows.Forms.Button();
            this.bMatrix = new System.Windows.Forms.Button();
            this.bNewthonRaphson = new System.Windows.Forms.Button();
            this.bHorner = new System.Windows.Forms.Button();
            this.PFeedback = new System.Windows.Forms.Panel();
            this.pNavbar.SuspendLayout();
            this.pOptions.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pNavbar
            // 
            this.pNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.pNavbar.Controls.Add(this.lMinimize);
            this.pNavbar.Controls.Add(this.lTitle);
            this.pNavbar.Controls.Add(this.lIcon);
            this.pNavbar.Controls.Add(this.lExit);
            this.pNavbar.Location = new System.Drawing.Point(0, 0);
            this.pNavbar.Margin = new System.Windows.Forms.Padding(4);
            this.pNavbar.Name = "pNavbar";
            this.pNavbar.Size = new System.Drawing.Size(801, 32);
            this.pNavbar.TabIndex = 0;
            this.pNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pNavbar_MouseDown);
            this.pNavbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pNavbar_MouseMove);
            this.pNavbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pNavbar_MouseUp);
            // 
            // lMinimize
            // 
            this.lMinimize.AutoSize = true;
            this.lMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lMinimize.Image = global::Liga_Negra.Properties.Resources.Minimize;
            this.lMinimize.Location = new System.Drawing.Point(748, -4);
            this.lMinimize.Name = "lMinimize";
            this.lMinimize.Size = new System.Drawing.Size(17, 38);
            this.lMinimize.TabIndex = 3;
            this.lMinimize.Text = "\r\n  ";
            this.lMinimize.Click += new System.EventHandler(this.lMinimize_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lTitle.Location = new System.Drawing.Point(29, 5);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(217, 19);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Métodos Numéricos - Liga Negra";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lIcon
            // 
            this.lIcon.AutoSize = true;
            this.lIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.lIcon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lIcon.Image = global::Liga_Negra.Properties.Resources.Liga_Negra;
            this.lIcon.Location = new System.Drawing.Point(9, -4);
            this.lIcon.Name = "lIcon";
            this.lIcon.Size = new System.Drawing.Size(17, 38);
            this.lIcon.TabIndex = 1;
            this.lIcon.Text = "\r\n  ";
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lExit.Image = global::Liga_Negra.Properties.Resources.Exit;
            this.lExit.Location = new System.Drawing.Point(771, -4);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(17, 38);
            this.lExit.TabIndex = 0;
            this.lExit.Text = "\r\n  ";
            this.lExit.Click += new System.EventHandler(this.lExit_Click);
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pOptions.Controls.Add(this.lApplication);
            this.pOptions.Location = new System.Drawing.Point(0, 29);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(801, 71);
            this.pOptions.TabIndex = 1;
            // 
            // lApplication
            // 
            this.lApplication.AutoSize = true;
            this.lApplication.Font = new System.Drawing.Font("Tw Cen MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lApplication.Location = new System.Drawing.Point(74, 18);
            this.lApplication.Name = "lApplication";
            this.lApplication.Size = new System.Drawing.Size(646, 35);
            this.lApplication.TabIndex = 0;
            this.lApplication.Text = "Bienvenido a la Aplicación de Métodos Numéricos";
            this.lApplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.label1);
            this.pMain.Controls.Add(this.lInstructions);
            this.pMain.Controls.Add(this.bCurveAdjustment);
            this.pMain.Controls.Add(this.bNewthonMultivariable);
            this.pMain.Controls.Add(this.bInverse);
            this.pMain.Controls.Add(this.bMatrix);
            this.pMain.Controls.Add(this.bNewthonRaphson);
            this.pMain.Controls.Add(this.bHorner);
            this.pMain.Location = new System.Drawing.Point(0, 98);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(801, 451);
            this.pMain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 95);
            this.label1.TabIndex = 57;
            this.label1.Text = "Este es un Proyecto Elaborado para la Clase de Métodos Numéricos, Clase Enero-May" +
    "o 2016.\r\n\r\nCreado Por:\r\nKendra Corral | Daniel Salazar | Luis Arzola\r\nRicardo Tr" +
    "evizo | Jonathan Sotelo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lInstructions
            // 
            this.lInstructions.AutoSize = true;
            this.lInstructions.Location = new System.Drawing.Point(251, 29);
            this.lInstructions.Name = "lInstructions";
            this.lInstructions.Size = new System.Drawing.Size(293, 19);
            this.lInstructions.TabIndex = 56;
            this.lInstructions.Text = "Selecciona la operación que desees efectuar.";
            this.lInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCurveAdjustment
            // 
            this.bCurveAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCurveAdjustment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bCurveAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCurveAdjustment.Location = new System.Drawing.Point(532, 212);
            this.bCurveAdjustment.Name = "bCurveAdjustment";
            this.bCurveAdjustment.Size = new System.Drawing.Size(254, 107);
            this.bCurveAdjustment.TabIndex = 8;
            this.bCurveAdjustment.TabStop = false;
            this.bCurveAdjustment.Text = "Crear una Función Polinomial en Base a Puntos\r\n\r\n(Ajuste de Curva)";
            this.bCurveAdjustment.UseVisualStyleBackColor = true;
            this.bCurveAdjustment.Click += new System.EventHandler(this.bCurveAdjustment_Click);
            // 
            // bNewthonMultivariable
            // 
            this.bNewthonMultivariable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewthonMultivariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bNewthonMultivariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewthonMultivariable.Location = new System.Drawing.Point(272, 212);
            this.bNewthonMultivariable.Name = "bNewthonMultivariable";
            this.bNewthonMultivariable.Size = new System.Drawing.Size(254, 107);
            this.bNewthonMultivariable.TabIndex = 7;
            this.bNewthonMultivariable.TabStop = false;
            this.bNewthonMultivariable.Text = "Obtener la Intersección de Dos Funciones Polinomiales\r\n\r\n(Raphson Multivariable)";
            this.bNewthonMultivariable.UseVisualStyleBackColor = true;
            this.bNewthonMultivariable.Click += new System.EventHandler(this.bNewthonMultivariable_Click);
            // 
            // bInverse
            // 
            this.bInverse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInverse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInverse.Location = new System.Drawing.Point(13, 212);
            this.bInverse.Name = "bInverse";
            this.bInverse.Size = new System.Drawing.Size(254, 107);
            this.bInverse.TabIndex = 6;
            this.bInverse.TabStop = false;
            this.bInverse.Text = "Resolver un Sistema de Ecuaciones\r\n\r\n(Matriz Inversa)";
            this.bInverse.UseVisualStyleBackColor = true;
            this.bInverse.Click += new System.EventHandler(this.bInverse_Click);
            // 
            // bMatrix
            // 
            this.bMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bMatrix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMatrix.Location = new System.Drawing.Point(532, 83);
            this.bMatrix.Name = "bMatrix";
            this.bMatrix.Size = new System.Drawing.Size(254, 107);
            this.bMatrix.TabIndex = 5;
            this.bMatrix.TabStop = false;
            this.bMatrix.Text = "Operaciones con Una o Dos Matrices\r\n\r\n(Escalar, Suma, Multiplicación, División, I" +
    "nversa, Determinante, Transpuesta)";
            this.bMatrix.UseVisualStyleBackColor = true;
            this.bMatrix.Click += new System.EventHandler(this.button1_Click);
            // 
            // bNewthonRaphson
            // 
            this.bNewthonRaphson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bNewthonRaphson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bNewthonRaphson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNewthonRaphson.Location = new System.Drawing.Point(272, 83);
            this.bNewthonRaphson.Name = "bNewthonRaphson";
            this.bNewthonRaphson.Size = new System.Drawing.Size(254, 107);
            this.bNewthonRaphson.TabIndex = 4;
            this.bNewthonRaphson.TabStop = false;
            this.bNewthonRaphson.Text = "Obtener una Raíz de una Función Polinomial\r\n\r\n(Newthon-Raphson)";
            this.bNewthonRaphson.UseVisualStyleBackColor = true;
            this.bNewthonRaphson.Click += new System.EventHandler(this.bNewthonRaphson_Click);
            // 
            // bHorner
            // 
            this.bHorner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHorner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bHorner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHorner.Location = new System.Drawing.Point(12, 83);
            this.bHorner.Name = "bHorner";
            this.bHorner.Size = new System.Drawing.Size(254, 107);
            this.bHorner.TabIndex = 3;
            this.bHorner.TabStop = false;
            this.bHorner.Text = "Obtener Valores de Derivadas en Funciones Polinomiales\r\n\r\n(Horner)";
            this.bHorner.UseVisualStyleBackColor = true;
            this.bHorner.Click += new System.EventHandler(this.bHorner_Click);
            // 
            // PFeedback
            // 
            this.PFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PFeedback.Location = new System.Drawing.Point(0, 548);
            this.PFeedback.Name = "PFeedback";
            this.PFeedback.Size = new System.Drawing.Size(801, 53);
            this.PFeedback.TabIndex = 2;
            // 
            // fMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.PFeedback);
            this.Controls.Add(this.pOptions);
            this.Controls.Add(this.pNavbar);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos Numéricos - Liga Negra";
            this.pNavbar.ResumeLayout(false);
            this.pNavbar.PerformLayout();
            this.pOptions.ResumeLayout(false);
            this.pOptions.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pNavbar;
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Label lIcon;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lMinimize;
        private System.Windows.Forms.Label lApplication;
        private System.Windows.Forms.Button bHorner;
        private System.Windows.Forms.Button bNewthonRaphson;
        private System.Windows.Forms.Button bMatrix;
        private System.Windows.Forms.Button bCurveAdjustment;
        private System.Windows.Forms.Button bNewthonMultivariable;
        private System.Windows.Forms.Button bInverse;
        private System.Windows.Forms.Label lInstructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PFeedback;
    }
}

