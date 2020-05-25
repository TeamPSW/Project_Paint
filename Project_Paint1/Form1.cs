using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Paint1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool painting;
        bool erase;
        Color color = Color.Red;
        

        //Vlad Tykhoniuk
        private void butChange_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }
        ////////////////////////
        //Vlad Tykhoniuk 
        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                erase = true;
            }

            if (e.Button == MouseButtons.Left)
            {
                painting = true;
            }
        }
        ////////////////////////////////
    }
}
