using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatures
{
    public partial class frmTemperatures : Form
    {
        // class-level declarations
        const int MAX_DAYS = 31;
        const int MIN_TEMP = -60;
        const int MAX_TEMP = 60;
        int[] temperatures = new int[MAX_DAYS];
        int nrDays = 0;
        int highest;
        int lowest;
        int nrHotDays;
        int sum = 0; // the sum of all temperature values (to 
        public frmTemperatures()
        {
            InitializeComponent();
        }

        // add one more temperature
        private void button1_Click(object sender, EventArgs e)
        {
            int nextTemp;
            double average;
            if (Validator.IsPresent(txtNewTemp) &&
                Validator.IsIntInRange(txtNewTemp, MIN_TEMP, MAX_TEMP))
            {
                // read  next temperature
                nextTemp = Convert.ToInt32(txtNewTemp.Text);
                // add it to the array 
                temperatures[nrDays] = nextTemp;
                lstTemperatures.Items.Add(nextTemp);
                nrDays++;
                sum += nextTemp;

                // calculate Average
                average = (double)sum / nrDays;
                // count days above average
                nrHotDays = CountHotDays(temperatures, nrDays, average);

                // find hottest day
                highest = highestTemp(temperatures, nrDays);
                lowest = lowestTemp(temperatures, nrDays);
                //  display stats
                txtNrOfDays.Text = nrDays.ToString();
                txtAverageTemp.Text = average.ToString("f2");
                txtHotDays.Text = nrHotDays.ToString();
                txtHighest.Text = highest.ToString();
                txtLowest.Text = lowest.ToString();
                // if array is full, disable entry panel
                if (nrDays == MAX_DAYS)
                {
                    grpEntry.Enabled = false;
                }
            }

        }

        private int highestTemp (int[] temps, int count)
        {
            int highestTemp = temps[0];

            for (int i = 0; i < count; i++)    // go through all temperatures 
            {
                if (temps[i] > highestTemp)   
                    highestTemp = temps[i] ;             // then increment count of hot days
            }

            return highestTemp;
        }

        private int lowestTemp(int[] temps, int count)
        {
            int lowestTemp = temps[0];

            for (int i = 0; i < count; i++)    // go through all temperatures 
            {
                if (temps[i] < lowestTemp)
                    lowestTemp = temps[i];             // then increment count of hot days
            }

            return lowestTemp;
        }

        private int CountHotDays(int[] temps, int count, double threshold)
        {
            int countHot = 0;

            for(int i=0; i < count; i++)    // go through all temperatures 
            {
                if (temps[i] > threshold)   // if more than the threshold
                    countHot++;             // then increment count of hot days
            }

            return countHot;
        }
    }
}
