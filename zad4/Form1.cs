using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (presence == true)
            {
                this.pictureBox1.Load("zielona.png");
                this.timer1.Start();
                this.timer3.Start();
                engine = true;
            }
            else
            {
                MessageBox.Show("Brak Uzytkownika");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Load("szara.png");
            this.pictureBox2.Load("szara.png");
            this.pictureBox3.Load("szara.png");
            this.timer1.Stop();
            engine = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fun == true)
            {
                if (xb == true)
                {
                    xb = false; ;
                    this.pictureBox4.Load("tasma1.png");
                    this.pictureBox5.Load("went1.png");
                }
                else
                {
                    xb = true;
                    this.pictureBox4.Load("tasma2.png");
                    this.pictureBox5.Load("went2.png");
                }
            }
            else
            {
                
                if (xb == true)
                {
                xb = false; ;
                this.pictureBox4.Load("tasma1.png");

                }
                else
                {
                xb = true;
                this.pictureBox4.Load("tasma2.png");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            presence = true;
            this.timer2.Start();
            this.pictureBox2.Load("szara.png");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Stop();
            presence = false;
            MessageBox.Show("Potwierdź Obecność");
            this.pictureBox2.Load("zolta.png");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if(fun_error == false && presence == true && engine == true)
            {
                this.pictureBox2.Load("szara.png");
            }
            else if (fun_error == true)
            {
                this.timer3.Stop();
                this.pictureBox2.Load("zolta.png");
                MessageBox.Show("Włącz wentylator");
            }

            if(malfunction == false)
            {
                this.pictureBox3.Load("szara.png");
                
            }
            else
            {
                this.timer3.Stop();
                this.pictureBox1.Load("szara.png");
                this.pictureBox2.Load("szara.png");
                this.pictureBox3.Load("czerwona.png");
                this.timer1.Stop();
                this.timer2.Stop();
                engine = false;
                MessageBox.Show("Awaria Silnika");
            }

            if (this.trackBar1.Value >= 6 && fun == false)
            {
                fun_error = true;
            }

            if (this.trackBar1.Value == 10)
            {
                malfunction = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (malfunction == true) 
            { 
                malfunction = false;
                fun_error = false;
                this.trackBar1.Value = 0;
                this.timer3.Start();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fun = true;
            fun_error = false;
            this.timer3.Start();
        }
    }
}
