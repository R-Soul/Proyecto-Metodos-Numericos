namespace Liga_Negra
{
    partial class pInverseMatrix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pInverseMatrix));
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
            this.pMatrixB = new System.Windows.Forms.Panel();
            this.lMatrixB = new System.Windows.Forms.Label();
            this.bCalcOperation = new System.Windows.Forms.Button();
            this.pMatrixA = new System.Windows.Forms.Panel();
            this.cbColumnsA = new System.Windows.Forms.ComboBox();
            this.lColumnasA = new System.Windows.Forms.Label();
            this.lMatrixA = new System.Windows.Forms.Label();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.PFeedback = new System.Windows.Forms.Panel();
            this.lFeedback = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvMatrixB = new Liga_Negra.MatrixView();
            this.mvMatrixA = new Liga_Negra.MatrixView();
            this.pOptions.SuspendLayout();
            this.pNavbar.SuspendLayout();
            this.pMain.SuspendLayout();
            this.pMatrixB.SuspendLayout();
            this.pMatrixA.SuspendLayout();
            this.PFeedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvMatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvMatrixA)).BeginInit();
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
            this.pOptions.TabIndex = 9;
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
            this.lHorner.Location = new System.Drawing.Point(196, 18);
            this.lHorner.Name = "lHorner";
            this.lHorner.Size = new System.Drawing.Size(450, 35);
            this.lHorner.TabIndex = 0;
            this.lHorner.Text = "Resolver un Sistema de Ecuaciones";
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
            this.pNavbar.TabIndex = 11;
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
            this.pMain.Controls.Add(this.pMatrixB);
            this.pMain.Controls.Add(this.bCalcOperation);
            this.pMain.Controls.Add(this.pMatrixA);
            this.pMain.Controls.Add(this.rtbResults);
            this.pMain.Location = new System.Drawing.Point(0, 98);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(801, 502);
            this.pMain.TabIndex = 12;
            // 
            // lInstructions
            // 
            this.lInstructions.AutoSize = true;
            this.lInstructions.Location = new System.Drawing.Point(54, 6);
            this.lInstructions.Name = "lInstructions";
            this.lInstructions.Size = new System.Drawing.Size(702, 38);
            this.lInstructions.TabIndex = 46;
            this.lInstructions.Text = "Coloca en la tabla de la izquierda los valores del sistema de ecuaciones, así com" +
    "o el tamaño de dicho sistema.\r\nY en el lado derecho los valores de los términos " +
    "independientes.";
            this.lInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pMatrixB
            // 
            this.pMatrixB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMatrixB.Controls.Add(this.mvMatrixB);
            this.pMatrixB.Controls.Add(this.lMatrixB);
            this.pMatrixB.Location = new System.Drawing.Point(419, 53);
            this.pMatrixB.Name = "pMatrixB";
            this.pMatrixB.Size = new System.Drawing.Size(351, 184);
            this.pMatrixB.TabIndex = 39;
            // 
            // lMatrixB
            // 
            this.lMatrixB.AutoSize = true;
            this.lMatrixB.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatrixB.Location = new System.Drawing.Point(66, 6);
            this.lMatrixB.Name = "lMatrixB";
            this.lMatrixB.Size = new System.Drawing.Size(226, 24);
            this.lMatrixB.TabIndex = 20;
            this.lMatrixB.Text = "Terminos independientes";
            this.lMatrixB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCalcOperation
            // 
            this.bCalcOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCalcOperation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.bCalcOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCalcOperation.Location = new System.Drawing.Point(349, 246);
            this.bCalcOperation.Name = "bCalcOperation";
            this.bCalcOperation.Size = new System.Drawing.Size(116, 30);
            this.bCalcOperation.TabIndex = 44;
            this.bCalcOperation.TabStop = false;
            this.bCalcOperation.Text = "Calcular";
            this.bCalcOperation.UseVisualStyleBackColor = true;
            this.bCalcOperation.Click += new System.EventHandler(this.bCalcOperation_Click);
            // 
            // pMatrixA
            // 
            this.pMatrixA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMatrixA.Controls.Add(this.mvMatrixA);
            this.pMatrixA.Controls.Add(this.cbColumnsA);
            this.pMatrixA.Controls.Add(this.lColumnasA);
            this.pMatrixA.Controls.Add(this.lMatrixA);
            this.pMatrixA.Location = new System.Drawing.Point(33, 53);
            this.pMatrixA.Name = "pMatrixA";
            this.pMatrixA.Size = new System.Drawing.Size(351, 184);
            this.pMatrixA.TabIndex = 36;
            // 
            // cbColumnsA
            // 
            this.cbColumnsA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.cbColumnsA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbColumnsA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumnsA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbColumnsA.FormattingEnabled = true;
            this.cbColumnsA.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cbColumnsA.Location = new System.Drawing.Point(33, 75);
            this.cbColumnsA.MaxDropDownItems = 5;
            this.cbColumnsA.Name = "cbColumnsA";
            this.cbColumnsA.Size = new System.Drawing.Size(55, 27);
            this.cbColumnsA.Sorted = true;
            this.cbColumnsA.TabIndex = 23;
            this.cbColumnsA.TabStop = false;
            this.cbColumnsA.SelectedIndexChanged += new System.EventHandler(this.cbColumnsA_SelectedIndexChanged);
            // 
            // lColumnasA
            // 
            this.lColumnasA.AutoSize = true;
            this.lColumnasA.Location = new System.Drawing.Point(20, 49);
            this.lColumnasA.Name = "lColumnasA";
            this.lColumnasA.Size = new System.Drawing.Size(60, 19);
            this.lColumnasA.TabIndex = 21;
            this.lColumnasA.Text = "Tamaño";
            this.lColumnasA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lMatrixA
            // 
            this.lMatrixA.AutoSize = true;
            this.lMatrixA.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMatrixA.Location = new System.Drawing.Point(126, 6);
            this.lMatrixA.Name = "lMatrixA";
            this.lMatrixA.Size = new System.Drawing.Size(113, 24);
            this.lMatrixA.TabIndex = 20;
            this.lMatrixA.Text = "Coeficientes";
            this.lMatrixA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(12, 282);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.ReadOnly = true;
            this.rtbResults.Size = new System.Drawing.Size(776, 161);
            this.rtbResults.TabIndex = 42;
            this.rtbResults.Text = "Se realizó la operación 5A + 5B";
            // 
            // PFeedback
            // 
            this.PFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.PFeedback.Controls.Add(this.lFeedback);
            this.PFeedback.Location = new System.Drawing.Point(0, 547);
            this.PFeedback.Name = "PFeedback";
            this.PFeedback.Size = new System.Drawing.Size(801, 53);
            this.PFeedback.TabIndex = 13;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "C0";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "C1";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "C2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "C3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "C4";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn5.Width = 60;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "C0";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn9.Width = 60;
            // 
            // mvMatrixB
            // 
            this.mvMatrixB.AllowUserToAddRows = false;
            this.mvMatrixB.AllowUserToDeleteRows = false;
            this.mvMatrixB.AllowUserToResizeColumns = false;
            this.mvMatrixB.AllowUserToResizeRows = false;
            this.mvMatrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvMatrixB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mvMatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvMatrixB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.mvMatrixB.Location = new System.Drawing.Point(132, 38);
            this.mvMatrixB.Name = "mvMatrixB";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvMatrixB.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mvMatrixB.RowHeadersWidth = 55;
            this.mvMatrixB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvMatrixB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mvMatrixB.ShowEditingIcon = false;
            this.mvMatrixB.Size = new System.Drawing.Size(55, 125);
            this.mvMatrixB.TabIndex = 0;
            // 
            // mvMatrixA
            // 
            this.mvMatrixA.AllowUserToAddRows = false;
            this.mvMatrixA.AllowUserToDeleteRows = false;
            this.mvMatrixA.AllowUserToResizeColumns = false;
            this.mvMatrixA.AllowUserToResizeRows = false;
            this.mvMatrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvMatrixA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mvMatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvMatrixA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.mvMatrixA.Location = new System.Drawing.Point(114, 38);
            this.mvMatrixA.Name = "mvMatrixA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mvMatrixA.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mvMatrixA.RowHeadersWidth = 55;
            this.mvMatrixA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvMatrixA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mvMatrixA.ShowEditingIcon = false;
            this.mvMatrixA.Size = new System.Drawing.Size(250, 125);
            this.mvMatrixA.TabIndex = 0;
            // 
            // pInverseMatrix
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
            this.Name = "pInverseMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InverseMatrix";
            this.pOptions.ResumeLayout(false);
            this.pOptions.PerformLayout();
            this.pNavbar.ResumeLayout(false);
            this.pNavbar.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pMatrixB.ResumeLayout(false);
            this.pMatrixB.PerformLayout();
            this.pMatrixA.ResumeLayout(false);
            this.pMatrixA.PerformLayout();
            this.PFeedback.ResumeLayout(false);
            this.PFeedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mvMatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvMatrixA)).EndInit();
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
        private System.Windows.Forms.Label lInstructions;
        private System.Windows.Forms.Panel pMatrixB;
        private System.Windows.Forms.Label lMatrixB;
        private System.Windows.Forms.Button bCalcOperation;
        private System.Windows.Forms.Panel pMatrixA;
        private System.Windows.Forms.ComboBox cbColumnsA;
        private System.Windows.Forms.Label lColumnasA;
        private System.Windows.Forms.Label lMatrixA;
        private System.Windows.Forms.RichTextBox rtbResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private MatrixView mvMatrixB;
        private MatrixView mvMatrixA;
    }
}