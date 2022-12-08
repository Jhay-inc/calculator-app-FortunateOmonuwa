namespace Calculator
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operation = "";
        bool confirmOperation = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Result.Text == "0") || confirmOperation)
            {
                Result.Clear();
            }
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!Result.Text.Contains("."))
                    Result.Text = Result.Text + button.Text;


            }
            else
            Result.Text = Result.Text + button.Text;
            confirmOperation= false;
           
            //Result.Text = Result.Text + "1";
        }

        private void Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0) 
            {
                operation = button.Text;
                OperationDisplay.Text = resultValue + " " + operation;
                confirmOperation = true;
            }
            else
            {
                operation = button.Text;
                resultValue = Double.Parse(Result.Text);
                OperationDisplay.Text = resultValue + " " + operation;
                confirmOperation = true;
            }
            
        }

        private void Clear(object sender, EventArgs e)
        {
            Result.Text="0";
            resultValue =0;
        }

        private void EqualTo_Click(object sender, EventArgs e)
        {
            
            switch(operation)
            {
                case "+":
                    Result.Text = (resultValue + Double.Parse(Result.Text)).ToString();
                    break;
                case "-":
                    Result.Text = (resultValue - Double.Parse(Result.Text)).ToString();
                    break;
                case "*":
                    Result.Text = (resultValue * Double.Parse(Result.Text)).ToString();
                    break;
                case "/":
                    Result.Text = (resultValue / Double.Parse(Result.Text)).ToString();
                    break;
                case "%":
                    Result.Text = (resultValue % Double.Parse(Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(Result.Text);
            OperationDisplay.Text = "";
        }

        

        
    }
}