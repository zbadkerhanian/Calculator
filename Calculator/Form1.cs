using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);


        private double runningResult = 0;

        private enum OperationType
        {
            Add,
            Minus,
            Multiply,
            Divide
        }


        private List<Result> results = new List<Result>();

        public Form1()
        {
            InitializeComponent();
            ActiveControl = inputBox;


            //HideCaret();



        }

        public void HideCaret()
        {
            HideCaret(inputBox.Handle);
        }


        #region Operations

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                //divide input value by 100
                double answer = Convert.ToDouble(inputBox.Text) / 100;
                //MessageBox.Show(answer.ToString());

                //write equation in top box
                equationLbl.Text = inputBox.Text + "%";
                //write answer in input box
                inputBox.Text = answer.ToString();

            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            //FocusInputBox();
        }

        private void clearAllBtn_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            equationLbl.ResetText();
            //FocusInputBox();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int pos;
            pos = inputBox.SelectionStart;

            if (inputBox.Text.Length > 0)
                inputBox.Text = inputBox.Text.Remove(inputBox.SelectionStart - 1, 1);

            FocusInputBox(--pos);

        }

        private void oneOverBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                //check to see if there is another operator
                if (inputBox.Text.Contains(" "))
                {
                    //get last number in string
                    int index = inputBox.Text.LastIndexOf(' ');
                    string numSubstr = inputBox.Text.Substring(index);
                    string restOfStr = inputBox.Text.Substring(0, index);
                    //get answer 
                    double answer = 1 / Convert.ToDouble(numSubstr);
                    //MessageBox.Show(answer.ToString());

                    //write equation in top box
                    equationLbl.Text += restOfStr + "1/(" + numSubstr + ")";
                    //write answer in input box
                    inputBox.Text = answer.ToString();
                }
                else // only one number, so perform operation and done
                {
                    //get answer 
                    double answer = 1 / Convert.ToDouble(inputBox.Text);
                    //MessageBox.Show(answer.ToString());

                    //write equation in top box
                    equationLbl.Text += "1/(" + inputBox.Text + ")";
                    //write answer in input box
                    inputBox.Text = answer.ToString();
                }


            }
        }

        private void squaredBtn_Click(object sender, EventArgs e)
        {

        }

        private void sqrRootBtn_Click(object sender, EventArgs e)
        {

        }

        private void divideBtn_Click(object sender, EventArgs e)
        {

        }

        private void timesBtn_Click(object sender, EventArgs e)
        {

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {

        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            //find what operator was clicked
            //search through equation label
            bool hasOp = false;
            foreach (char x in equationLbl.Text)
            {
                if ("+−×÷".Any(c => c == x))
                {
                    hasOp = true;
                }
            }
            if (hasOp)
            {
                char op = equationLbl.Text[equationLbl.Text.Length - 2];
                switch (op)
                {

                    case '+':
                        runningResult = runningResult + Convert.ToDouble(inputBox.Text);
                        break;
                    case '−':
                        runningResult = runningResult - Convert.ToDouble(inputBox.Text);
                        break;
                    case '×':
                        runningResult = runningResult * Convert.ToDouble(inputBox.Text);
                        break;
                    case '÷':
                        runningResult = runningResult / Convert.ToDouble(inputBox.Text);
                        break;
                    default:
                        break;
                }
                //MessageBox.Show("" + runningResult);

                equationLbl.Text += inputBox.Text + " =";
                
                inputBox.Text = runningResult.ToString();

            }
            else
            {
                equationLbl.Text += inputBox.Text + " =";
            }

            results.Add(new Result(equationLbl.Text, inputBox.Text));

            FocusInputBox(inputBox.Text.Length);

        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {

        }

        private void posnegBtn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void numBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.CompareTo(runningResult.ToString()) == 0)
            {
                inputBox.Clear();
            }
            int eqLength = equationLbl.Text.Length;
            if (eqLength > 0 && equationLbl.Text[equationLbl.Text.Length - 1] == '=')
            {
                inputBox.Clear();
                equationLbl.ResetText();
                runningResult = 0;
            }
            int pos;
            System.Reflection.PropertyInfo prop = sender.GetType().GetProperty("Text");
            String num = (String)(prop.GetValue(sender, null));

            pos = inputBox.SelectionStart;
            inputBox.Text = inputBox.Text.Insert(inputBox.SelectionStart, num);

            FocusInputBox(++pos);
        }

        private void operatorBtn_Click(object sender, EventArgs e)
        {
            int pos = 0;
            //if (
            //    equationLbl.Text.Length > 3 &&
            //    (equationLbl.Text[equationLbl.Text.Length - 2] == '+'
            //    || equationLbl.Text[equationLbl.Text.Length - 2] == '−'
            //    || equationLbl.Text[equationLbl.Text.Length - 2] == '×'
            //    || equationLbl.Text[equationLbl.Text.Length - 2] == '÷'))
            //{
            //    equationLbl.Text.Remove(equationLbl.Text[equationLbl.Text.Length - 3]);
            //}
            if (inputBox.TextLength > 0)
            {

                
                if(equationLbl.Text.Length > 0)
                {
                    char opChar = equationLbl.Text[equationLbl.Text.Length - 2];
                    switch (opChar)
                    {

                        case '+':
                            runningResult = runningResult + Convert.ToDouble(inputBox.Text);
                            break;
                        case '−':
                            runningResult = runningResult - Convert.ToDouble(inputBox.Text);
                            break;
                        case '×':
                            runningResult = runningResult * Convert.ToDouble(inputBox.Text);
                            break;
                        case '÷':
                            runningResult = runningResult / Convert.ToDouble(inputBox.Text);
                            break;
                        default:
                            break;
                    }
                }
                else if(inputBox.TextLength > 0)
                    runningResult = Convert.ToDouble(inputBox.Text);

                
                System.Reflection.PropertyInfo prop = sender.GetType().GetProperty("Text");
                String op = (String)(prop.GetValue(sender, null));
                pos = inputBox.SelectionStart;
                //inputBox.Text = inputBox.Text.Insert(inputBox.SelectionStart, num);
                //equationLbl.Text = inputBox.Text.Insert(inputBox.SelectionStart, num);
                if (equationLbl.Text.Contains('='))
                    equationLbl.Text = inputBox.Text + op;
                else
                    equationLbl.Text += inputBox.Text + op;
                //equationLbl.Text += inputBox.Text + op;
                //inputBox.Clear();
                    inputBox.Text = runningResult.ToString();
                    //solveEquation();
            }

            FocusInputBox(pos + 3);
        }

        private void solveEquation()
        {
            inputBox.Text = runningResult.ToString();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                zeroBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                oneBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                twoBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                threeBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                fourBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                fiveBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                sixBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                sevenBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                eightBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                nineBtn.PerformClick();
            }

        }


        #region Helpers

        private void FocusInputBox(int pos)
        {
            inputBox.Focus();
            inputBox.SelectionStart = pos;
            inputBox.SelectionLength = 0;
        }
        #endregion

    }

    public class Result
    {
        public Result(string _equation, string _answer)
        {
            equation = _equation;
            answer = _answer;
        }
        public string equation { get; set; }
        public string answer { get; set; }
    }
}
