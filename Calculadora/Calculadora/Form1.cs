using System.Globalization;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        private NumberStyles cultureinfo;

        public Form1()
        {
            InitializeComponent();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
                lblOperacao.BringToFront();
            }
            else
            {
                MessageBox.Show("Não tenho bola de cristal, digita um numero ai cara");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
                lblOperacao.BringToFront();
            }
            else
            {
                MessageBox.Show("Não tenho bola de cristal, digita um numero ai cara");
            }

        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "X";
                lblOperacao.BringToFront();
            }
            else
            {
                MessageBox.Show("Não tenho bola de cristal, digita um numero ai cara");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
                lblOperacao.BringToFront();
            }
            else
            {
                MessageBox.Show("Não tenho bola de cristal, digita um numero ai cara");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUBTRACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if(operacao == "DIVISAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }
                else
                {
                    valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                    txtResultado.Text = Convert.ToString(valor1);
                }
            }
            else
            {
                MessageBox.Show("Assim fica difícil, digita algo ai cara");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            operacao = "";
            lblOperacao.Text = "";
        }
    }
}