using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopWFApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Score_First_Delivery_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Click to Score the First Delivery of the Project \n -Sender: {sender} - Args: {e}");
        }

        private void Score_First_Delivery_MouseClick(object sender, MouseEventArgs e)
        {
            ScoreFirstDeliveryButton.BackColor = Color.AliceBlue;
        }
    }
}
