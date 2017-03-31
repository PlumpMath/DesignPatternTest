using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Builder.Person;
using Builder.Easy;

namespace Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics pic;
        private void Form1_Load(object sender, EventArgs e)
        {
            //建造者
            Directory dir = new Directory();
            Builder.Easy.Builder bd1 = new Builder.Easy.ConcreateBuilder1();
            Builder.Easy.Builder bd2 = new Builder.Easy.ConcreateBuilder2();

            dir.ConStract(bd1);
            Builder.Easy.Product p1 = new Builder.Easy.Product();
            p1 = bd1.GetResult();
            p1.Show();


            dir.ConStract(bd2);
            Builder.Easy.Product p2 = new Builder.Easy.Product();
            p2 = bd1.GetResult();
            p2.Show();


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pic = this.pictureBox1.CreateGraphics();
        }
        private void Create()
        {
            //建造者模式
            pic = this.pictureBox1.CreateGraphics();
            //this.pictureBox1.
            PersonThinbuilder ptb = new PersonThinbuilder(pic, new Pen(Color.Red));
            Director dir = new Director(ptb);
            dir.CreatePerson();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Create();
        }

    }
}
