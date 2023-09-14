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

namespace VariablePractice
{
    public partial class Form1 : Form
    {
        int delay = 375;
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Thinking";
            for (int i = 0; i < 4; i++)
            {
                Refresh();
                Thread.Sleep(delay);
                outputLabel.Text += ".";
            }
            string Wayne = "Wayne Gretzky ";
            int num = 99;
            outputLabel.Text = $"{Wayne} is {num}.";
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Thinking";
            for (int i = 0; i < 4; i++)
            {
                Refresh();
                Thread.Sleep(delay);
                outputLabel.Text += ".";
            }
            double hours = 25;
            double pay = 18.75;
            double earned = hours * pay;
            outputLabel.Text = $"{hours} hours at {pay} per hour equals {earned}.";

        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Thinking";
            for (int i = 0; i < 4; i++)
            {
                Refresh();
                Thread.Sleep(delay);
                outputLabel.Text += ".";
            }
            double radius = 15;
            double pi = 3.14;
            double area = pi * (radius * radius);
            outputLabel.Text = $"the area of a circle with a radius of {radius} cm is {area}^2.";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Thinking";
            for (int i = 0; i < 4; i++)
            {
                Refresh();
                Thread.Sleep(delay);
                outputLabel.Text += ".";
            }
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;
            outputLabel.Text = $"The area of a room with the dimensions {length}m by {width} is {area}m^2.";
            outputLabel.Text += $"\n\nThe cost to carpet this area is {costPerMeter} per square is meter is {totalCost}.";

        }

        private void billButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Thinking";
            for (int i = 0; i < 4; i++)
            {
                Refresh();
                Thread.Sleep(delay);
                outputLabel.Text += ".";
            }
            double shirtCost = 12.49;
            double taxRate = .13;
            double tax = shirtCost * taxRate;
            double total = shirtCost + tax;
            double tender = 20.00;
            double change = tender - Math.Round(total, 2);
            outputLabel.Text = "Bill of Sale";
            outputLabel.Text +=$"\n\nShirt:     {shirtCost}";
            outputLabel.Text += $"\n\nTax:      {Math.Round(tax, 2)}";
            outputLabel.Text += $"\nTotal:       {Math.Round(total, 2)}";
            outputLabel.Text += $"\n\nTendered:      {tender}";
            outputLabel.Text += $"\nChange:     {change}";  
        }
    }
}
