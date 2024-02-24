namespace Kalkulator_na_algebre_z_geometrią
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "") 
                label3.Visible = true;
            else
            {

                int[,] matrix = new int[3, 3];
                int wyznacznik = 0, tmp;

                matrix[0, 0] = Convert.ToInt32(textBox1.Text);
                matrix[1, 0] = Convert.ToInt32(textBox2.Text);
                matrix[2, 0] = Convert.ToInt32(textBox3.Text);

                matrix[0, 1] = Convert.ToInt32(textBox4.Text);
                matrix[1, 1] = Convert.ToInt32(textBox5.Text);
                matrix[2, 1] = Convert.ToInt32(textBox6.Text);

                matrix[0, 2] = Convert.ToInt32(textBox7.Text);
                matrix[1, 2] = Convert.ToInt32(textBox8.Text);
                matrix[2, 2] = Convert.ToInt32(textBox9.Text);

                tmp = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[0, 2] * matrix[1, 0] * matrix[2, 1];
                wyznacznik = tmp - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2] - matrix[0, 0] * matrix[1, 2] * matrix[2, 1];

                Wyznacznik.Text = Convert.ToString(wyznacznik);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wyznacznik.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
    }
}
