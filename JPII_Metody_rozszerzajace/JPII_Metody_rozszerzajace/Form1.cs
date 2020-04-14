using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPII_Metody_rozszerzajace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_2char_Uppercase_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.CharToUpperCase();
        }

        private void but_1char_Uppercase_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.FirstCharToUpperCase();
        }
    }

    public static class StringParserHelper
    {
        public static string CharToUpperCase(this string inputString)
        {
            string outputString = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                //if( i % 2 != 0 && !inputString[i].Equals(" ") )
                if (i % 2 != 0)
                {
                    outputString += inputString[i].ToString().ToUpper();
                }
                else
                {
                    outputString += inputString[i].ToString();
                }
            }
            return outputString;
        }

        public static string FirstCharToUpperCase(this string inputString)
        {
            List<string> outputString = inputString.Split(' ').ToList();
            string result = "";
            foreach (string inputChar in outputString)
            {
                string str = "";
                for (int i = 0; i < inputChar.Length; i++)
                {
                    if (i == 0)
                    {
                        str += inputChar[i].ToString().ToUpper();
                    }
                    else{
                        str += inputChar[i].ToString();
                    }
                }
                result += str + " ";
            }
            return result;
        }
    }
}
