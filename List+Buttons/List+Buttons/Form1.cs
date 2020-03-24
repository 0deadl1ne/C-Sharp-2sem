using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Buttons
{
    public partial class Form1 : Form
    {
        List<string> names = new List<string>();
        int k = 0;
        Random r = new Random();
        bool VIS = false;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e) //Видалити
        {
            comboBox1.Items.Remove(names[k-1]);
            k--;
        }

        private void Button1_Click(object sender, EventArgs e) //Додати
        {
            string namestr = textBox1.Text;
            comboBox1.Items.Add(namestr);
            names.Add(namestr);
            k++;
            textBox1.Text = "";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e) //1
        {
           button3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e) //2
        {

        }

        private void button4_Click(object sender, EventArgs e) //3
        {

        }

        private void button18_Click(object sender, EventArgs e) //4
        {

        }

        private void button8_Click(object sender, EventArgs e) //5
        {

        }

        private void button11_Click(object sender, EventArgs e) //6
        {

        }

        private void button6_Click(object sender, EventArgs e) //7
        {

        }

        private void button12_Click(object sender, EventArgs e) //8
        {

        }

        private void button17_Click(object sender, EventArgs e) //9
        {

        }

        private void button16_Click(object sender, EventArgs e) //10
        {

        }

        private void button10_Click(object sender, EventArgs e) //11
        {

        }

        private void button14_Click(object sender, EventArgs e) //12
        {

        }

        private void button5_Click(object sender, EventArgs e) //13
        {

        }

        private void button9_Click(object sender, EventArgs e) //14
        {

        }

        private void button15_Click(object sender, EventArgs e) //15
        {

        }

        private void button13_Click(object sender, EventArgs e) //16
        {

        }
    }
}
