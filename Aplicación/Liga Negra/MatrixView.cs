using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Liga_Negra
{
    class MatrixView : DataGridView
    {
        //input output grid handler class for a matrix with doubles
        //
        #region Private fields
        private const int cDefaultSize = 0; //default row and col size
                                            //array for the data in the grid
        private double[,] MData;
        // Boolean flag used to determine when a character other than a number is entered.
        private bool NumberEntered = false;

        #endregion
        #region Constructors
        public MatrixView()
        {
            InitializeDataGridView(cDefaultSize, cDefaultSize);
        }
        public MatrixView(int nRows, int nCols)
        {
            InitializeDataGridView(nRows, nCols);
        }

        public MatrixView(Point location, int nRows, int nCols)
        {
            InitializeDataGridView(nRows, nCols);
            this.Location = location;
        }
        #endregion
        #region Initialisation of the DataGridView

        private void InitializeDataGridView(int rows, int columns)
        {
            this.AutoGenerateColumns = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToResizeRows = false;
            this.AllowUserToResizeColumns = false;
            this.EnableHeadersVisualStyles = true;
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.EditMode = DataGridViewEditMode.EditOnKeystroke;
            this.Size = new System.Drawing.Size(250, 125);
            this.TabIndex = 0;
            this.RowHeadersWidth = 55;

            this.CellEndEdit += new DataGridViewCellEventHandler(this.ResizeCellColumn);
            //used to attach event-handlers to the events of the editing control(nice name!)
            this.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.MatrixView_EditingControlShowing);
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            if (rows != 0 && columns != 0)
            {
                for (int i = 0; i < columns; i++)
                {
                    AddAColumn(i);
                }

                for (int i = 0; i < rows; i++)
                {
                    AddARow(i);
                }

                int width = this.Columns.GetColumnsWidth(DataGridViewElementStates.None) + this.RowHeadersWidth;
                int height = this.Rows.GetRowsHeight(DataGridViewElementStates.None) + this.ColumnHeadersHeight;

                this.ClientSize = new Size(width + 2, height + 2);
                /*
                int height = 0;
                foreach (DataGridViewRow row in this.Rows)
                {
                    height += row.Height;
                }
                height += this.ColumnHeadersHeight;

                int width = 0;
                foreach (DataGridViewColumn col in this.Columns)
                {
                    width += col.Width;
                }
                width += this.RowHeadersWidth;

                this.ClientSize = new Size(width + 2, height + 2);*/

            }
            this.RowHeadersDefaultCellStyle.Padding = new Padding(3);//helps to get rid of the selection triangle?
            this.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Font defaultFontBold = new Font("Consolas", 9, FontStyle.Bold);
            this.ColumnHeadersDefaultCellStyle.Font = defaultFontBold;
            this.RowHeadersDefaultCellStyle.Font = defaultFontBold;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.ShowEditingIcon = false;
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ResizeCellColumn(object sender, DataGridViewCellEventArgs e)
        {
            //this.AutoResizeColumn(e.ColumnIndex);
            int width = 0;
            foreach (DataGridViewColumn col in this.Columns)
            {
                width += col.Width;
            }
            width += this.RowHeadersWidth;

            this.ClientSize = new Size(width + 2, this.ClientSize.Height);
        }

        private void AddARow(int i)
        {
            DataGridViewRow Arow = new DataGridViewRow();
            Arow.HeaderCell.Value = "R" + i.ToString();
            Arow.HeaderCell.Style.Font = new Font("Consolas", 9, FontStyle.Bold);
            this.Rows.Add(Arow);

        }
        private void AddAColumn(int i)
        {
            DataGridViewTextBoxColumn Acolumn = new DataGridViewTextBoxColumn();
            Acolumn.HeaderText = "C" + i.ToString();
            Acolumn.Name = "Column" + i.ToString();
            Acolumn.Width = 27;
            Acolumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewCell Acell = new DataGridViewTextBoxCell();
            Font defaultFontRegular = new Font("Consolas", 9);
            Acell.Style.Font = defaultFontRegular;
            Acolumn.CellTemplate = Acell;
            Acolumn.HeaderCell.Style.Font = new Font("Consolas", 9, FontStyle.Bold);
            this.Columns.Add(Acolumn);
        }
        public void MakeMatrixTitle(string Title)
        {
            this.TopLeftHeaderCell.Value = Title;
        }
        #endregion
        #region Properties and property utility functions

        public MMatrix Data
        {
            get
            {
                MData = new double[this.RowCount, this.ColumnCount];
                ExtractTextboxes();
                return new MMatrix(MData);
            }
            set
            {
                int _rows = value.Matrix.GetUpperBound(0) + 1;
                int _cols = value.Matrix.GetUpperBound(1) + 1;
                MData = new double[_rows, _cols];
                MData = value.Matrix;
                ResizeOurself(_rows, _cols);
                FillTextboxes();
                int width = this.Columns.GetColumnsWidth(DataGridViewElementStates.None) + this.RowHeadersWidth;
                int height = this.Rows.GetRowsHeight(DataGridViewElementStates.None) + this.ColumnHeadersHeight;

                this.ClientSize = new Size(width + 2, height + 2);
                //this.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        private void ResizeOurself(int r, int c)
        {
            //adjust rows and cols, do nothing if they equal
            while (c < this.ColumnCount)
            {
                this.Columns.RemoveAt(this.ColumnCount - 1);
            }
            while (c > this.ColumnCount)
            {
                AddAColumn(this.ColumnCount);
            }
            while (r < this.RowCount)
            {
                this.Rows.RemoveAt(this.RowCount - 1);
            }
            while (r > this.RowCount)
            {
                AddARow(this.RowCount);
            }
        }
        private void FillTextboxes()     //fill the textboxes
        {
            for (int r = 0; r < this.RowCount; r++)
            {
                for (int c = 0; c < this.ColumnCount; c++)
                {
                    this[c, r].Value = MData[r, c]; //notice r, c
                    //this.AutoResizeColumn(this[c, r].ColumnIndex, DataGridViewAutoSizeColumnMode.AllCells);
                    //System.Diagnostics.Debug.WriteLine(this.Columns[c].Width);
                }
            }

        }
        private void ExtractTextboxes()
        {
            for (int r = 0; r < this.RowCount; r++)
            {
                for (int c = 0; c < this.ColumnCount; c++)
                {
                    try
                    {
                        string str = this[c, r].Value.ToString();
                        MData[r, c] = Convert.ToDouble(str);   //notice r, c 
                    }
                    catch (Exception)
                    {
                        MData[r, c] = 0.0;  //assume for the moment this if the cell is not filled
                    }

                }
            }
        }
        #endregion
        #region Key and keyboard processing
        //Check if key entered is "numeric"
        private bool CheckKey(Keys K, bool isDecimalPoint, bool isMinus)
        {
            if (K == Keys.Back) //backspace?
                return true;
            else if (K == Keys.OemPeriod || K == Keys.Decimal)  //decimal point?
                return isDecimalPoint ? false : true;       //or: return !isDecimalPoint
            else if (K == Keys.OemMinus || K == Keys.Subtract)
                return !isMinus;
            else if ((K >= Keys.D0) && (K <= Keys.D9))      //digit from top of keyboard?
                return true;
            else if ((K >= Keys.NumPad0) && (K <= Keys.NumPad9))    //digit from keypad?
                return true;
            else
                return false;   //no "numeric" key
        }
        // Handle the KeyDown event to determine the type of character entered into the control.
        // The method here should be registered as KeyEventHandler to the EditingControl 
        // of the DataGridView in order for it to work (took me some time to figure that out...)
        private void MatrixIO_KeyDown(object sender, KeyEventArgs e)
        {
            //we know we have columns of type DataGridViewTextBoxColumn so :
            TextBox Tbx = (TextBox)sender;
            bool decimalTyped = Tbx.Text.Contains(".");
            bool minusTyped = Tbx.Text.Contains("-");
            // Initialize the flag.
            NumberEntered = CheckKey(e.KeyCode, decimalTyped, minusTyped);
        }
        // This event occurs after the KeyDown event and can be used to prevent
        // characters from entering the control.
        private void MatrixIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for the flag being set in the KeyDown event.
            if (NumberEntered == false)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
            }
        }
        private void MatrixIO_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                NumberEntered = false;
            }
        }
        private void MatrixView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Unsubscribe from the event in case it is subscribed
            this.EditingControl.KeyPress -= new KeyPressEventHandler(MatrixIO_KeyPress);
            this.EditingControl.KeyDown -= new KeyEventHandler(this.MatrixIO_KeyDown);
            this.EditingControl.KeyPress += new KeyPressEventHandler(MatrixIO_KeyPress);
            this.EditingControl.KeyDown += new KeyEventHandler(this.MatrixIO_KeyDown);
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            Keys key = (keyData & Keys.KeyCode);
            if (key == Keys.Enter)
            {
                int currentColumn = this.CurrentCell.ColumnIndex;
                int currentRow = this.CurrentCell.RowIndex;
                if (currentColumn == this.Columns.Count - 1) //if is last
                    this.CurrentCell = this[0, currentRow];
                else
                    return this.ProcessRightKey(keyData);
            }
            return base.ProcessDialogKey(keyData);
        }
        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int currentColumn = this.CurrentCell.ColumnIndex;
                int currentRow = this.CurrentCell.RowIndex;
                if (currentColumn == this.Columns.Count - 1) //if is last
                    this.CurrentCell = this[0, currentRow];
                else
                    return this.ProcessRightKey(e.KeyData);
            }
            return base.ProcessDataGridViewKey(e);
        }
        #endregion
    }
}
