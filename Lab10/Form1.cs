using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private string firstValue = "";
        private string secondValue = "";
        private string operation;
        private bool newNumber = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void OneButton_Click(object sender, EventArgs e)
        {
            firstValue += 1;
            UpdateDisplay();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            firstValue += 2;
            UpdateDisplay();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            firstValue += 3;
            UpdateDisplay();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            firstValue += 4;
            UpdateDisplay();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            firstValue += 5;
            UpdateDisplay();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            firstValue += 6;
            UpdateDisplay();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            firstValue += 7;
            UpdateDisplay();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            firstValue += 8;
            UpdateDisplay();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            firstValue += 9;
            UpdateDisplay();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            firstValue += 0;
            UpdateDisplay();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            StartSecondNumber();
            operation = "plus";
            newNumber = false;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            StartSecondNumber();
            operation = "minus";
            newNumber = false;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            StartSecondNumber();
            operation = "multiply";
            newNumber = false;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            StartSecondNumber();
            operation = "divide";
            newNumber = false;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (firstValue == "")
            {
                firstValue += 0;
            }
            if (secondValue == "")
            {
                secondValue += 0;
            }
            
            decimal result;
            string stringResult = "";
            switch (operation)
            {
                case "plus":
                    result = int.Parse(secondValue) + int.Parse(firstValue);
                    stringResult = "" + result;
                    firstValue = stringResult;
                    break;
                case "minus":
                    result = int.Parse(secondValue) - int.Parse(firstValue);
                    stringResult = "" + result;
                    firstValue = stringResult;
                    break;
                case "multiply":
                    result = int.Parse(secondValue) * int.Parse(firstValue);
                    stringResult = "" + result;
                    firstValue = stringResult;
                    break;
                case "divide":
                    try
                    {
                        result = decimal.Parse(secondValue) / decimal.Parse(firstValue);
                        stringResult = "" + result;
                        firstValue = stringResult;
                    }
                    catch (DivideByZeroException exception)
                    {
                        stringResult = "ERROR: DIVIDE BY ZERO";
                        firstValue = "";
                    }
                    break;
                default:
                    stringResult = firstValue;
                    break;
            }

            secondValue =  "";
            TextBox.Text = "" + stringResult;
            newNumber = true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstValue = "";
            secondValue = "";
            TextBox.Text = "";
        }

        private void UpdateDisplay()
        {
            if (newNumber)
            {
                firstValue = "" + firstValue.Last();
                newNumber = false;
            }

            TextBox.Text = firstValue;
            
        }

        private void StartSecondNumber()
        {
            secondValue = firstValue;
            firstValue = "";
        }
    }
}
