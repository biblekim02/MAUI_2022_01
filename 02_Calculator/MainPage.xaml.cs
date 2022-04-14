namespace _02_Calculator
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string operatorMath;
        double firstNum, secondNum;
        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }

        private void OnClear(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            currentState = 1;
            result.Text = "0";
        }

        private void OnSquare(object sender, EventArgs e)
        {
            if (firstNum == 0)
                return;
            firstNum = firstNum * firstNum;
            if (firstNum == double.Parse(((int)firstNum).ToString()))
                result.Text = firstNum.ToString("N0");
            else
                result.Text = firstNum.ToString();
        }

        private void OnOpSelection(object sender, EventArgs e)
        {
            currentState = -2;
            Button btn = (Button)sender;
            string btnOp = btn.Text;
            operatorMath = btnOp;
        }

        private void OnCalculate(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double r = Calculate.DoCalc(firstNum, secondNum, operatorMath);
                if (r == double.Parse(((int)r).ToString()))
                    result.Text = r.ToString("N0");
                else
                    result.Text = r.ToString();
                firstNum = r;
                currentState = -1;
            }

        }

        private void OnNumberSelection(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string btnVal = btn.Text;

            if (result.Text == "0" || currentState < 0) // 숫자입력 전 또는 op 클릭 후나 계산 후
            {
                result.Text = string.Empty;
                if (currentState < 0)
                    currentState *= -1;
            }

            result.Text += btnVal;  // 숫자 붙여서 출력

            double n;
            if (double.TryParse(result.Text, out n))
            {
                result.Text = n.ToString("N0");
                if (currentState == 1)
                    firstNum = n;
                else // 2이면, 즉 op가 눌린 후 숫자가 입력되면
                    secondNum = n;
            }
        }
    }
