using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** =========================================================
 Kristi Mathis

 Windows 10

 Microsoft Visual Studio 2017 Community Edition
 CIS 169
 Chapter 04 Assignment, Programming Challenge #11
 This program will take an integer input and calculate 
 the total number of days/hours/minutes/seconds it is equal to.


 Academic Honesty:
 I attest that this is my original work.
 I have not used unauthorized source code, either modified or unmodified.
 I have not given other fellow student(s) access to my program.
=========================================================== **/

namespace TimeCalculator
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Define variables
            const int SECONDS_IN_MIN = 60;
            const int SECONDS_IN_HOUR = 3600;
            const int SECONDS_IN_DAY = 86400;
            int seconds;
            int hours = 0;
            int minutes = 0;
            int days = 0;

            //Check if text entered is an integer
            if (int.TryParse(secondsTextBox.Text, out seconds))
            {
                //Check if seconds entered has any days and calculate days and remaining seconds
                if (seconds >= SECONDS_IN_DAY)
                {
                    days = seconds / SECONDS_IN_DAY;
                    seconds = seconds - (SECONDS_IN_DAY * days);
                }
                //Check if seconds has any hours and calculate hours and remaining seconds
                if (seconds >= SECONDS_IN_HOUR)
                {
                    hours = seconds / SECONDS_IN_HOUR;
                    seconds = seconds - (SECONDS_IN_HOUR * hours);
                }
                //Check if seconds has any minutes and calculate minutes and remaining seconds
                if (seconds >= SECONDS_IN_MIN)
                {
                    minutes = seconds / SECONDS_IN_MIN;
                    seconds = seconds - (SECONDS_IN_MIN * minutes);
                }
                //Display number of days, hours, minutes, and seconds based on entered seconds
                if (seconds > 0)
                {
                    daysDisplayLabel.Text = days.ToString();
                    hoursDisplayLabel.Text = hours.ToString();
                    minutesDisplayLabel.Text = minutes.ToString();
                    displaySecondsLabel.Text = seconds.ToString();
                }
                //If number entered was not at least 1
                else
                {
                    MessageBox.Show("The seconds must be greater than zero.");
                }
            }
            //Input was not a number
            else
            {
                MessageBox.Show("The seconds must be an integer.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears text and resets focus
            secondsTextBox.Text = "";
            secondsTextBox.Focus();
        }
    }
}
