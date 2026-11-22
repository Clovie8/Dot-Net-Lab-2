using System;
using System.Windows.Forms;

namespace BicycleMushroomApp
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start_hour = 0;
            int end_hour = 0;

            if (!int.TryParse(txtStartHour.Text, out start_hour) || start_hour < 0 || start_hour > 23)
            {
                MessageBox.Show("ERROR: Starting hour must be an integer between 0 and 23.");
                return;
            }

            if (!int.TryParse(txtEndHour.Text, out end_hour) || end_hour < 1 || end_hour > 24)
            {
                MessageBox.Show("ERROR: Ending hour must be an integer between 1 and 24.");
                return;
            }

            if (start_hour >= end_hour)
            {
                MessageBox.Show("ERROR: The starting time must always be less than the ending time.");
                return;
            }

            int hours = end_hour - start_hour;
            int amount = 0;

            if ((start_hour >= 0 && end_hour <= 7) || (start_hour >= 21 && end_hour <= 24))
            {
                amount = hours * 500;
                lblResult.Text = $"Hours: {hours}\nRate: 500 RWF/hr\nTotal: {amount} Rwf";
            }
            else if ((start_hour >= 7 && end_hour <= 14) || (start_hour >= 19 && end_hour <= 21))
            {
                amount = hours * 1000;
                lblResult.Text = $"Hours: {hours}\nRate: 1000 RWF/hr\nTotal: {amount} Rwf";
            }
            else if (start_hour >= 14 && end_hour <= 19)
            {
                amount = hours * 1500;
                lblResult.Text = $"Hours: {hours}\nRate: 1500 RWF/hr\nTotal: {amount} Rwf";
            }
            else
            {
                MessageBox.Show("ERROR: Invalid Hour Range. Choose ranges between 0-7, 21-24, 7-14, 19-21, or 14-19.");
            }
        }

        

        private void txtStartHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void txtEndHour_TextChanged(object sender, EventArgs e)
        {

        }
    }
}