namespace ООП_3_Задание_2
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
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.MatrixB = new System.Windows.Forms.DataGridView();
            this.MatrixC = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RowsA = new System.Windows.Forms.TextBox();
            this.ColumnsA = new System.Windows.Forms.TextBox();
            this.RowsB = new System.Windows.Forms.TextBox();
            this.ColumnsB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixA
            // 
            this.MatrixA.AllowUserToAddRows = false;
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.Location = new System.Drawing.Point(130, 55);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.RowHeadersWidth = 51;
            this.MatrixA.RowTemplate.Height = 24;
            this.MatrixA.Size = new System.Drawing.Size(385, 272);
            this.MatrixA.TabIndex = 0;
            // 
            // MatrixB
            // 
            this.MatrixB.AllowUserToAddRows = false;
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.Location = new System.Drawing.Point(1016, 55);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.RowHeadersWidth = 51;
            this.MatrixB.RowTemplate.Height = 24;
            this.MatrixB.Size = new System.Drawing.Size(385, 272);
            this.MatrixB.TabIndex = 1;
            // 
            // MatrixC
            // 
            this.MatrixC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixC.Location = new System.Drawing.Point(581, 402);
            this.MatrixC.Name = "MatrixC";
            this.MatrixC.RowHeadersWidth = 51;
            this.MatrixC.RowTemplate.Height = 24;
            this.MatrixC.Size = new System.Drawing.Size(368, 238);
            this.MatrixC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Столбцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Строки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(926, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Столбцы";
            // 
            // RowsA
            // 
            this.RowsA.Location = new System.Drawing.Point(521, 166);
            this.RowsA.Name = "RowsA";
            this.RowsA.Size = new System.Drawing.Size(100, 22);
            this.RowsA.TabIndex = 7;
            // 
            // ColumnsA
            // 
            this.ColumnsA.Location = new System.Drawing.Point(521, 294);
            this.ColumnsA.Name = "ColumnsA";
            this.ColumnsA.Size = new System.Drawing.Size(100, 22);
            this.ColumnsA.TabIndex = 8;
            // 
            // RowsB
            // 
            this.RowsB.Location = new System.Drawing.Point(910, 163);
            this.RowsB.Name = "RowsB";
            this.RowsB.Size = new System.Drawing.Size(100, 22);
            this.RowsB.TabIndex = 9;
            // 
            // ColumnsB
            // 
            this.ColumnsB.Location = new System.Drawing.Point(910, 294);
            this.ColumnsB.Name = "ColumnsB";
            this.ColumnsB.Size = new System.Drawing.Size(100, 22);
            this.ColumnsB.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 98);
            this.button1.TabIndex = 11;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 62);
            this.button2.TabIndex = 12;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetDimensions_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(710, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 62);
            this.button3.TabIndex = 13;
            this.button3.Text = "Заполнить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(710, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 62);
            this.button4.TabIndex = 14;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 652);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ColumnsB);
            this.Controls.Add(this.RowsB);
            this.Controls.Add(this.ColumnsA);
            this.Controls.Add(this.RowsA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MatrixC);
            this.Controls.Add(this.MatrixB);
            this.Controls.Add(this.MatrixA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.DataGridView MatrixB;
        private System.Windows.Forms.DataGridView MatrixC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RowsA;
        private System.Windows.Forms.TextBox ColumnsA;
        private System.Windows.Forms.TextBox RowsB;
        private System.Windows.Forms.TextBox ColumnsB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

