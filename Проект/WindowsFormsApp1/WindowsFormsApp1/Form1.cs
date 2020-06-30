using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int GG1;
        int MM1;
        int DD1;
        int GG2;
        int MM2;
        int DD2;

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtB1.Text.Length == 10) && (txtB2.Text.Length == 10))
            {
                string Datap = txtB1.Text;
                string Datau = txtB2.Text;


                bool y1 = Int32.TryParse(txtB1.Text.Substring(6, 4),out GG1);
                bool m1 = Int32.TryParse(txtB1.Text.Substring(3, 2), out MM1);
                bool d1 = Int32.TryParse(txtB1.Text.Substring(0, 2), out DD1);
                bool y2 = Int32.TryParse(txtB2.Text.Substring(6, 4), out GG2);
                bool m2 = Int32.TryParse(txtB2.Text.Substring(3, 2), out MM2);
                bool d2 = Int32.TryParse(txtB2.Text.Substring(0, 2), out DD2);
                bool dot = txtB1.Text.Substring(2, 1) == ".";
                bool dot1 = txtB1.Text.Substring(5, 1) == ".";
                bool dot2 = txtB2.Text.Substring(2, 1) == ".";
                bool dot3 = txtB2.Text.Substring(5, 1) == ".";
                bool mm1 = MM1 <= 12;
                bool dd1 = DD1 <= 31;
                bool yy2 = GG2 > GG1;
                bool mm2 = MM2 <= 12;
                bool dd2 = DD2 <= 31;

                if (y1 && m1 && d1 && y2 && m2 && d2 && dot && dot1 && dot2 && dot3 && mm1 && dd1 && yy2 && mm2 && dd2 == true)
                {
                    DateTime dtStart = new DateTime(GG1, MM1, DD1);
                    DateTime dtEnd = new DateTime(GG2, MM2, DD2);

                    DateTime g = new DateTime((dtEnd - dtStart).Ticks);

                    int Years = (g.Year - 1);
                    int Monthes = (g.Month - 1);
                    int Days = (g.Day - 1);

                    dataGridView1.Rows.Add(Datap, Datau, Years, Monthes, Days);
                }
                else
                {
                    MessageBox.Show("Ошибка!"); //вызвать окно с ошибкой
                }
            }
            else
            {
                MessageBox.Show("Неверный формат!"); //вызвать сообщение об ошибке
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            int Years = 0;
            int Monthes = 0;
            int Days = 0;

            int count = dataGridView1.Rows.Count;

            for (int i = 0; i < count-1; i++)
            {
                Years += Convert.ToInt32(dataGridView1[2,i].Value);
                Monthes += Convert.ToInt32(dataGridView1[3, i].Value);
                Days += Convert.ToInt32(dataGridView1[4, i].Value);
            }

            lblYears.Text = $"Лет: {Years}";
            lblMonthes.Text = $"Месяцев: {Monthes}";
            lblDays.Text = $"Дней: {Days}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46) //цифры, клавиша BackSpace и точка а ASCII
            {
                e.Handled = true;
            }
        }

        private void txtB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46) //цифры, клавиша BackSpace и точка а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
