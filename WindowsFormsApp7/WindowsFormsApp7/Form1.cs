using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public string s;
        public int f = 0, a = 0, chislo = 0;
        public int hp = 5;

        Human human = new Human(true, 110, 100, 100);
        Sundew sundew = new Sundew(true, 110, true, 10, 0);
        Sunflower sunflower = new Sunflower(true, 90, true, 10);
        Nut nut = new Nut(true, 100, true, 50);
        Sun sun = new Sun(true);
        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0";
            ShowHP();
            CHuman CopyHuman = new CHuman();
            CopyHuman.Location = new Point(780,195);
            CopyHuman.Size = new Size(100, 70);
            Controls.Add(CopyHuman);
            CNut CopyNut = new CNut();
            CopyNut.Location = new Point(163, 270);
            CopyNut.Size = new Size(160, 60);
            Controls.Add(CopyNut);
            CSunflower CopySunflower = new CSunflower();
            CopySunflower.Location = new Point(290, 122);
            CopySunflower.Size = new Size(120, 30);
            Controls.Add(CopySunflower);
            CSundew CopySundew = new CSundew();
            CopySundew.Location = new Point(506, 158);
            CopySundew.Size = new Size(110, 20);
            Controls.Add(CopySundew);
            //all1.obj = sundew; //Прикрепляем росянку к графическому объекту
            sundew.dewGraphics = CopySundew; //Прикрепляем графический объект к росянке
            nut.futGraphics = CopyNut;//тоже прикрепляем
            sunflower.flowerGraphics = CopySunflower;
            human.humanGraphics = CopyHuman;//yes
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START TIME")
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                button1.Text = "STOP TIME";
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                button1.Text = "START TIME";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            f++;
            label1.Text = f.ToString();

            if (int.Parse(label1.Text) == 3 || int.Parse(label1.Text) == 17)
            {
                timer2.Enabled = false;
                textBox1.Text = sun.DorL();
                BackgroundImage = Image.FromFile("Night.jpg");
            }

            if (int.Parse(label1.Text) == 6 || int.Parse(label1.Text) == 20)
            {
                timer2.Enabled = true;
            }

            if (int.Parse(label1.Text) == 11 || int.Parse(label1.Text) == 28)
            {
                BackgroundImage = Image.FromFile("field.png");
                textBox1.Text = sun.DorL();
            }

            if (!sun.light)
                for (int i = 0; i < 1000; i++)
                {
                    pictureBox7.Location = new Point(pictureBox7.Location.X + 10, pictureBox7.Location.Y - 10);
                    pictureBox7.Refresh();
                    //
                }
            HP(human, sundew, sunflower, nut);

            GameOver();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (human.life && human.iq > 2)
            {
                textBox1.Text = human.ReadBook();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e) // это тако
        {
            if (human.life && human.hp > 0)
            {
                textBox1.Text = human.EatFood();
                label6.Text = human.hp.ToString();
            }
            else
            {
                GameOver();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            s = human.Kills(sundew);
            label2.Text = sundew.hp.ToString();

            if (sundew.hp <= 0 || !sundew.life)
            {
                chislo++;
                Trio(chislo);
                pictureBox1.Dispose();
                label2.Dispose();
                sundew.life = false;
            }
        }

		private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox1.Text = human.Kills(nut);
            label3.Text = nut.hp.ToString();
            label5.Text = nut.defend.ToString();

            if (nut.defend <= 0)
            {
                label5.Dispose();
            }

            if (nut.hp <= 0 || !nut.life)
            {
                chislo++;
                Trio(chislo);
                pictureBox2.Dispose();
                label3.Dispose();
                nut.life = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            s = human.Kills(sunflower);
            textBox1.Text = s;
            label4.Text = sunflower.hp.ToString();
            if (sunflower.hp <= 0 || !sunflower.life)
            {
                chislo++;
                Trio(chislo);
                pictureBox3.Dispose();
                label4.Dispose();
                sunflower.life = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            a++;
            if (a % 3 == 0 && nut.life)
                textBox1.Text = nut.Strengthen();

            //nut.Defender(sundew);

            if (a % 2 == 0 && sunflower.life)
                textBox1.Text = sunflower.HealSundew(sundew, sun);

            if (a % 2 == 1 && sunflower.life)
                textBox1.Text = sunflower.HealNut(nut, sun);

            if (a % 3 == 1)
            {
                if (sunflower.life)
                    textBox1.Text += sunflower.GetPhotoEating(sun);
                if (sundew.life)
                    textBox1.Text += sundew.GetPhotoEating(sun);
                if (nut.life)
                    textBox1.Text += nut.GetPhotoEating(sun);
            }

            if (sundew.life)
            textBox1.Text = sundew.GetPlotFromHuman(human);

            GameOver();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //_________________________________МЕТОДЫ______________________________________

        public void Trio(int chislo)
        {
            switch (chislo)
            {
                case 1:
                    pictureBox7.Image = Image.FromFile("sunya.png");
                    CicleImage();
                    break;
                        case 2:
                    pictureBox7.Image = Image.FromFile("filya.png");
                    CicleImage();
                    break;
                case 3:
                    pictureBox7.Image = Image.FromFile("olya.png");
                    CicleImage();
                    break;

            }
        }

        public void GameOver()
        {
            HP(human, sundew, sunflower, nut);
            if (!human.life)
            {
                DisposeLabel(label1, label2, label3, label4, label5, label6);
                DisposepPicture(pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6);
                textBox1.Dispose();
                button1.Dispose();
                BackgroundImage = Image.FromFile("Lose.png");
                
            }
        }

        public void DisposeLabel(params Label[] label)
        {
            for (int i = 0; i < label.Length; i++)
            {
                label[i].Dispose();
            }
        }

        public void DisposepPicture(params PictureBox[] pictureBox)
        {
            for (int i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i].Dispose();
            }
        }

        public void ShowHP()
        {
            label2.Text = sundew.hp.ToString();
            label3.Text = nut.hp.ToString();
            label4.Text = sunflower.hp.ToString();
            label5.Text = nut.defend.ToString();
            label6.Text = human.hp.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        public void CicleImage()
        {
            pictureBox7.Location = new Point(425, 555);
            for (int i = 0; i < 1000; i++)
            {
                pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y - 10);
                pictureBox7.Refresh();
                //Thread.Sleep(0);
            }
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            if (!sundew.life)
            {
               
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void HP(Human human, Sundew sundew, Sunflower sunflower, Nut nut)
        {

            human.hp -= 5;
            sundew.hp -= 5;
            sunflower.hp -= 5;
            nut.hp -= 5;
            ShowHP();
            
            if (human.hp <= 0 || !human.life)
            {
                human.life = false;
                pictureBox4.Dispose();
                label6.Dispose();
                human.humanGraphics.hp = 0;

            }

            if (sundew.hp <= 0 || !sundew.life)
            {
                pictureBox1.Dispose();
                label2.Dispose();
                sundew.life = false;
                sundew.dewGraphics.HP = 0;
            }

            if (nut.hp <= 0 || !nut.life)
            {
                pictureBox2.Dispose();
                label3.Dispose();
                label5.Dispose();
                nut.life = false;
                nut.futGraphics.hp = 0;
            }

            if (sunflower.hp <= 0 || !sunflower.life)
            {
                pictureBox3.Dispose();
                label4.Dispose();
                sunflower.life = false;
                sunflower.flowerGraphics.hp = 0;
            }
        }
    }
}
