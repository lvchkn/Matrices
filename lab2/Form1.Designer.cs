namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSizeA = new System.Windows.Forms.Label();
            this.lblMatrixA = new System.Windows.Forms.Label();
            this.lblMatrixB = new System.Windows.Forms.Label();
            this.tbMatrixARowsCount = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbMatrixAColsCount = new System.Windows.Forms.TextBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblSizeB = new System.Windows.Forms.Label();
            this.tbMatrixBRowsCount = new System.Windows.Forms.TextBox();
            this.tbMatrixBColsCount = new System.Windows.Forms.TextBox();
            this.lblXA = new System.Windows.Forms.Label();
            this.lblXB = new System.Windows.Forms.Label();
            this.btnShowMatrice = new System.Windows.Forms.Button();
            this.gridA = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTableA = new System.Data.DataTable();
            this.dataTableB = new System.Data.DataTable();
            this.gridB = new System.Windows.Forms.DataGridView();
            this.gridAddRes = new System.Windows.Forms.DataGridView();
            this.gridMultRes = new System.Windows.Forms.DataGridView();
            this.lblAddMatrix = new System.Windows.Forms.Label();
            this.lblMultMatrix = new System.Windows.Forms.Label();
            this.lblTimeText = new System.Windows.Forms.Label();
            this.lblTimeAdd = new System.Windows.Forms.Label();
            this.lblTimeMult = new System.Windows.Forms.Label();
            this.lblTimeText2 = new System.Windows.Forms.Label();
            this.btnAddMatrix = new System.Windows.Forms.Button();
            this.btnMultMatrix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultRes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSizeA
            // 
            this.lblSizeA.AutoSize = true;
            this.lblSizeA.Location = new System.Drawing.Point(8, 33);
            this.lblSizeA.Name = "lblSizeA";
            this.lblSizeA.Size = new System.Drawing.Size(180, 13);
            this.lblSizeA.TabIndex = 1;
            this.lblSizeA.Text = "Укажите размерность матрицы А";
            // 
            // lblMatrixA
            // 
            this.lblMatrixA.AutoSize = true;
            this.lblMatrixA.Location = new System.Drawing.Point(191, 116);
            this.lblMatrixA.Name = "lblMatrixA";
            this.lblMatrixA.Size = new System.Drawing.Size(61, 13);
            this.lblMatrixA.TabIndex = 2;
            this.lblMatrixA.Text = "Матрица А";
            // 
            // lblMatrixB
            // 
            this.lblMatrixB.AutoSize = true;
            this.lblMatrixB.Location = new System.Drawing.Point(574, 116);
            this.lblMatrixB.Name = "lblMatrixB";
            this.lblMatrixB.Size = new System.Drawing.Size(61, 13);
            this.lblMatrixB.TabIndex = 3;
            this.lblMatrixB.Text = "Матрица В";
            // 
            // tbMatrixARowsCount
            // 
            this.tbMatrixARowsCount.Location = new System.Drawing.Point(194, 30);
            this.tbMatrixARowsCount.Name = "tbMatrixARowsCount";
            this.tbMatrixARowsCount.Size = new System.Drawing.Size(100, 20);
            this.tbMatrixARowsCount.TabIndex = 5;
            // 
            // tbMatrixAColsCount
            // 
            this.tbMatrixAColsCount.Location = new System.Drawing.Point(320, 30);
            this.tbMatrixAColsCount.Name = "tbMatrixAColsCount";
            this.tbMatrixAColsCount.Size = new System.Drawing.Size(100, 20);
            this.tbMatrixAColsCount.TabIndex = 10;
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(191, 14);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(73, 13);
            this.lblRows.TabIndex = 11;
            this.lblRows.Text = "Кол-во строк";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(317, 14);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(91, 13);
            this.lblCols.TabIndex = 12;
            this.lblCols.Text = "Кол-во столбцов";
            // 
            // lblSizeB
            // 
            this.lblSizeB.AutoSize = true;
            this.lblSizeB.Location = new System.Drawing.Point(8, 88);
            this.lblSizeB.Name = "lblSizeB";
            this.lblSizeB.Size = new System.Drawing.Size(180, 13);
            this.lblSizeB.TabIndex = 13;
            this.lblSizeB.Text = "Укажите размерность матрицы В";
            // 
            // tbMatrixBRowsCount
            // 
            this.tbMatrixBRowsCount.Location = new System.Drawing.Point(194, 81);
            this.tbMatrixBRowsCount.Name = "tbMatrixBRowsCount";
            this.tbMatrixBRowsCount.Size = new System.Drawing.Size(100, 20);
            this.tbMatrixBRowsCount.TabIndex = 14;
            // 
            // tbMatrixBColsCount
            // 
            this.tbMatrixBColsCount.Location = new System.Drawing.Point(320, 81);
            this.tbMatrixBColsCount.Name = "tbMatrixBColsCount";
            this.tbMatrixBColsCount.Size = new System.Drawing.Size(100, 20);
            this.tbMatrixBColsCount.TabIndex = 15;
            // 
            // lblXA
            // 
            this.lblXA.AutoSize = true;
            this.lblXA.Location = new System.Drawing.Point(300, 33);
            this.lblXA.Name = "lblXA";
            this.lblXA.Size = new System.Drawing.Size(14, 13);
            this.lblXA.TabIndex = 16;
            this.lblXA.Text = "X";
            // 
            // lblXB
            // 
            this.lblXB.AutoSize = true;
            this.lblXB.Location = new System.Drawing.Point(300, 84);
            this.lblXB.Name = "lblXB";
            this.lblXB.Size = new System.Drawing.Size(14, 13);
            this.lblXB.TabIndex = 17;
            this.lblXB.Text = "X";
            // 
            // btnShowMatrice
            // 
            this.btnShowMatrice.Location = new System.Drawing.Point(438, 42);
            this.btnShowMatrice.Name = "btnShowMatrice";
            this.btnShowMatrice.Size = new System.Drawing.Size(98, 34);
            this.btnShowMatrice.TabIndex = 18;
            this.btnShowMatrice.Text = "Вывод матриц";
            this.btnShowMatrice.UseVisualStyleBackColor = true;
            this.btnShowMatrice.Click += new System.EventHandler(this.btnShowMatrice_Click);
            // 
            // gridA
            // 
            this.gridA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridA.Location = new System.Drawing.Point(56, 136);
            this.gridA.Name = "gridA";
            this.gridA.Size = new System.Drawing.Size(320, 118);
            this.gridA.TabIndex = 19;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableA,
            this.dataTableB});
            // 
            // dataTableA
            // 
            this.dataTableA.TableName = "TableA";
            // 
            // dataTableB
            // 
            this.dataTableB.TableName = "TableB";
            // 
            // gridB
            // 
            this.gridB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridB.Location = new System.Drawing.Point(437, 136);
            this.gridB.Name = "gridB";
            this.gridB.Size = new System.Drawing.Size(320, 118);
            this.gridB.TabIndex = 20;
            // 
            // gridAddRes
            // 
            this.gridAddRes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridAddRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAddRes.Location = new System.Drawing.Point(56, 308);
            this.gridAddRes.Name = "gridAddRes";
            this.gridAddRes.Size = new System.Drawing.Size(320, 118);
            this.gridAddRes.TabIndex = 21;
            this.gridAddRes.Visible = false;
            // 
            // gridMultRes
            // 
            this.gridMultRes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMultRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMultRes.Location = new System.Drawing.Point(437, 308);
            this.gridMultRes.Name = "gridMultRes";
            this.gridMultRes.Size = new System.Drawing.Size(320, 118);
            this.gridMultRes.TabIndex = 22;
            this.gridMultRes.Visible = false;
            // 
            // lblAddMatrix
            // 
            this.lblAddMatrix.AutoSize = true;
            this.lblAddMatrix.Location = new System.Drawing.Point(103, 283);
            this.lblAddMatrix.Name = "lblAddMatrix";
            this.lblAddMatrix.Size = new System.Drawing.Size(222, 13);
            this.lblAddMatrix.TabIndex = 23;
            this.lblAddMatrix.Text = "Результирующая матрица сложения A + B";
            // 
            // lblMultMatrix
            // 
            this.lblMultMatrix.AutoSize = true;
            this.lblMultMatrix.Location = new System.Drawing.Point(483, 283);
            this.lblMultMatrix.Name = "lblMultMatrix";
            this.lblMultMatrix.Size = new System.Drawing.Size(227, 13);
            this.lblMultMatrix.TabIndex = 24;
            this.lblMultMatrix.Text = "Результирующая матрица умножения A * B";
            // 
            // lblTimeText
            // 
            this.lblTimeText.AutoSize = true;
            this.lblTimeText.Location = new System.Drawing.Point(53, 429);
            this.lblTimeText.Name = "lblTimeText";
            this.lblTimeText.Size = new System.Drawing.Size(42, 13);
            this.lblTimeText.TabIndex = 25;
            this.lblTimeText.Text = "Time = ";
            this.lblTimeText.Visible = false;
            // 
            // lblTimeAdd
            // 
            this.lblTimeAdd.AutoSize = true;
            this.lblTimeAdd.Location = new System.Drawing.Point(90, 429);
            this.lblTimeAdd.Name = "lblTimeAdd";
            this.lblTimeAdd.Size = new System.Drawing.Size(0, 13);
            this.lblTimeAdd.TabIndex = 26;
            // 
            // lblTimeMult
            // 
            this.lblTimeMult.AutoSize = true;
            this.lblTimeMult.Location = new System.Drawing.Point(483, 429);
            this.lblTimeMult.Name = "lblTimeMult";
            this.lblTimeMult.Size = new System.Drawing.Size(0, 13);
            this.lblTimeMult.TabIndex = 27;
            // 
            // lblTimeText2
            // 
            this.lblTimeText2.AutoSize = true;
            this.lblTimeText2.Location = new System.Drawing.Point(435, 429);
            this.lblTimeText2.Name = "lblTimeText2";
            this.lblTimeText2.Size = new System.Drawing.Size(42, 13);
            this.lblTimeText2.TabIndex = 28;
            this.lblTimeText2.Text = "Time = ";
            this.lblTimeText2.Visible = false;
            // 
            // btnAddMatrix
            // 
            this.btnAddMatrix.Location = new System.Drawing.Point(551, 42);
            this.btnAddMatrix.Name = "btnAddMatrix";
            this.btnAddMatrix.Size = new System.Drawing.Size(98, 34);
            this.btnAddMatrix.TabIndex = 29;
            this.btnAddMatrix.Text = "Сложение матриц";
            this.btnAddMatrix.UseVisualStyleBackColor = true;
            this.btnAddMatrix.Click += new System.EventHandler(this.btnAddMatrix_Click);
            // 
            // btnMultMatrix
            // 
            this.btnMultMatrix.Location = new System.Drawing.Point(659, 42);
            this.btnMultMatrix.Name = "btnMultMatrix";
            this.btnMultMatrix.Size = new System.Drawing.Size(98, 34);
            this.btnMultMatrix.TabIndex = 30;
            this.btnMultMatrix.Text = "Умножение матриц";
            this.btnMultMatrix.UseVisualStyleBackColor = true;
            this.btnMultMatrix.Click += new System.EventHandler(this.btnMultMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMultMatrix);
            this.Controls.Add(this.btnAddMatrix);
            this.Controls.Add(this.lblTimeText2);
            this.Controls.Add(this.lblTimeMult);
            this.Controls.Add(this.lblTimeAdd);
            this.Controls.Add(this.lblTimeText);
            this.Controls.Add(this.lblMultMatrix);
            this.Controls.Add(this.lblAddMatrix);
            this.Controls.Add(this.gridMultRes);
            this.Controls.Add(this.gridAddRes);
            this.Controls.Add(this.gridB);
            this.Controls.Add(this.gridA);
            this.Controls.Add(this.btnShowMatrice);
            this.Controls.Add(this.lblXB);
            this.Controls.Add(this.lblXA);
            this.Controls.Add(this.tbMatrixBColsCount);
            this.Controls.Add(this.tbMatrixBRowsCount);
            this.Controls.Add(this.lblSizeB);
            this.Controls.Add(this.lblCols);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.tbMatrixAColsCount);
            this.Controls.Add(this.tbMatrixARowsCount);
            this.Controls.Add(this.lblMatrixB);
            this.Controls.Add(this.lblMatrixA);
            this.Controls.Add(this.lblSizeA);
            this.Name = "Form1";
            this.Text = "Левочкин А. (3-46) - Лаб. №2 - Сложение и умножение матриц";
            ((System.ComponentModel.ISupportInitialize)(this.gridA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMultRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSizeA;
        private System.Windows.Forms.Label lblMatrixA;
        private System.Windows.Forms.Label lblMatrixB;
        private System.Windows.Forms.TextBox tbMatrixARowsCount;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbMatrixAColsCount;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Label lblSizeB;
        private System.Windows.Forms.TextBox tbMatrixBRowsCount;
        private System.Windows.Forms.TextBox tbMatrixBColsCount;
        private System.Windows.Forms.Label lblXA;
        private System.Windows.Forms.Label lblXB;
        private System.Windows.Forms.Button btnShowMatrice;
        private System.Windows.Forms.DataGridView gridA;
        private System.Data.DataSet dataSet1;
        public System.Data.DataTable dataTableA;
        public System.Data.DataTable dataTableB;
        private System.Windows.Forms.DataGridView gridB;
        private System.Windows.Forms.DataGridView gridAddRes;
        private System.Windows.Forms.DataGridView gridMultRes;
        private System.Windows.Forms.Label lblAddMatrix;
        private System.Windows.Forms.Label lblMultMatrix;
        private System.Windows.Forms.Label lblTimeText;
        private System.Windows.Forms.Label lblTimeAdd;
        private System.Windows.Forms.Label lblTimeMult;
        private System.Windows.Forms.Label lblTimeText2;
        private System.Windows.Forms.Button btnAddMatrix;
        private System.Windows.Forms.Button btnMultMatrix;
    }
}

