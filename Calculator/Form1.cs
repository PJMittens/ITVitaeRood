namespace Calculator
{
    public partial class Form1 : Form
    {
        string Handeling;
        double NumberOne;
        public Form1()
        {
            

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
                textBox1.Text = "1";
        } 
                
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text =  "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else
                textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "4";
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "5";
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "6";
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "7";
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "8";
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "9";
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0";
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        
        

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {

            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";            
            textBox3.Text = string.Format("{0:C}", NumberOne);
                   
        }

        private void buttonPunt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
                textBox1.Text = "0,";
            else
                textBox1.Text = textBox1.Text + ",";
        }

        private void buttonProcent_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            textBox3.Text = string.Format("{0:P}", NumberOne);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox3.Text = textBox1.Text;
            textBox1.Text = "0";
            Handeling = "+";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox3.Text = textBox1.Text;
            textBox1.Text = "0";
            Handeling = "-";
        }

        private void buttonKeer_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox3.Text = textBox1.Text;
            textBox1.Text = "0";
            Handeling = "*";
        }

        private void buttonDeel_Click(object sender, EventArgs e)
        {
            NumberOne = Convert.ToDouble(textBox1.Text);
            textBox3.Text = textBox1.Text;
            textBox1.Text = "0";
            Handeling = "/";
        }

        private void buttonIs_Click(object sender, EventArgs e)
        {
            
            double NumberTwo = Convert.ToDouble(textBox1.Text);
            double Resultaat;

            if (Handeling == "-")
            { 
                Resultaat = (NumberOne - NumberTwo);
                textBox3.Text = Convert.ToString(Resultaat);
                NumberOne = Resultaat;
            }
            if (Handeling == "+")
            {
                Resultaat = (NumberOne + NumberTwo);
                textBox3.Text = Convert.ToString(Resultaat);
                NumberOne = Resultaat;
            }
            if (Handeling == "*")
            {
                Resultaat = (NumberOne * NumberTwo);
                textBox3.Text = Convert.ToString(Resultaat);
                NumberOne = Resultaat;
            }
            if (Handeling == "/")
            {
                if (NumberTwo == 0)
                {
                    textBox3.Text = "Error! Dividing by 0";
                }
                else
                {
                    Resultaat = (NumberOne / NumberTwo);
                    textBox3.Text = Convert.ToString(Resultaat);
                    NumberOne = Resultaat;
                }
            }

            textBox1.Text = "0";



        }

        private void buttonAns_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(NumberOne);
            textBox3.Text = "0";
        }
       
    }
}