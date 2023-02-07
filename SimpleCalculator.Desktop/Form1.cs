using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Business;
using System.Windows.Forms;

namespace SimpleCalculator.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Solver.Solve(int.Parse(textBox1.Text),int.Parse(textBox2.Text));
            MessageBox.Show($"{textBox1.Text} + {textBox2.Text} = {sum}");
        }
    }
}
