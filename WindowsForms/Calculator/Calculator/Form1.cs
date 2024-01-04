﻿using System;
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
        List<Button> buttons = new List<Button>();
        private string input = "";
        public Form1()
        {
            InitializeComponent();
            KeyDown += OnKeyPressed ;
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons.Add(btClear);
            buttons.Add(btBackSlash);
            buttons.Add(btOpenBrace);
            buttons.Add(btCloseBrace);
            buttons.Add(btMod);
            buttons.Add(btPower);
            buttons.Add(btOpenBrace);
            buttons.Add(btCloseBrace);
            buttons.Add(bt7);
            buttons.Add(bt8);
            buttons.Add(bt9);
            buttons.Add(btAdd);
            buttons.Add(bt4);
            buttons.Add(bt5);
            buttons.Add(bt6);
            buttons.Add(btSub);
            buttons.Add(bt1);
            buttons.Add(bt2);
            buttons.Add(bt3);
            buttons.Add(btMul);
            buttons.Add(btDot);
            buttons.Add(bt0);
            buttons.Add(btEquals);
            buttons.Add(btDiv);
            OnFormResized(sender, e);
        }

        private void OnButtonPanelResized(object sender, EventArgs e)
        {
            
        }
        private void OnFormResized(object sender, EventArgs e)
        {
            int formHeight = ClientSize.Height;
            int displayPanelHeight = (int)(formHeight * 0.2);
            int buttonPanelHeight = formHeight - displayPanelHeight;

            displayPanel.Size = new Size(ClientSize.Width, displayPanelHeight);
            buttonPanel.Size = new Size(ClientSize.Width, buttonPanelHeight);
            buttonPanel.Location = new Point(0, displayPanelHeight);

            float buttonFontSize = (float)(formHeight * 0.028);
            float displayFontSize = (float)(formHeight * 0.06);
            Font newButtonFont = new Font("Xenara", buttonFontSize, FontStyle.Bold);
            Font newDisplayFont = new Font("Xenara", displayFontSize, FontStyle.Bold);

            int buttonWidth = buttonPanel.Width / 4;
            int buttonHeight = buttonPanel.Height / 6;
            int count = 0, distance = 0;
            foreach (Button button in buttons)
            {
                button.Font = newButtonFont;
                if (count < 2)
                {
                    button.Size = new Size(buttonWidth * 2, buttonHeight);
                    button.Location = new Point((count % 4) * (buttonWidth * 2 + distance), (count / 4) * (buttonHeight + distance));
                }
                else
                {
                    button.Size = new Size(buttonWidth, buttonHeight);
                    button.Location = new Point((count % 4) * (buttonWidth + distance), (count / 4) * (buttonHeight + distance));
                }
                count++;
            }
            displayBox.Font = newDisplayFont;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            displayBox.Text = input;
        }
        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            displayBox.Text = "";
            input = "";
        }
        private void OnBackslashButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input))
            {
                input = input.Substring(0, input.Length - 1);
                displayBox.Text = input;
            }
        }

        private void OnEqualsButtonClicked(object sender, EventArgs e)
        {
            try
            { 
                var result = EvaluateExpressionWithBrackets(input);
                displayBox.Text = result.ToString();
                input = result.ToString();
            }
            catch (Exception ex)
            {
                displayBox.Text = "Error";
                input = "";
            }
        }
        private double EvaluateExpressionWithBrackets(string expression)
        {
            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentChar = expression[i];

                if (char.IsDigit(currentChar) || currentChar == '.')
                {
                    StringBuilder numberBuilder = new StringBuilder();
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                    {
                        numberBuilder.Append(expression[i]);
                        i++;
                    }
                    i--; // Move back one position after parsing the number
                    double number = double.Parse(numberBuilder.ToString());
                    numbers.Push(number);
                }
                else if (currentChar == '(')
                {
                    operators.Push(currentChar);
                }
                else if (currentChar == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        double operand2 = numbers.Pop();
                        double operand1 = numbers.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(operand1, operand2, op);
                        numbers.Push(result);
                    }

                    operators.Pop(); // Pop the remaining '('
                }
                else if (IsOperator(currentChar))
                {
                    while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(currentChar))
                    {
                        double operand2 = numbers.Pop();
                        double operand1 = numbers.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(operand1, operand2, op);
                        numbers.Push(result);
                    }

                    operators.Push(currentChar);
                }
                else if (currentChar == '-')
                {
                    // Handle unary minus
                    if (i == 0 || expression[i - 1] == '(')
                    {
                        operators.Push('~'); // '~' is used to represent unary minus
                    }
                    else
                    {
                        // Regular subtraction
                        while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(currentChar))
                        {
                            double operand2 = numbers.Pop();
                            double operand1 = numbers.Pop();
                            char op = operators.Pop();
                            double result = ApplyOperator(operand1, operand2, op);
                            numbers.Push(result);
                        }

                        operators.Push(currentChar);
                    }
                }
            }

            while (operators.Count > 0)
            {
                double operand2 = numbers.Pop();
                double operand1 = numbers.Pop();
                char op = operators.Pop();
                double result = ApplyOperator(operand1, operand2, op);
                numbers.Push(result);
            }

            return numbers.Pop();
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        private int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;
            }
        }

        private double ApplyOperator(double operand1, double operand2, char op)
        {
            switch (op)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':
                    if (operand2 != 0)
                    {
                        return operand1 / operand2;
                    }
                    else
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                default:
                    throw new ArgumentException($"Unsupported operator: {op}");
            }
        }

        private void displayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void displayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnKeyPressed(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || e.KeyCode == Keys.Decimal)
            {
                input += e.KeyCode.ToString().Last();
                displayBox.Text = input;
            }
        }
    }
}
