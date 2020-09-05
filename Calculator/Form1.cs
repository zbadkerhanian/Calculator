using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double runningResult = 0;
        private List<Result> results = new List<Result>();

        public Form1()
        {
            InitializeComponent();
            ActiveControl = inputBox;
        }

        #region Operations

        private void percentBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                //divide input value by 100
                double answer = Convert.ToDouble(inputBox.Text) / 100;

                //check to see if there is another operator
                if (equationLbl.Text.Contains(" ") && !equationLbl.Text.Contains("="))
                {
                    if (equationLbl.Text.Length > 0)
                    {
                        performOperation(answer);
                    }

                    //write equation in top box
                    equationLbl.Text += inputBox.Text + "%";
                }
                else // only one number, so perform operation and done
                {
                    runningResult = answer;

                    //write equation in top box
                    equationLbl.Text = inputBox.Text + "%";

                }
                //write answer in input box
                inputBox.Text = runningResult.ToString();

            }

            FocusInputBox(inputBox.Text.Length);
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
                double answer = 1 / Convert.ToDouble(inputBox.Text);
                //check to see if there is another operator
                if (equationLbl.Text.Contains(" ") && !equationLbl.Text.Contains("="))
                {
                    if (equationLbl.Text.Length > 0)
                    {
                        performOperation(answer);
                    }
                    
                    //write equation in top box
                    equationLbl.Text += "1/(" + inputBox.Text + ")";
                }
                else // only one number, so perform operation and done
                {
                    runningResult = answer;

                    //write equation in top box
                    equationLbl.Text = "1/(" + inputBox.Text + ")";
                    
                }
                //write answer in input box
                inputBox.Text = runningResult.ToString();

            }

            FocusInputBox(inputBox.Text.Length);
        }

        private void performOperation(double value)
        {
            
            char opChar = equationLbl.Text[equationLbl.Text.Length - 2];
            switch (opChar)
            {
                case '+':
                    runningResult = runningResult + value;
                    break;
                case '−':
                    runningResult = runningResult - value;
                    break;
                case '×':
                    runningResult = runningResult * value;
                    break;
                case '÷':
                    runningResult = runningResult / value;
                    break;
                default:
                    break;
            }
            
        }

        private void squaredBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                double answer = Math.Pow(Convert.ToDouble(inputBox.Text), 2);
                //check to see if there is another operator
                if (equationLbl.Text.Contains(" ") && !equationLbl.Text.Contains("="))
                {
                    if (equationLbl.Text.Length > 0)
                    {
                        performOperation(answer);
                    }

                    //write equation in top box
                    equationLbl.Text += inputBox.Text + "^2";
                }
                else // only one number, so perform operation and done
                {
                    runningResult = answer;

                    //write equation in top box
                    equationLbl.Text = inputBox.Text + "^2";

                }
                //write answer in input box
                inputBox.Text = runningResult.ToString();

            }

            FocusInputBox(inputBox.Text.Length);
        }

        private void sqrRootBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                double answer = Math.Sqrt(Convert.ToDouble(inputBox.Text));
                //check to see if there is another operator
                if (equationLbl.Text.Contains(" ") && !equationLbl.Text.Contains("="))
                {
                    if (equationLbl.Text.Length > 0)
                    {
                        performOperation(answer);
                    }

                    //write equation in top box
                    equationLbl.Text += "√(" + inputBox.Text + ")";
                }
                else // only one number, so perform operation and done
                {
                    runningResult = answer;

                    //write equation in top box
                    equationLbl.Text = "√(" + inputBox.Text + ")";

                }
                //write answer in input box
                inputBox.Text = runningResult.ToString();

            }

            FocusInputBox(inputBox.Text.Length);
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
                performOperation(Convert.ToDouble(inputBox.Text));
                //MessageBox.Show("" + runningResult);

                //equationLbl.Text += inputBox.Text + " =";
                if (equationLbl.Text.Contains('='))
                    equationLbl.Text = inputBox.Text + " =";
                else if (equationLbl.Text.EndsWith(')') || equationLbl.Text.EndsWith('%') || (equationLbl.Text.Length > 1 && equationLbl.Text[equationLbl.Text.Length - 2] == '^'))
                    equationLbl.Text += " =";
                else
                    equationLbl.Text += inputBox.Text + " =";
                inputBox.Text = runningResult.ToString();

            }
            else if(inputBox.TextLength > 0)
            {
                if (equationLbl.Text.Contains('='))
                    equationLbl.Text = inputBox.Text + " =";
                else if (equationLbl.Text.EndsWith(')') || equationLbl.Text.EndsWith('%') || (equationLbl.Text.Length > 1 && equationLbl.Text[equationLbl.Text.Length - 2] == '^'))
                    equationLbl.Text += " =";
                else
                    equationLbl.Text += inputBox.Text + " =";
            }

            bool dupl = false;
            foreach (Result res in results)
            {
                if (res.expression == equationLbl.Text)
                    dupl = true;
            }
            
            if(!dupl)
                results.Add(new Result(equationLbl.Text, inputBox.Text));

            FocusInputBox(inputBox.Text.Length);

        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {

        }

        private void posnegBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.TextLength > 0)
            {
                double answer = -1 * Convert.ToDouble(inputBox.Text);
                //check to see if there is another operator
                if (equationLbl.Text.Contains(" ") && !equationLbl.Text.Contains("="))
                {
                    if (equationLbl.Text.Length > 0)
                    {
                        performOperation(answer);
                    }

                    //write equation in top box
                    equationLbl.Text += "-" + inputBox.Text;
                }
                else // only one number, so perform operation and done
                {
                    runningResult = answer;

                    //write equation in top box
                    equationLbl.Text = "-" + inputBox.Text;

                }
                //write answer in input box
                inputBox.Text = runningResult.ToString();

            }

            FocusInputBox(inputBox.Text.Length);
        }

        #endregion

        private void numBtn_Click(object sender, EventArgs e)
        {
            int pos = inputBox.Text.Length;
            System.Reflection.PropertyInfo prop = sender.GetType().GetProperty("Text");
            String num = (String)(prop.GetValue(sender, null));
            if(num.CompareTo(".") != 0 || (!inputBox.Text.Contains(".") && inputBox.Text.Length > 0))
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


                pos = inputBox.SelectionStart;
                inputBox.Text = inputBox.Text.Insert(inputBox.SelectionStart, num);

            }

            FocusInputBox(++pos);
        }

        private void operatorBtn_Click(object sender, EventArgs e)
        {
            int pos = 0;
            if (inputBox.TextLength > 0)
            {

                
                if(equationLbl.Text.Length > 0 &&
                    
                    (equationLbl.Text[equationLbl.Text.Length - 2] == '+'
                || equationLbl.Text[equationLbl.Text.Length - 2] == '−'
                || equationLbl.Text[equationLbl.Text.Length - 2] == '×'
                || equationLbl.Text[equationLbl.Text.Length - 2] == '÷'))
                {
                    performOperation(Convert.ToDouble(inputBox.Text));
                }
                else if(inputBox.TextLength > 0)
                    runningResult = Convert.ToDouble(inputBox.Text);

                
                System.Reflection.PropertyInfo prop = sender.GetType().GetProperty("Text");
                String op = (String)(prop.GetValue(sender, null));
                pos = inputBox.SelectionStart;
                
                if (equationLbl.Text.Contains('='))
                    equationLbl.Text = inputBox.Text + op;
                else if (equationLbl.Text.Length > 1 && (equationLbl.Text.EndsWith(')') || equationLbl.Text[equationLbl.Text.Length - 2] == '^'))
                    equationLbl.Text += op;
                else
                    equationLbl.Text += inputBox.Text + op;

                
                inputBox.Text = runningResult.ToString();
            }

            FocusInputBox(pos + 3);
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
            else if (e.KeyCode == Keys.Back)
            {
                deleteBtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Return)
            {
                equalsBtn.PerformClick();
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

        private void histBtn_Click(object sender, EventArgs e)
        {
            string resultsStr = "";
            foreach(Result res in results)
            {
                resultsStr += res.expression + " " + res.answer + "\n\n";
            }
            MessageBox.Show(resultsStr);
        }
    }

    public class Result
    {
        public Result(string _expression, string _answer)
        {
            expression = _expression;
            answer = _answer;
        }
        public string expression { get; set; }
        public string answer { get; set; }
    }
}
