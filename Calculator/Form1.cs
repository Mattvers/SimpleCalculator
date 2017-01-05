using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0.0;  //operation score;
        double lastValue = 0.0;   //  last value you have in operation
        string operationPerformed = ""; //operation text to show in calculator;
        bool isOperationPerformed = false; // bool value that means if +,-,*,/ was clicked;      

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that alows you to write a number (witch buttons) in correct order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {          
            Button button = (Button)sender;

            if ((textBoxOperationResult.Text == "0" && button.Text != ",") || isOperationPerformed)
                textBoxOperationResult.Clear();
            isOperationPerformed = false;

            if (button.Text == ",")
            {
                if (!textBoxOperationResult.Text.Contains(","))
                    textBoxOperationResult.Text = textBoxOperationResult.Text + button.Text;
            }
            else                     
                textBoxOperationResult.Text = textBoxOperationResult.Text + button.Text;
        }

        /// <summary>
        /// Event that alows to click +,-,*,/ and doing operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


                                               
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBoxOperationResult.Text);                          
            
            labelText.Text = resultValue + " " + operationPerformed + " ";
             
            isOperationPerformed = true;

        }

        /// <summary>
        /// It is a function that starting if you press C or CE button. It's clear a textBoxOperationResult and show a text 0 to user;
        /// </summary>
        /// <param name="sender"> Button, it means the text of button (C or CE)</param>
        /// <param name="e"></param>
        private void clear_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBoxOperationResult.Text = "0";
            labelText.Text = "";
            if (button.Text == "C")                           
                resultValue = 0;     
            
                 
        }
        /// <summary>
        /// Action witch takes a char +,-,*,/  and presenting on textBox a final value of current operation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRESULT_Click(object sender, EventArgs e)
        {       
            switch (operationPerformed)
            {
                
                case "+":
                    lastValue = Double.Parse(textBoxOperationResult.Text);
                    textBoxOperationResult.Text = (resultValue + lastValue).ToString();
                    break;
                case "-":
                    lastValue = Double.Parse(textBoxOperationResult.Text);
                    textBoxOperationResult.Text = (resultValue - lastValue).ToString();
                    break;
                case "*":
                    lastValue = Double.Parse(textBoxOperationResult.Text);
                    textBoxOperationResult.Text = (resultValue * lastValue).ToString();
                    break;
                case "/":
                    lastValue = Double.Parse(textBoxOperationResult.Text);
                    if (lastValue != 0)
                        textBoxOperationResult.Text = (resultValue / lastValue).ToString();
                    else
                        textBoxOperationResult.Text = "blad";
                    break;
                default:
                    break;
            }          
            resultValue = Double.Parse(textBoxOperationResult.Text);           
            labelText.Text = "";
        }
    }
}
