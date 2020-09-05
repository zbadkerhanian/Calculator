using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
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
            if(inputBox.TextLength > 0)
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
            if (equationLbl.Text.Length != 0)
            {
                inputBox.Clear();
                equationLbl.ResetText();
            }

            int pos;
            System.Reflection.PropertyInfo prop = sender.GetType().GetProperty("Text");
            String num = (String)(prop.GetValue(sender, null));
            pos = inputBox.SelectionStart;
            inputBox.Text = inputBox.Text.Insert(inputBox.SelectionStart, num);
            
            FocusInputBox(++pos);
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
}
