namespace Trabalho_Final_Verção_2
{
    partial class Medicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicao));
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(194, 356);
            button1.Name = "button1";
            button1.Size = new Size(128, 29);
            button1.TabIndex = 11;
            button1.Text = "Finalizar Pedido";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.MidnightBlue;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = SystemColors.Window;
            textBox4.Location = new Point(100, 312);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 16);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.MidnightBlue;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(193, 250);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 16);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MidnightBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(82, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 16);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MidnightBlue;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(82, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 16);
            textBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(334, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Medicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 397);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Medicao";
            Text = "Medição";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}