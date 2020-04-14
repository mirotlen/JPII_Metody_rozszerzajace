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

        private void but_removeVolwes_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.RemoveVolwes().ToString();
        }

        private void but_wordCounter_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.WordCounter().ToString();
        }

        private void but_letterCounter_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.LetterCounter().ToString();
        }

        private void but_SentenceChecker_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.SentenceChecker().ToString();
        }

        private void but_MegaLicznik_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            textBox_output.Text = str.MegaLettersChecker().ToString();

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

        public static string RemoveVolwes(this string inputString)
        {
            const string _vowels = "aeiouyAEIOUY";
            return new string (inputString.Where((x) => !_vowels.Contains(x)).ToArray());
        }

        public static int WordCounter(this string inputString)
        {
            return inputString.Split(new char[] { ' ', '.', '?', '!', ',', ';', ':' }, 
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static  string LetterCounter(this string inputString)
        {
            string str = "";
            inputString.Split(' ').ToList().ForEach(value =>
            {
                str += value.Length + " ";
            });
            return str;
        }

        public static bool SentenceChecker (this string inputString)
        {
            if (Char.IsUpper(inputString[0]) && inputString[inputString.Length-1] == '.')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string MegaLettersChecker (this string inputString)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach(char inputChar in inputString)
            {
                if (dic.ContainsKey(inputChar))
                {
                    dic[inputChar] ++;
                }
                else
                {
                    dic.Add(inputChar, 1);
                }
            }
            string result = "";
            dic.Keys.ToList().ForEach(value => {
                int i = 0;
                if (value == ' ')
                {
                    result += "space:";
                }
                else
                {
                    result += value.ToString() + ':';
                }
                dic.TryGetValue(value, out i);
                result += i.ToString()+ ' ';
                });
            return result;
        }

    }
}
