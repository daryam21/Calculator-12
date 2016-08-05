using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()  // Initialize the calculator application
        {
            InitializeComponent();
        }

        // variables used
        float num, ans;
        int count;

        #region Methods
        public void disable()   // Diasable function that turns off the calculator
                                // It makes the Enable button visible and the only one that may be pressed
        {
            textBox1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Show();
            button19.Hide();
            ON.Enabled = false;
        }

        public void enable()    // Enable function that turns on the calculator
                                // It makes the Disable button visible and all other buttons may be used
        {
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Hide();
            button19.Show();
            ON.Enabled = true;
        }

        public void compute()   // Performes the desired operation (addition, substraction, multiplication and division)
                                // by using a switch statement that is accessed through the respective buttons
        {
            switch (count)  // switch statement
            {
                case 1: // addition
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 2: // substraction
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 3: // multiplication
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4: // division
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                default:
                    break;
            }
        }

        #endregion

        #region Buttons
        private void button18_Click(object sender, EventArgs e) // Enable button - enables the calculator by calling the enable method
        {
            enable();
        }

        private void button19_Click(object sender, EventArgs e) // Disable button - disables the calculator by calling the disable method
        {
            disable();
        }
        
        private void Form1_Load(object sender, EventArgs e) // Load form1 box (displays information in the left side of the screen
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)   // Load Text box (main text box)
        {
        
        }
                
        private void button15_Click(object sender, EventArgs e)  // Decimal point button - adds a decimal point
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)  // Digit 0 button
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Red;
        }

        private void ON_Click(object sender, EventArgs e)  // Digit 1 button
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Red;
        }

        private void button1_Click_1(object sender, EventArgs e)  // Digit 2 button
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Red;
        }
        private void button2_Click(object sender, EventArgs e)  // Digit 3 button
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Red;
        }
        private void button7_Click(object sender, EventArgs e)  // Digit 4 button
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)  // Digit 5 button
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)  // Digit 6 button
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)  // Digit 7 button
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)  // Digit 8 button
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)  // Digit 9 button
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e) // Addition button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }

        private void button3_Click(object sender, EventArgs e) // Substraction button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button4_Click(object sender, EventArgs e) // Multiplication button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button8_Click(object sender, EventArgs e) // Division button
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button13_Click(object sender, EventArgs e) // Clear button
        {
            textBox1.Text = ""; // clears the text box
        }

        private void button17_Click(object sender, EventArgs e) // Backspace button
        {
            int length = textBox1.TextLength - 1;   // determine the length of the text box after removal
            textBox1.Text = textBox1.Text.Remove(length, 1);    // remove the last character - easy to do as information is displayed as string
        }

        private void button14_Click(object sender, EventArgs e) // Result button - shows the result of the current calculation
        {
            compute();  // Calls compute method
            label1.Text = "";   // Clears left side of display
        }
        #endregion
    }
}
