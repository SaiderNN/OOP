namespace Event_App
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Pic1 = new PictureBox();
            Pic2 = new PictureBox();
            Pic3 = new PictureBox();
            button_pull = new Button();
            imageList = new ImageList(components);
            CountBox = new TextBox();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Pic1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Pic1
            // 
            Pic1.BorderStyle = BorderStyle.Fixed3D;
            Pic1.ImageLocation = "";
            Pic1.Location = new Point(141, 57);
            Pic1.Name = "Pic1";
            Pic1.Size = new Size(113, 117);
            Pic1.SizeMode = PictureBoxSizeMode.Zoom;
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            // 
            // Pic2
            // 
            Pic2.BorderStyle = BorderStyle.Fixed3D;
            Pic2.ImageLocation = "";
            Pic2.Location = new Point(272, 57);
            Pic2.Name = "Pic2";
            Pic2.Size = new Size(115, 117);
            Pic2.SizeMode = PictureBoxSizeMode.Zoom;
            Pic2.TabIndex = 1;
            Pic2.TabStop = false;
            // 
            // Pic3
            // 
            Pic3.BorderStyle = BorderStyle.Fixed3D;
            Pic3.ImageLocation = "";
            Pic3.Location = new Point(409, 57);
            Pic3.Name = "Pic3";
            Pic3.Size = new Size(113, 117);
            Pic3.SizeMode = PictureBoxSizeMode.Zoom;
            Pic3.TabIndex = 2;
            Pic3.TabStop = false;
            Pic3.Click += Pic3_Click;
            // 
            // button_pull
            // 
            button_pull.Location = new Point(668, 57);
            button_pull.Name = "button_pull";
            button_pull.Size = new Size(120, 357);
            button_pull.TabIndex = 3;
            button_pull.Text = "PULL";
            button_pull.UseVisualStyleBackColor = true;
            button_pull.Click += button_pull_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "gold.png");
            imageList.Images.SetKeyName(1, "strawberry.png");
            imageList.Images.SetKeyName(2, "trash.png");
            // 
            // CountBox
            // 
            CountBox.Location = new Point(253, 245);
            CountBox.Name = "CountBox";
            CountBox.Size = new Size(147, 27);
            CountBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 285);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "Count";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(626, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(CountBox);
            Controls.Add(button_pull);
            Controls.Add(Pic3);
            Controls.Add(Pic2);
            Controls.Add(Pic1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Pic1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Pic1;
        private PictureBox Pic2;
        private PictureBox Pic3;
        private Button button_pull;
        private ImageList imageList;
        private TextBox CountBox;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
    }
}