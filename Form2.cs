using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniProject
{
    public partial class Form2 : Form
    {
        private double price = 0;
        public Form2()
        {
            InitializeComponent();
            this.Text = "Оформление заказа";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    price = 4;
                    break;
                case 1:
                    price = 8;
                    break;
                case 2:
                    price = 14;
                    break;
                default:
                    price = 0;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы выбрали вариант {comboBox1.SelectedItem}, его стоимость составляет {price:C}");
            this.Close();
        }
    }
}
