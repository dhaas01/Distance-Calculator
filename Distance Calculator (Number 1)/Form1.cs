using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator__Number_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Variables.
            int speed;          // Will hold the speed in MPH.
            int hours;          // Will hold the hours the car travels.
            int distance;       // Will hold the distance that will be calculated.
            int counter = 1;    // Is the counter that will be used to multiply by to find the distance traveled.

            // If statements make sure that the values entered into the textboxes will be integers, if they're not, 
            // a error message will be displayed with the else statements.
            if(int.TryParse(mphTextBox.Text, out speed))
            {
                if(int.TryParse(hoursTextBox.Text, out hours))
                { 
                    // The counter will increment for each hour to correctly compute the distance traveled in each hour.
                    while (counter < hours)
                    { 
                        // Calculates the distance.
                       distance = speed * counter;
                        // Displays the distance traveled in the ListBox.
                        distanceListBox.Items.Add("After hour " + counter + " the distance is " + distance);
                        counter++;
                    }
                } 
                else
                {
                    MessageBox.Show("Invalid value for speed.");
                }
            }
            else
            {
                MessageBox.Show("Invalid value for hours.");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
