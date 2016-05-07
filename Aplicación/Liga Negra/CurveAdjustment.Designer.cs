namespace Liga_Negra
{
    partial class pCurveAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pCurveAdjustment));
            this.pOptions = new System.Windows.Forms.Panel();
            this.lBackText = new System.Windows.Forms.Label();
            this.lBack = new System.Windows.Forms.Label();
            this.lHorner = new System.Windows.Forms.Label();
            this.pNavbar = new System.Windows.Forms.Panel();
            this.lMinimize = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lIcon = new System.Windows.Forms.Label();
            this.lExit = new System.Windows.Forms.Label();
            this.pMain = new System.Windows.Forms.Panel();
            this.lInstructions = new System.Windows.Forms.Label();
            this.pMatrixA = new System.Windows.Forms.Panel();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPoints = new System.Windows.Forms.ComboBox();
            this.lColumnasA = new System.Windows.Forms.Label();
            this.lMatrixA = new System.Windows.Forms.Label();
            this.bCalcOperation = new System.Windows.Forms.Button();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.PFeedback = new System.Windows.Forms.Panel();
            this.lFeedback = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mvResult = new Liga_Negra.MatrixView();
            this.mvPoints = new Liga_Negra.MatrixView();
            this.pOptions.SuspendLayout();
            this.pNavbar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pMatrixA.SuspendLayout();
            this.PFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pOptions.Controls.Add(this.lBackText);
            this.pOptions.Controls.Add(this.lBack);
            this.pOptions.Controls.Add(this.lHorner);
            this.pOptions.Location = new System.Drawing.Point(0, 29);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(801, 71);
            this.pOptions.TabIndex = 10;
            // 
            // lBackText
            // 
            this.lBackText.AutoSize = true;
            this.lBackText.Font = new System.Drawing.Font("Tw Cen MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBackText.Location = new System.Drawing.Point(50, 17);
            this.lBackText.Name = "lBackText";
            this.lBackText.Size = new System.Drawing.Size(83, 35);
            this.lBackText.TabIndex = 9;
            this.lBackText.Text = "Inicio";
            this.lBackText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBack
            // 
            this.lBack.AutoSize = true;
            this.lBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lBack.Image = global::Liga_Negra.Properties.Resources.Back;
            this.lBack.Location = new System.Drawing.Point(15, 15);
            this.lBack.Name = "lBack";
            this.lBack.Size = new System.Drawing.Size(33, 38);
            this.lBack.TabIndex = 8;
            this.lBack.Text = "\r\n      ";
            this.lBack.Click += new System.EventHandler(this.lBack_Click);
            // 
            // lHorner
            // 
            this.lHorner.AutoSize = true;
            this.lHorner.Font = new System.Drawing.Font("Tw Cen MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHorner.Location = new System.Drawing.Point(169, 18);
            this.lHorner.Name = "lHorner";
            this.lHorner.Size = new System.Drawing.Size(490, 35);
            this.lHorner.TabIndex = 0;
            this.lHorner.Text = "Obtener Ecuación que Toca los Puntos";
            this.lHorner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pNavbar.TabIndex = 12;
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
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.lInstructions);
            this.pMain.Controls.Add(this.mvResult);
            this.pMain.Controls.Add(this.pMatrixA);
            this.pMain.Controls.Add(this.bCalcOperation);
            this.pMain.Controls.Add(this.rtbResults);
            this.pMain.Location = new System.Drawing.Point(0, 98);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(801, 451);
            this.pMain.TabIndex = 13;
            // 
            // lInstructions
            // 
            this.lInstructions.AutoSize = true;
            this.lInstructions.Location = new System.Drawing.Point(146, 15);
            this.lInstructions.Name = "lInstructions";
            this.lInstructions.Size = new System.Drawing.Size(513, 38);
            this.lInstructions.TabIndex = 57;
            this.lInstructions.Text = "Llena la tabla con los puntos de los que quieres obtener una ecuación polinomial." +
    "\r\nDicha función puede ser de hasta 20 puntos.";
            this.lInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pMatrixA
            // 
            this.pMatrixA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMatrixA.Controls.Add(this.label2);
            this.pMatrixA.Controls.Add(this.mvPoints);
            this.pMatrixA.Controls.Add(this.cbDegree);
            this.pMatrixA.Controls.Add(this.label1);
            this.pMatrixA.Controls.Add(this.cbPoints);
            this.pMatrixA.Controls.Add(this.lColumnasA);
            this.pMatrixA.Controls.Add(this.lMatrixA);
            this.pMatrixA.Location = new System.Drawing.Point(19, 66);
            this.pMatrixA.Name = "pMatrixA";
            this.pMatrixA.Size = new System.Drawing.Size(769, 156);
            this.pMatrixA.TabIndex = 48;
            // 
            // cbDegree
            // 
            this.cbDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cbDegree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDegree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDegree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbDegree.Location = new System.Drawing.Point(520, 31);
            this.cbDegree.MaxDropDownItems = 5;
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(55, 27);
            this.cbDegree.TabIndex = 25;
            this.cbDegree.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Grado de polinomio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPoints
            // 
            this.cbPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cbPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPoints.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoints.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPoints.FormattingEnabled = true;
            this.cbPoints.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cbPoints.Location = new System.Drawing.Point(303, 31);
            this.cbPoints.MaxDropDownItems = 5;
            this.cbPoints.Name = "cbPoints";
            this.cbPoints.Size = new System.Drawing.Size(55, 27);
            this.cbPoints.TabIndex = 23;
            this.cbPoints.TabStop = false;
            this.cbPoints.SelectedIndexChanged += new System.EventHandler(this.cbPoints_SelectedIndexChanged);
            // 
            // lColumnasA
            // 
            this.lColumnasA.AutoSize = true;
            this.lColumnasA.Location = new System.Drawing.Point(173, 34);
            this.lColumnasA.Name = "lColumnasA";
            this.lColumnasA.Size = new System.Drawing.Size(124, 19);
            this.lColumnasA.TabIndex = 21;
            this.lColumnasA.Text = "Número de puntos";
            this.lColumnasA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lMatrixA
            // 
            this.lMatrixA.AutoSize = true;
            this.lMatrixA.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatrixA.Location = new System.Drawing.Point(352, 4);
            this.lMatrixA.Name = "lMatrixA";
            this.lMatrixA.Size = new System.Drawing.Size(68, 24);
            this.lMatrixA.TabIndex = 20;
            this.lMatrixA.Text = "Puntos";
            this.lMatrixA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCalcOperation
            // 
            this.bCalcOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCalcOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bCalcOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalcOperation.Location = new System.Drawing.Point(339, 233);
            this.bCalcOperation.Name = "bCalcOperation";
            this.bCalcOperation.Size = new System.Drawing.Size(116, 30);
            this.bCalcOperation.TabIndex = 46;
            this.bCalcOperation.TabStop = false;
            this.bCalcOperation.Text = "Calcular";
            this.bCalcOperation.UseVisualStyleBackColor = true;
            this.bCalcOperation.Click += new System.EventHandler(this.bCalcOperation_Click);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(13, 269);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(541, 161);
            this.rtbResults.TabIndex = 45;
            this.rtbResults.Text = "";
            // 
            // PFeedback
            // 
            this.PFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PFeedback.Controls.Add(this.lFeedback);
            this.PFeedback.Location = new System.Drawing.Point(0, 547);
            this.PFeedback.Name = "PFeedback";
            this.PFeedback.Size = new System.Drawing.Size(801, 53);
            this.PFeedback.TabIndex = 14;
            // 
            // lFeedback
            // 
            this.lFeedback.AutoSize = true;
            this.lFeedback.ForeColor = System.Drawing.SystemColors.Info;
            this.lFeedback.Location = new System.Drawing.Point(3, 7);
            this.lFeedback.Name = "lFeedback";
            this.lFeedback.Size = new System.Drawing.Size(565, 38);
            this.lFeedback.TabIndex = 0;
            this.lFeedback.Text = "Esta label sirve para dar retroalimenación al usuario, para evitar hacer muchas d" +
    "e estas.\r\nPor supuesto, soporta dos líneas de texto de necesitarlo.";
            this.lFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "x\r\ny";
            // 
            // mvResult
            // 
            this.mvResult.AllowUserToAddRows = false;
            this.mvResult.AllowUserToDeleteRows = false;
            this.mvResult.AllowUserToResizeColumns = false;
            this.mvResult.AllowUserToResizeRows = false;
            this.mvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.mvResult.EnableHeadersVisualStyles = false;
            this.mvResult.Location = new System.Drawing.Point(560, 269);
            this.mvResult.Name = "mvResult";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mvResult.RowHeadersWidth = 55;
            this.mvResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mvResult.ShowEditingIcon = false;
            this.mvResult.Size = new System.Drawing.Size(228, 161);
            this.mvResult.TabIndex = 0;
            // 
            // mvPoints
            // 
            this.mvPoints.AllowUserToAddRows = false;
            this.mvPoints.AllowUserToDeleteRows = false;
            this.mvPoints.AllowUserToResizeColumns = false;
            this.mvPoints.AllowUserToResizeRows = false;
            this.mvPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvPoints.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mvPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvPoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.mvPoints.EnableHeadersVisualStyles = false;
            this.mvPoints.Location = new System.Drawing.Point(48, 65);
            this.mvPoints.Name = "mvPoints";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvPoints.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mvPoints.RowHeadersWidth = 55;
            this.mvPoints.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mvPoints.ShowEditingIcon = false;
            this.mvPoints.Size = new System.Drawing.Size(250, 70);
            this.mvPoints.TabIndex = 0;
            // 
            // pCurveAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PFeedback);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pNavbar);
            this.Controls.Add(this.pOptions);
            this.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "pCurveAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurveAdjustment";
            this.pOptions.ResumeLayout(false);
            this.pOptions.PerformLayout();
            this.pNavbar.ResumeLayout(false);
            this.pNavbar.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pMatrixA.ResumeLayout(false);
            this.pMatrixA.PerformLayout();
            this.PFeedback.ResumeLayout(false);
            this.PFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Label lBackText;
        private System.Windows.Forms.Label lBack;
        private System.Windows.Forms.Label lHorner;
        private System.Windows.Forms.Panel pNavbar;
        private System.Windows.Forms.Label lMinimize;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lIcon;
        private System.Windows.Forms.Label lExit;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel PFeedback;
        private System.Windows.Forms.Label lFeedback;
        private System.Windows.Forms.Button bCalcOperation;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.Panel pMatrixA;
        private System.Windows.Forms.ComboBox cbPoints;
        private System.Windows.Forms.Label lColumnasA;
        private System.Windows.Forms.Label lMatrixA;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label label1;
        private MatrixView mvResult;
        private MatrixView mvPoints;
        private System.Windows.Forms.Label lInstructions;
        private System.Windows.Forms.Label label2;
    }
}