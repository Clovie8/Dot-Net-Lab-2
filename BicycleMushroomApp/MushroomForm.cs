using System;
using System.Windows.Forms;

namespace BicycleMushroomApp
{
    public partial class MushroomForm : Form
    {
        int step = 1;
        string question1 = "";
        string question2 = "";

        public MushroomForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ProcessAnswer("Yes");
        }

        private void ProcessAnswer(string answer)
        {
            if (step == 1)
            {
                question1 = answer;
                step = 2;
                lblQuestion.Text = "2. Does your mushroom grow in a forest?";
            }
            else if (step == 2)
            {
                question2 = answer;
                step = 3;

                if (question1 == "Yes" && question2 == "Yes")
                {
                    lblQuestion.Text = "3. Does your mushroom have a ring?";
                }
                else if (question1 == "No" && question2 == "Yes")
                {
                    lblQuestion.Text = "3. Does your mushroom have gills?";
                }
                else
                {
                    if (question1 == "Yes")
                    {
                        lblQuestion.Text = "Your Mushroom is: Agaric Jaunissant";
                    }
                    else
                    {
                        lblQuestion.Text = "Your Mushroom is: Coprin chevelu";
                    }
                    btnYes.Enabled = false;
                    btnNo.Enabled = false;
                }
            }
            else if (step == 3)
            {
                if (question1 == "Yes" && question2 == "Yes")
                {
                    if (answer == "Yes") lblQuestion.Text = "Your Mushroom is: Amanite tue-mouche";
                    else lblQuestion.Text = "Your Mushroom is: Pied Bleu";
                }
                else if (question1 == "No" && question2 == "Yes")
                {
                    if (answer == "Yes") lblQuestion.Text = "Your Mushroom is: Girolle";
                    else lblQuestion.Text = "Your Mushroom is: Cepe de bordeau";
                }

                btnYes.Enabled = false;
                btnNo.Enabled = false;
            }
        }

        private void btnNo_Click_1(object sender, EventArgs e)
        {
            ProcessAnswer("No");
        }

        private void btnYes_Click_1(object sender, EventArgs e)
        {
            ProcessAnswer("Yes");
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}