namespace ООП_Задание_1._7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Ввести = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 0;
            // 
            // Ввести
            // 
            Ввести.BackgroundImageLayout = ImageLayout.Stretch;
            Ввести.Location = new Point(99, 170);
            Ввести.Name = "Ввести";
            Ввести.Size = new Size(215, 57);
            Ввести.TabIndex = 1;
            Ввести.Text = "Ввести";
            Ввести.UseVisualStyleBackColor = true;
            Ввести.Click += In_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 51);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 2;
            label1.Text = " Введите вещественное число";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(490, 51);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 4;
            label2.Text = "Последнее введенное значение:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(575, 120);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(64, 27);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Ввести);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Ввести;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}