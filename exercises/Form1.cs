namespace exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtNumOne = numOne.Text;
            string txtNumTwo = numTwo.Text;

            int numberOne = Int32.Parse(txtNumOne);
            int numberTwo = Int32.Parse(txtNumTwo);

            bool greaterThan = numberOne > numberTwo;

            if (greaterThan)
            {
                MessageBox.Show("El numero mayor es el numero " + txtNumOne);
            }
            else
            {
                MessageBox.Show("El numero mayor es el numero " + txtNumTwo);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberOne = Int32.Parse(textBox1.Text);
            int numberTwo = Int32.Parse(textBox2.Text);
            int numberThree = Int32.Parse(textBox3.Text);

            //Calculate greatest number

            // Set the number one as the greater number 

            int greater = numberOne;

            if (numberTwo> greater)
            {
                greater = numberTwo;
            }
            if (numberThree > greater)
            {
                greater = numberThree;
            }
            MessageBox.Show("El numero mayor es " + greater);

            int lessNumb = numberOne;

            if (numberTwo < lessNumb)
            {
                lessNumb = numberTwo;
            }
            if (numberThree < lessNumb)
            {
                lessNumb = numberThree;
            }
            MessageBox.Show("El numero menor es " + lessNumb);
        }
    }
}
