using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Coversion //martin frich
{
    public partial class Form1 : Form
    {

        double choice, unit;
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
                double answer = InchesToCm(unit);
                outputLabel.Text = unit + " inches = " + answer.ToString("0.00 cm");
            }
            else if (choice == 2)
            {
                unit = Convert.ToDouble(unitBox.Text);
                double answer = FeetToCm(unit);
                outputLabel.Text = unit + " Feet = " + answer.ToString("0.00 cm");
            }
            else if (choice == 3)
            {
                unit = Convert.ToDouble(unitBox.Text);
                double answer = YardsToMetres(unit);
                outputLabel.Text = unit + " Yard = " + answer.ToString("0.00 Metres");
            }
            else if (choice == 4)
            {
                unit = Convert.ToDouble(unitBox.Text);
                double answer = MilesToKm(unit);
                outputLabel.Text = unit + " Miles = " + answer.ToString("0.00 Kilometres");
            }
        }

        public double InchesToCm(double cm)
        {
            double inches = cm * 2.54;
            return inches;
        }

        public double FeetToCm(double cm)
        {
            double feets = cm * 30.48;
            return feets;
        }

        public double YardsToMetres(double metres)
        {
            double yards = metres * 0.91;
            return yards;
            
        }

        public double MilesToKm(double km)
        {
            double miles = km * 1.6;
            return miles;
           
        }

    }
}
