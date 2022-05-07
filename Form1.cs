namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        Char operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNum(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtResultado.Text == "0")
                txtResultado.Text = "";

            txtResultado.Text += boton.Text;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);

            if (operacion == '+')
            {
                txtResultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operacion == '-')
            {
                txtResultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operacion == '*')
            {
                txtResultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtResultado.Text);
            }
            else if (operacion == '/')
            {
                if (txtResultado.Text != "0")
                {
                    txtResultado.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txtResultado.Text);
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operacion = '\0';
            txtResultado.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains("."))
            {
                txtResultado.Text += ".";
            }
            
        }

        private void BotonesOperadores (object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtResultado.Text);
            operacion = Convert.ToChar(boton.Tag);
            txtResultado.Text = "0";
        }


    }
}