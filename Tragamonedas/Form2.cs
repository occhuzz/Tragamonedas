using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_Tragamonedas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int n1, n2, n3, im1, im2, im3,ap,k,b1,b2,b3,ib1,ib2,ib3,label_ronda;
        string final,label_ronda_final;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ap = Convert.ToInt32(label1.Text);
            if(ap>0){
            label_ronda = Convert.ToInt32(label4.Text);
            label_ronda = label_ronda + 1;
            label_ronda_final = Convert.ToString(label_ronda);
            label4.Text = label_ronda_final;
            n1 = rnd.Next(31);
            n2 = rnd.Next(31);
            n3 = rnd.Next(31);
            if (n1 <= 15)
            {
                im1 = 1;
            }
            else
            {
                if (n1 <= 25)
                {
                    im1 = 2;
                }
                else
                {
                    if (n1 == 26)
                    {
                        im1 = 3;
                    }
                    else
                    {
                        im1 = 4;
                    }
                }
            }
            switch (im1)
            {
                case 1: pictureBox1.Load("1.jpg");
                    break;
                case 2: pictureBox1.Load("2.jpg");
                    break;
                case 3: pictureBox1.Load("3.jpg");
                    break;
                case 4: pictureBox1.Load("4.jpg");
                    break;
            }
            if (n2 <= 15)
            {
                im2 = 1;
            }
            else
            {
                if (n2 <= 25)
                {
                    im2 = 2;
                }
                else
                {
                    if (n2 == 26)
                    {
                        im2 = 3;
                    }
                    else
                    {
                        im2 = 4;
                    }
                }
            }
            switch (im2)
            {
                case 1: pictureBox2.Load("1.jpg");
                    break;
                case 2: pictureBox2.Load("2.jpg");
                    break;
                case 3: pictureBox2.Load("3.jpg");
                    break;
                case 4: pictureBox2.Load("4.jpg");
                    break;
            }
            if (n3 <= 15)
            {
                im3 = 1;
            }
            else
            {
                if (n3 <= 25)
                {
                    im3 = 2;
                }
                else
                {
                    if (n3 == 26)
                    {
                        im3 = 3;
                    }
                    else
                    {
                        im3 = 4;
                    }
                }
            }
            switch (im3)
            {
                case 1: pictureBox3.Load("1.jpg");
                    break;
                case 2: pictureBox3.Load("2.jpg");
                    break;
                case 3: pictureBox3.Load("3.jpg");
                    break;
                case 4: pictureBox3.Load("4.jpg");
                    break;
            }
            if (im1 == 1 && im2 == 1 && im3 == 1)
            {
                ap = Convert.ToInt32(label1.Text);
                ap = ap + 100;
                final = Convert.ToString(ap);
                label1.Text = final;
                MessageBox.Show("Ganó $100");
                pictureBox1.Load("gif.gif");
                pictureBox2.Load("gif2.gif");
                pictureBox3.Load("gif3.gif");
            }
            else
            {
                if (im1 == 1 && im2 == 1 || im1 == 1 && im3 == 1 || im2 == 1 && im3 == 1)
                {
                    ap = Convert.ToInt32(label1.Text);
                    ap = ap + 50;
                    final = Convert.ToString(ap);
                    label1.Text = final;
                    MessageBox.Show("Ganó $50");
                    pictureBox1.Load("gif.gif");
                    pictureBox2.Load("gif2.gif");
                    pictureBox3.Load("gif3.gif");
                }
                else
                {
                    if (im1 == 2 && im2 == 2 && im3 == 2)
                    {
                        ap = Convert.ToInt32(label1.Text);
                        ap = ap + 100;
                        final = Convert.ToString(ap);
                        label1.Text = final;
                        MessageBox.Show("Ganó $100");
                        pictureBox1.Load("gif.gif");
                        pictureBox2.Load("gif2.gif");
                        pictureBox3.Load("gif3.gif");
                    }
                    else
                    {
                        if (im1 == 2 && im2 == 2 || im1 == 2 && im3 == 2 || im2 == 2 && im3 == 2)
                        {
                            ap = Convert.ToInt32(label1.Text);
                            ap = ap + 50;
                            final = Convert.ToString(ap);
                            label1.Text = final;
                            MessageBox.Show("Ganó $50");
                            pictureBox1.Load("gif.gif");
                            pictureBox2.Load("gif2.gif");
                            pictureBox3.Load("gif3.gif");
                        }
                        else
                        {
                            if (im1 == 3 && im2 == 3 && im3 == 3)
                            {
                                ap = Convert.ToInt32(label1.Text);
                                ap = ap +500;
                                final = Convert.ToString(ap);
                                label1.Text = final;
                                MessageBox.Show("Ganó $500");
                                pictureBox1.Load("gif.gif");
                                pictureBox2.Load("gif2.gif");
                                pictureBox3.Load("gif3.gif");
                            }
                            else
                            {
                                if (im1 == 4 && im2 == 4 || im1 == 4 && im3 == 4 || im2 == 4 && im3 == 4)
                                {
                                    MessageBox.Show("3 Tiros Extras!");
                                    for (k = 1; k <= 3; k++)
                                    {
                                        b1 = rnd.Next(31);
                                        b2 = rnd.Next(31);
                                        b3 = rnd.Next(31);
                                        if (b1 <= 15)
                                        {
                                            ib1 = 1;
                                        }
                                        else
                                        {
                                            if (b1 <= 25)
                                            {
                                                ib1 = 2;
                                            }
                                            else
                                            {
                                                if (b1 == 26)
                                                {
                                                    ib1 = 3;
                                                }
                                                else
                                                {
                                                    ib1 = 4;
                                                }
                                            }
                                        }
                                        switch (ib1)
                                        {
                                            case 1: pictureBox1.Load("1.jpg");
                                                break;
                                            case 2: pictureBox1.Load("2.jpg");
                                                break;
                                            case 3: pictureBox1.Load("3.jpg");
                                                break;
                                            case 4: pictureBox1.Load("4.jpg");
                                                break;
                                        }
                                        if (b2 <= 15)
                                        {
                                            ib2 = 1;
                                        }
                                        else
                                        {
                                            if (b2 <= 25)
                                            {
                                                ib2 = 2;
                                            }
                                            else
                                            {
                                                if (b2 == 26)
                                                {
                                                    ib2 = 3;
                                                }
                                                else
                                                {
                                                    ib2 = 4;
                                                }
                                            }
                                        }
                                        switch (ib2)
                                        {
                                            case 1: pictureBox2.Load("1.jpg");
                                                break;
                                            case 2: pictureBox2.Load("2.jpg");
                                                break;
                                            case 3: pictureBox2.Load("3.jpg");
                                                break;
                                            case 4: pictureBox2.Load("4.jpg");
                                                break;
                                        }
                                        if (b3 <= 15)
                                        {
                                            ib3 = 1;
                                        }
                                        else
                                        {
                                            if (b3 <= 25)
                                            {
                                                ib3 = 2;
                                            }
                                            else
                                            {
                                                if (b3 == 26)
                                                {
                                                    ib3 = 3;
                                                }
                                                else
                                                {
                                                    ib3 = 4;
                                                }
                                            }
                                        }
                                        switch (ib3)
                                        {
                                            case 1: pictureBox3.Load("1.jpg");
                                                break;
                                            case 2: pictureBox3.Load("2.jpg");
                                                break;
                                            case 3: pictureBox3.Load("3.jpg");
                                                break;
                                            case 4: pictureBox3.Load("4.jpg");
                                                break;
                                        }
                                        if (ib1 == 1 && ib2 == 1 && ib3 == 1)
                                        {
                                            ap = Convert.ToInt32(label1.Text);
                                            ap = ap + 200;
                                            final = Convert.ToString(ap);
                                            label1.Text = final;
                                            MessageBox.Show("Ganó $200");
                                        }
                                        else
                                        {
                                            if (ib1 == 1 && ib2 == 1 || ib1 == 1 && ib3 == 1 || ib2 == 1 && ib3 == 1)
                                            {
                                                ap = Convert.ToInt32(label1.Text);
                                                ap = ap + 100;
                                                final = Convert.ToString(ap);
                                                label1.Text = final;
                                                MessageBox.Show("Ganó $100");
                                            }
                                            else
                                            {
                                                if (ib1 == 2 && ib2 == 2 && ib3 == 2)
                                                {
                                                    ap = Convert.ToInt32(label1.Text);
                                                    ap = ap + 200;
                                                    final = Convert.ToString(ap);
                                                    label1.Text = final;
                                                    MessageBox.Show("Ganó $200");
                                                }
                                                else
                                                {
                                                    if (ib1 == 2 && ib2 == 2 || ib1 == 2 && ib3 == 2 || ib2 == 2 && ib3 == 2)
                                                    {
                                                        ap = Convert.ToInt32(label1.Text);
                                                        ap = ap + 100;
                                                        final = Convert.ToString(ap);
                                                        label1.Text = final;
                                                        MessageBox.Show("Ganó $100");
                                                    }
                                                    else
                                                    {
                                                        if (ib1 == 3 && ib2 == 3 && ib3 == 3)
                                                        {
                                                            ap = Convert.ToInt32(label1.Text);
                                                            ap = ap+1000;
                                                            final = Convert.ToString(ap);
                                                            label1.Text = final;
                                                            MessageBox.Show("Ganó $1000");
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("No Ganó Nada");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    ap = Convert.ToInt32(label1.Text);
                                    ap = ap - 500;
                                    final = Convert.ToString(ap);
                                    label1.Text = final;
                                    MessageBox.Show("Pierde $500");
                                    pictureBox1.Load("gif.gif");
                                    pictureBox2.Load("gif2.gif");
                                    pictureBox3.Load("gif3.gif");
                                }
                            }
                        }
                    }
                }
            }
            }else{ MessageBox.Show("No tiene Dinero, Pierde");
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
