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

        //public static string FirstCharToUpperCase (this string inputString)
        //{

        //}
    }
}
