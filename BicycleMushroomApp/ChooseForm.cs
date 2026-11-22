using System;
using System.Windows.Forms;

namespace BicycleMushroomApp
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroomForm = new MushroomForm();
            mushroomForm.Show();
            this.Close();
        }

        private void btnBicycle_Click_1(object sender, EventArgs e)
        {
            BicycleForm bicycleForm = new BicycleForm();
            bicycleForm.Show();
            this.Close();
        }
    }
}