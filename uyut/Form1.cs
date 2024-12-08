using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string FIO = textBox1.Text;
                string numberPhone = textBox2.Text;
                string startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                string kolvoAdults = textBox3.Text;
                string kolvoChildes = textBox4.Text;
                string selectedPitaniya = string.Empty;
                if (radioButton1.Checked)
                {
                    selectedPitaniya = "Только завтраки";
                }
                else if (radioButton2.Checked)
                {
                    selectedPitaniya = "Шведский стол";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите один из вариантов питания.");
                    return;
                }
                using (StreamWriter writer = new StreamWriter("registraciya.txt", true))
                {
                    string registraciyaData = $"{FIO};{numberPhone}; {startDate}; {endDate}; {kolvoAdults}; {kolvoChildes}; {selectedPitaniya}";
                    writer.WriteLine(registraciyaData);
                }
                Form3 f = new Form3();
                f.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
