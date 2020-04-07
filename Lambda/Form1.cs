using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lambda
{
    public partial class Form1 : Form
    {
        private List<int> listOfNumber;
        public Form1()
        {
            InitializeComponent();
            listOfNumber = GenerateNumbers(10);

        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int basic = int.Parse(a.Text);
            int index = int.Parse(n.Text);
            Func<int, int, double> increase = (x, n) => Math.Pow(x, n);
            result.Text = increase(basic, index).ToString();
        }
        List<int> GenerateNumbers(int n)
        {
            List<int> numbers = new List<int>(n);
            int x;
            for (int i = 0; i <n; i++)
            {
                x = random.Next(0, 10);
                numbers.Add(x);
                l_numbers.Text += x + " ";
            }
            return numbers;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Func<string> pasteString = () =>s1.Text + s2.Text;
            resultString.Text = pasteString();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {

            Func<int, string> stringNumber = (int amount) =>
            {
                string stringChars = "";
                char c = '_';
                for (int i = 0; i < amount; i++)
                {
                    c = (char)random.Next(33, 123);
                    stringChars += c;
                }
                return stringChars;
            };
            int n = 0;
            try
            {
                n = int.Parse(n_.Text);
            }
            catch (FormatException) { }

            stringSign.Text = stringNumber(n);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<int> sortedlist;
            if (priority.Checked)
            {
                var even = listOfNumber.Where(num => (num % 2) == 0).OrderBy(num => num).ToList();
                var odd = listOfNumber.Where(num => (num % 2) == 1).OrderBy(num=>num).ToList();

                l_numbers.Text = "";
                foreach (int n in even) l_numbers.Text += n + " ";
                foreach (int n in odd) l_numbers.Text += n + " ";
            }
            else
            {
                if (ascending.Checked)
                {
                    l_numbers.Text = "";
                    sortedlist = listOfNumber.OrderBy(number => number).ToList();
                    foreach (int s in sortedlist) l_numbers.Text += s + " ";
                }
                else
                {
                    l_numbers.Text = "";
                    sortedlist = listOfNumber.OrderByDescending(number => number).ToList();
                    foreach (int s in sortedlist) l_numbers.Text += s + " ";
                }
            }
        }
    }
}
