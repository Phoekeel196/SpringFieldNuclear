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
namespace SpringFieldNuclear
{
    public partial class Form1 : Form
    {
        public object Reactor { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Calm.Text = "I Told You Not To Push The Button!!!";
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Red;
            RightBlue.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(1000);

            LeftBlue.BackColor = Color.Blue;
            RightBlue.BackColor = Color.Blue;




        }
    }
}
