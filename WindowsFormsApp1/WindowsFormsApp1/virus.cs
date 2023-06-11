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
    public partial class virus : Form
    {
        private Form1 form1;


        public virus(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form1.softlvl == 1)
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Убили вирус!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,но вы ничего не теряете");
                    
                }
            }



           else if (form1.status == "Палец на ноге")
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Убили вирус!");
                    form1.point += 3;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 3");
                    form1.point -= 3;
                    form1.lblPoint.Text = form1.point.ToString();

                }
            }
            else if (form1.status == "Гуру")
            {
                Random random = new Random();
                double chance = 0.80;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Убили вирус!");
                    form1.point += 2;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 7 и уровень софта снижен на 1");
                    form1.point -= 7;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            else if (form1.status == "Хакер228")
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Убили вирус!");
                    form1.point += 1;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 9 и уровень софта снижен на 1");
                    form1.point -= 9;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form1.softlvl == 1)
            {
                Random random = new Random();
                double chance = 0.90;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вирус был успешно проигнорирован!");
                    form1.point += 5;
                    form1.lblPoint.Text = form1.point.ToString();

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,но вы ничего не теряете");

                }

            }



            else if (form1.softlvl==2)
            {
                Random random = new Random();
                double chance = 0.60;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Успешно проигнорировали вирус!");
                    

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 3");
                    form1.point -= 3;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            else if (form1.softlvl ==3)
            {
                Random random = new Random();
                double chance = 0.40;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы Успешно проигнорировали вирус!");
                    

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 7 и уровень софта снижен на 1");
                    form1.point -= 7;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();


                }
            }
            else if (form1.softlvl ==4)
            {
                Random random = new Random();
                double chance = 0.20;
                double randomValue = random.NextDouble();

                if (randomValue < chance)
                {

                    MessageBox.Show("Вы успешно проигнорировали вирус");
                   

                }
                else
                {

                    MessageBox.Show("Вы не справились с вирусом,ваши очки уменьшены на 9 и уровень софта снижен на 1");
                    form1.point -= 9;
                    form1.softlvl -= 1;
                    form1.lblPoint.Text = form1.point.ToString();
                    form1.lblSoft.Text = form1.softlvl.ToString();

                }
            }
            this.Close();
        }
    }
}
