namespace ООП_2_Задание_4
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
            this.MatrixB = new System.Windows.Forms.DataGridView();
            this.MatrixC = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.RowsA = new System.Windows.Forms.TextBox();
            this.ColumnsA = new System.Windows.Forms.TextBox();
            this.ColumnsB = new System.Windows.Forms.TextBox();
            this.RowsB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            this.SuspendLayout();
            // 
            // MatrixB
            // 
            this.MatrixB.AllowUserToAddRows = false;
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.Location = new System.Drawing.Point(781, 21);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.RowHeadersWidth = 51;
            this.MatrixB.RowTemplate.Height = 24;
            this.MatrixB.Size = new System.Drawing.Size(333, 262);
            this.MatrixB.TabIndex = 1;
            // 
            // MatrixC
            // 
            this.MatrixC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixC.Location = new System.Drawing.Point(376, 364);
            this.MatrixC.Name = "MatrixC";
            this.MatrixC.RowHeadersWidth = 51;
            this.MatrixC.RowTemplate.Height = 24;
            this.MatrixC.Size = new System.Drawing.Size(399, 282);
            this.MatrixC.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 123);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MatrixA
            // 
            this.MatrixA.AllowUserToAddRows = false;
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.Location = new System.Drawing.Point(40, 21);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.RowHeadersWidth = 51;
            this.MatrixA.RowTemplate.Height = 24;
            this.MatrixA.Size = new System.Drawing.Size(330, 262);
            this.MatrixA.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Создать ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSetDimensions_Click);
            // 
            // RowsA
            // 
            this.RowsA.Location = new System.Drawing.Point(376, 176);
            this.RowsA.Name = "RowsA";
            this.RowsA.Size = new System.Drawing.Size(100, 22);
            this.RowsA.TabIndex = 10;
            // 
            // ColumnsA
            // 
            this.ColumnsA.Location = new System.Drawing.Point(376, 261);
            this.ColumnsA.Name = "ColumnsA";
            this.ColumnsA.Size = new System.Drawing.Size(100, 22);
            this.ColumnsA.TabIndex = 11;
            // 
            // ColumnsB
            // 
            this.ColumnsB.Location = new System.Drawing.Point(675, 261);
            this.ColumnsB.Name = "ColumnsB";
            this.ColumnsB.Size = new System.Drawing.Size(100, 22);
            this.ColumnsB.TabIndex = 12;
            // 
            // RowsB
            // 
            this.RowsB.Location = new System.Drawing.Point(675, 176);
            this.RowsB.Name = "RowsB";
            this.RowsB.Size = new System.Drawing.Size(100, 22);
            this.RowsB.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(506, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 56);
            this.button4.TabIndex = 14;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 56);
            this.button3.TabIndex = 15;
            this.button3.Text = "Заполнить ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnFillRandom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Столбцы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(695, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Строки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(695, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Столбцы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RowsB);
            this.Controls.Add(this.ColumnsB);
            this.Controls.Add(this.ColumnsA);
            this.Controls.Add(this.RowsA);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.MatrixA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MatrixC);
            this.Controls.Add(this.MatrixB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MatrixB;
        private System.Windows.Forms.DataGridView MatrixC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox RowsA;
        private System.Windows.Forms.TextBox ColumnsA;
        private System.Windows.Forms.TextBox ColumnsB;
        private System.Windows.Forms.TextBox RowsB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

