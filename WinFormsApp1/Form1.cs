namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {



            if (label2.Text == "*")
            {
                label3.Text += button1.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button1.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button1.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button1.Text;
            }
            else
            {
                label1.Text += button1.Text;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (label2.Text == "*")
            {
                label3.Text += button2.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button2.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button2.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button2.Text;
            }
            else
            {
                label1.Text += button2.Text;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (label2.Text == "*")
            {
                label3.Text += button3.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button3.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button3.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button3.Text;
            }
            else
            {
                label1.Text += button3.Text;

            }


        }

        private void mult_Click(object sender, EventArgs e)
        {
            label2.Text = mult.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                int result = int.Parse(label1.Text) * int.Parse(label3.Text);
                label4.Text = result.ToString();
            }

            if (label2.Text == "+")
            {
                int result = int.Parse(label1.Text) + int.Parse(label3.Text);
                label4.Text = result.ToString();
            }

            if (label2.Text == "-")
            {
                int result = int.Parse(label1.Text) - int.Parse(label3.Text);
                label4.Text = result.ToString();
            }

            if (label2.Text == "/")
            {
                int result = int.Parse(label1.Text) / int.Parse(label3.Text);
                label4.Text = result.ToString();
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button4.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button4.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button4.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button4.Text;
            }
            else
            {
                label1.Text += button4.Text;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button5.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button5.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button5.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button5.Text;
            }
            else
            {
                label1.Text += button5.Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button6.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button6.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button6.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button6.Text;
            }
            else
            {
                label1.Text += button6.Text;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button7.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button7.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button7.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button7.Text;
            }
            else
            {
                label1.Text += button7.Text;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button8.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button8.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button8.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button8.Text;
            }
            else
            {
                label1.Text += button8.Text;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button9.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button9.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button9.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button9.Text;
            }
            else
            {
                label1.Text += button9.Text;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label2.Text == "*")
            {
                label3.Text += button10.Text;

            }
            else if (label2.Text == "+")

            {

                label3.Text += button10.Text;

            }
            else if (label2.Text == "-")

            {
                label3.Text += button10.Text;

            }
            else if (label2.Text == "/")
            {

                label3.Text += button10.Text;
            }
            else
            {
                label1.Text += button10.Text;

            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
            label3.Text = "0";
            label4.Text = "RESULT";
        }
    }
}
