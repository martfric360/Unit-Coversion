using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Coversion
{
    public partial class Form1 : Form
    {

        double choice, unit, answer; 
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = Convert.ToDouble(chooseBox.Text); 
            if (choice == 1)
            {
                unit = Convert.ToDouble(unitBox.Text);
                InchesToCm();
            }
            else if (choice == 2)
            {
                unit = Convert.ToDouble(unitBox.Text);
                FeetToCm();
            }
            else if (choice == 3)
            {
                unit = Convert.ToDouble(unitBox.Text);
                YardsToMetres();
            }
            else if (choice == 4)
            {
                unit = Convert.ToDouble(unitBox.Text);
                MilesToKm();
            }
        }

        public void InchesToCm()
        {
            answer = unit * 2.54;
            outputLabel.Text = unit + " inches = " + answer.ToString("0.00 cm"); 
        }

        public void FeetToCm()
        {
            answer = unit * 30.48;
            outputLabel.Text = unit + " Feet = " + answer.ToString("0.00 cm");
        }

        public void YardsToMetres()
        {
            answer = unit * 0.91;
            outputLabel.Text = unit + " Yard = " + answer.ToString("0.00 Metres");
        }

        public void MilesToKm()
        {
            answer = unit * 1.6;
            outputLabel.Text = unit + " Miles = " + answer.ToString("0.00 Kilometres");
        }

    }
}
