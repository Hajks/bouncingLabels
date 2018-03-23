using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncingLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LabelBouncer[] bouncers = new LabelBouncer[3]; // Creating array with 3 objects.

        private void ToggleBouncing(int index, Label labelToBounce)
        {
            if (bouncers[index] == null) // if reference == null, create object. 
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBounce; 
            }
            else
            {
                bouncers[index] = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1); //so if bouncers is currently set up to null it will create new object but if it's !null then it will set up to null it will be usefull when we connect it with method move \/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (bouncers[i] != null)//so if we click label will start moving, only if it's not set up to null. 
                {
                    bouncers[i].Move();
                }
            }
        }
    }
}
