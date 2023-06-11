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
    public partial class Hack : Form
    {
        private Form1 form1;


        public Hack(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }
        
        
        private void Hack_Load(object sender, EventArgs e)
        {
            labelstatus.Text = form1.lblStatus.Text.ToString();
            labelpoint.Text = form1.lblPoint.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            double chance = 0.60; 
            double randomValue = random.NextDouble(); 

            if (randomValue < chance)
            {
                
                MessageBox.Show("Вы хакнули ГосУслуги!");
                form1.point += 1;
                form1.lblPoint.Text = form1.point.ToString();
                labelstatus.Text = form1.lblStatus.Text.ToString();
                labelpoint.Text = form1.lblPoint.Text.ToString();
            }
            else
            {
                
                MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                form1.point -= 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (form1.status == "Палец на ноге" )
            {
                Random random = new Random();
                double chance = 0.50;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Сайт школы!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 3;
                }
            }
            else if (form1.status == "Гуру")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Сайт школы!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 3;
                }
            }
            else if (form1.status == "Хакер228")
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Сайт школы!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 3;
                }
            }
            else
            {
                MessageBox.Show("Тебе нужно подкачаться");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
             if (form1.status == "Гуру")
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Хакнули банк!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 5;
                }
            }
            else if (form1.status == "Хакер228")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Хакнули банк!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 5;
                }
            }
            else
            {
                MessageBox.Show("Тебе нужно подкачаться");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
              if (form1.status == "Хакер228")
            {
                Random random = new Random();
                double chance = 0.30;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы хакнули Пентагон!");
                    form1.point += 10;
                    form1.lblPoint.Text = form1.point.ToString();
                    labelstatus.Text = form1.lblStatus.Text.ToString();
                    labelpoint.Text = form1.lblPoint.Text.ToString();
                }
                else
                {

                    MessageBox.Show("Произошла ошибка! Операция не выполнена!");
                    form1.point -= 5;
                }
            }
            else
            {
                MessageBox.Show("Тебе нужно подкачаться");
            }
        }

        private void labelpoint_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
