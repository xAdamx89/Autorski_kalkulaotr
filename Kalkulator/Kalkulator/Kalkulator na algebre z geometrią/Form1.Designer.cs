namespace Kalkulator_na_algebre_z_geometrią
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            Wyznacznik = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(514, 32);
            label1.TabIndex = 0;
            label1.Text = "Kalkulator obliczający wyznacznik macierzy 3x3";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(188, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 265);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(305, 183);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(305, 225);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(305, 265);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(150, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(503, 183);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 11;
            label2.Text = "Wyznacznik danej macierzy wynosi";
            // 
            // Wyznacznik
            // 
            Wyznacznik.AutoSize = true;
            Wyznacznik.Font = new Font("Segoe UI", 15F);
            Wyznacznik.Location = new Point(569, 220);
            Wyznacznik.Name = "Wyznacznik";
            Wyznacznik.Size = new Size(0, 28);
            Wyznacznik.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(259, 304);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(313, 75);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 14;
            label3.Text = "Brakuje liczb w macierzy!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(295, 94);
            label4.Name = "label4";
            label4.Size = new Size(200, 19);
            label4.TabIndex = 15;
            label4.Text = "Program przyjmuje tylko liczby!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 387);
            label5.Name = "label5";
            label5.Size = new Size(784, 15);
            label5.TabIndex = 17;
            label5.Text = "Instrukcja: W wolne pola macierzy wpisz wartości, następnie wciśnij przycisk oblicz, a po prawej stornie od macierzy pojawi się wartość wyznacznika.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 426);
            label6.Name = "label6";
            label6.Size = new Size(322, 15);
            label6.TabIndex = 18;
            label6.Text = "UWAGA!!! Program nie przyjmuje liter i znaków specjalnych.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 402);
            label7.Name = "label7";
            label7.Size = new Size(529, 15);
            label7.TabIndex = 19;
            label7.Text = "Wciśnij przycisk \"Reset\", aby zniknąć błędy, wyczyścić macierz oraz wyczyścić wartość wyznacznika.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(348, 53);
            label8.Name = "label8";
            label8.Size = new Size(103, 21);
            label8.TabIndex = 21;
            label8.Text = "Okno błędów";
            // 
            // button3
            // 
            button3.Location = new Point(188, 333);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 22;
            button3.Text = "Jak to działa?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(Wyznacznik);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kalkulator algebra z geometrią";
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button button1;
        private Label label2;
        private Label Wyznacznik;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button3;
    }
}
