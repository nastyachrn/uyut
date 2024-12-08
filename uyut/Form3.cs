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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string selectedHotelRoom;
                if (radioButton1.Checked)
                {
                    selectedHotelRoom = "Выбран номер 58.";
                }
                else if (radioButton2.Checked)
                {
                    selectedHotelRoom = "Выбран номер 314.";
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите номер!");
                    return;
                }

                string hotelRoomData = $"{selectedHotelRoom}";

                using (StreamWriter writer = new StreamWriter("selectedhotelroom.txt", true))
                {
                    writer.WriteLine(hotelRoomData);
                }
            }
            Form2 f = new Form2();
            f.ShowDialog(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
