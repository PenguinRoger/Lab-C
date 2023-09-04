using System;
using System.Windows.Forms;

namespace Lab5.Lab_5_Class
{
    public static class Validator
    {
        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            if (decimal.TryParse(textBox.Text, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInt32(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out _))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer.", Title);
                textBox.Focus();
                return false;
            }
        }

        public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
        {
            decimal number;
            if (decimal.TryParse(textBox.Text, out number) && (number < min || number > max))
            {
                MessageBox.Show(textBox.Tag + " must be between " + min + " and " + max + ".", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 || textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show(textBox.Tag + " must be a valid email address.", Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
