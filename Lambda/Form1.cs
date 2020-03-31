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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basic = int.Parse(a.Text);
            int index = int.Parse(n.Text);
            Func<int, int, int> increase = (x, n) => (int)Math.Pow(x, n);
            result.Text = increase(basic, index).ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Func<string> pasteString = () =>s1.Text + s2.Text;
            resultString.Text = pasteString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Func<int, int>[] increase = new Func<int, int>[10];
            int[] index = new int[increase.Length];
            for (int i = 0; i <increase.Length; i++)
            {
                index[i] = i;
            }
            for (int i = 0; i < increase.Length; i++)
            {
               increase[i] = (int x) => {
                    int n = i;
                    return (int)Math.Pow(x, n);
                };
            }
           resultArray.Text = increase[int.Parse(x.Text)](int.Parse(x.Text)).ToString();
        }
    }
}
