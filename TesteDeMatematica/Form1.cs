namespace TesteDeMatematica
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();

        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLbl.Text = addend1.ToString();
            plusRightLbl.Text = addend2.ToString();

            soma.Value = 0;

            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLbl.Text = minuend.ToString();
            minusRightLbl.Text = subtrahend.ToString();
            diferenca.Value = 0;

            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLbl.Text = multiplicand.ToString();
            timesRightLbl.Text = multiplier.ToString();
            produto.Value = 0;

            divisor = randomizer.Next(2, 11);
            int TemporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * TemporaryQuotient;
            dividedLeftLbl.Text = dividend.ToString();
            dividedRightLbl.Text = divisor.ToString();
            quociente.Value = 0;

            timeLeft = 30;
            timeLbl.Text = "30 seconds";
            timer1.Start();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startBtn.Enabled = false;
        }

        private bool CheckTheanswer()
        {
            if ((addend1 + addend2 == soma.Value)
                && (minuend - subtrahend == diferenca.Value)
                && (multiplicand * multiplier == produto.Value)
                && (dividend / divisor == quociente.Value))
                return true;
            else return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheanswer())
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startBtn.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLbl.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLbl.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time!", "Sorry!");
                soma.Value = addend1 + addend2;
                diferenca.Value = minuend - subtrahend;
                produto.Value = multiplicand * multiplier;
                quociente.Value = dividend / divisor;
                startBtn.Enabled = true;
            }
        }

        private void Answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void diferenca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timeLbl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
