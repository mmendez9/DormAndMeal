using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormAndMeal
{
    public partial class DormAndMeal : Form
    {
        public DormAndMeal()
        {
            InitializeComponent();
        }

        static int totalCharges;

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Total (form) class
            Total total = new Total();

            // Find the selected dormitory plan
            if (rbAllen.Checked)
            {
                total.dormPlan.Text = rbAllen.Text + "  " + allenAmount.Text;
                int alAmount = 1500;
                totalCharges = alAmount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else if (rbPike.Checked)
            {
                total.dormPlan.Text = rbPike.Text + "  " + pikeAmount.Text;
                int pAmount = 1600;
                totalCharges = pAmount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else if (rbFar.Checked)
            {
                total.dormPlan.Text = rbFar.Text + "  " + farAmount.Text;
                int fAmount = 1800;
                totalCharges = fAmount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else if (rbSuit.Checked)
            {
                total.dormPlan.Text = rbSuit.Text + "  " + suitAmount.Text;
                int sAmount = 2500;
                totalCharges = sAmount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else
            {
                total.dormPlan.Text = "None";
            }

            // Find the selected meal plan
            if (meals7.Checked)
            {
                total.mealPlan.Text = meals7.Text + "  " + amount7.Text;
                int amount = 600;
                totalCharges += amount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else if (meals14.Checked)
            {
                total.mealPlan.Text = meals14.Text + "  " + amount14.Text;
                int amount = 1200;
                totalCharges += amount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else if (unlimited.Checked)
            {
                total.mealPlan.Text = unlimited.Text + "  " + amountUn.Text;
                int amount = 1700;
                totalCharges += amount;
                total.totalCharges.Text = totalCharges.ToString("c");
            }
            else
            {
                total.mealPlan.Text = "None";
            }

            total.Show();
        }
    }
}
