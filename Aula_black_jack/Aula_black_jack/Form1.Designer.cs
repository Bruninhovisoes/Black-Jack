namespace Aula_black_jack
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
            pictureBox1 = new PictureBox();
            btn_pegarcarta = new Button();
            pictureBox2 = new PictureBox();
            btn_parar1 = new Button();
            btn_pegarcarta2 = new Button();
            btn_parar2 = new Button();
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            btn_reiniciar = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(266, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_pegarcarta
            // 
            btn_pegarcarta.Location = new Point(12, 435);
            btn_pegarcarta.Name = "btn_pegarcarta";
            btn_pegarcarta.Size = new Size(75, 23);
            btn_pegarcarta.TabIndex = 1;
            btn_pegarcarta.Text = "pegar carta";
            btn_pegarcarta.UseVisualStyleBackColor = true;
            btn_pegarcarta.Click += btn_pegar1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(526, 138);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btn_parar1
            // 
            btn_parar1.Location = new Point(93, 435);
            btn_parar1.Name = "btn_parar1";
            btn_parar1.Size = new Size(75, 23);
            btn_parar1.TabIndex = 3;
            btn_parar1.Text = "parar";
            btn_parar1.UseVisualStyleBackColor = true;
            btn_parar1.Click += btn_parar1_Click;
            // 
            // btn_pegarcarta2
            // 
            btn_pegarcarta2.Location = new Point(738, 12);
            btn_pegarcarta2.Name = "btn_pegarcarta2";
            btn_pegarcarta2.Size = new Size(75, 23);
            btn_pegarcarta2.TabIndex = 4;
            btn_pegarcarta2.Text = "pegar carta";
            btn_pegarcarta2.UseVisualStyleBackColor = true;
            btn_pegarcarta2.Click += btn_pegar2_Click;
            // 
            // btn_parar2
            // 
            btn_parar2.Location = new Point(819, 12);
            btn_parar2.Name = "btn_parar2";
            btn_parar2.Size = new Size(75, 23);
            btn_parar2.TabIndex = 5;
            btn_parar2.Text = "parar";
            btn_parar2.UseVisualStyleBackColor = true;
            btn_parar2.Click += btn_parar2_Click;
            // 
            // textbox1
            // 
            textbox1.BackColor = Color.Olive;
            textbox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox1.ForeColor = Color.White;
            textbox1.Location = new Point(160, 193);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(100, 33);
            textbox1.TabIndex = 6;
            textbox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textbox2
            // 
            textbox2.BackColor = Color.Olive;
            textbox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox2.ForeColor = Color.White;
            textbox2.Location = new Point(642, 192);
            textbox2.Name = "textbox2";
            textbox2.Size = new Size(100, 33);
            textbox2.TabIndex = 7;
            textbox2.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_reiniciar
            // 
            btn_reiniciar.Location = new Point(414, 192);
            btn_reiniciar.Name = "btn_reiniciar";
            btn_reiniciar.Size = new Size(75, 23);
            btn_reiniciar.TabIndex = 8;
            btn_reiniciar.Text = "Reiniciar";
            btn_reiniciar.UseVisualStyleBackColor = true;
            btn_reiniciar.Click += btn_reiniciar_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.carta_costas;
            pictureBox3.Location = new Point(24, 276);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(127, 153);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.carta_costas;
            pictureBox4.Location = new Point(748, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(128, 153);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(918, 470);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(btn_reiniciar);
            Controls.Add(textbox2);
            Controls.Add(textbox1);
            Controls.Add(btn_parar2);
            Controls.Add(btn_pegarcarta2);
            Controls.Add(btn_parar1);
            Controls.Add(pictureBox2);
            Controls.Add(btn_pegarcarta);
            Controls.Add(pictureBox1);
            ForeColor = Color.Blue;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_pegarcarta;
        private PictureBox pictureBox2;
        private Button btn_parar1;
        private Button btn_pegarcarta2;
        private Button btn_parar2;
        private TextBox textbox1;
        private TextBox textbox2;
        private Button btn_reiniciar;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
