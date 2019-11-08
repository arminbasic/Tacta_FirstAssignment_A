using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Label l = new Label();
        List<string> list = new List<string>();
        static int result = 0;
        Label res = new Label();

      

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            list.Add(textBox1.Text);

            string text = textBox1.Text;
            l.Size = new Size(100, 100);

            int points = 0;

            if (text.Length == 3 || text.Length == 4)
            {
                points = 1;
                result = result + points;
            }
            else if (text.Length == 5)
            {
                points = 2;
                result = result + points;
            }
            else if (text.Length == 6)
            {
                points = 3;
                result = result + points;
            }
            else if (text.Length == 7)
            {
                points = 5;
                result = result + points;
            }
            else if (text.Length >= 8)
            {
                points = 11;
                result = result + points;
            }


            l.Text += textBox1.Text +"  "+ points+ Environment.NewLine;
            textBox1.Text = string.Empty;
            panel1.Controls.Add(l);


            res.Text = "Your result is " + result;
            panel2.Controls.Add(res);

           
         

        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

            Enter.Enabled = false;

           
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            list.Clear();
            result = 0;
            l.Text = "";
            res.Text = "";
            Enter.Enabled = true;

        }
    }
}
