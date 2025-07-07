using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Maker_Project
{
    public partial class frmOrderScreen: Form
    {
        public frmOrderScreen()
        {
            InitializeComponent();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentSize.Text = "Small";
            CalculateCurrentPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentSize.Text = "Medium";
            CalculateCurrentPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentSize.Text = "Large";
            CalculateCurrentPrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentCrustType.Text = "Thin Crust";
            CalculateCurrentPrice();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentCrustType.Text = "Thick Crust";
            CalculateCurrentPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentLocationOfEating.Text = "Eat In";
            CalculateCurrentPrice();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbCurrentLocationOfEating.Text = "Take out";
            CalculateCurrentPrice();
        }

        private void cbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            byte NumberOfToppings = 0;

            if (cbExtraCheese.Checked)
            {
                lbCurrentToppings.Text = "Extra Cheese";
                NumberOfToppings++;
            }
                if (cbMushrooms.Checked)
            {
                if (NumberOfToppings > 0)
                {
                    lbCurrentToppings.Text += ", ";
                    lbCurrentToppings.Text += "Mushrooms";
                }
                else
                    lbCurrentToppings.Text = "Mushrooms";
                NumberOfToppings++;
            }
            if (cbTomatoes.Checked)
            {
                if (NumberOfToppings > 0)
                {
                    lbCurrentToppings.Text += ", ";
                    lbCurrentToppings.Text += "Tomatoes";
                }
                else
                    lbCurrentToppings.Text = "Tomatoes";
                NumberOfToppings++;
            }
            if (NumberOfToppings >= 3)
                lbCurrentToppings.Text += "\n";
            if (cbOnion.Checked)
            {
                if (NumberOfToppings > 0)
                {
                    lbCurrentToppings.Text += ", ";
                    lbCurrentToppings.Text += "Onions";
                }
                else
                    lbCurrentToppings.Text = "Onions";
                NumberOfToppings++;
            }
            if (cbOlives.Checked)
            {
                if (NumberOfToppings > 0)
                {
                    lbCurrentToppings.Text += ", ";
                    lbCurrentToppings.Text += "Olives";
                }
                else
                    lbCurrentToppings.Text = "Olives";
                NumberOfToppings++;
            }
            if (cbGreenPeppers.Checked)
            {
                if (NumberOfToppings > 0)
                {
                    lbCurrentToppings.Text += ", ";
                    lbCurrentToppings.Text += "Green Peppers";
                }
                else
                    lbCurrentToppings.Text = "Green Peppers";
                NumberOfToppings++;
            }
            if (NumberOfToppings == 0)
                lbCurrentToppings.Text = "No Toppings";

            CalculateCurrentPrice();

        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraCheese_CheckedChanged(sender, e);
        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraCheese_CheckedChanged(sender, e);
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraCheese_CheckedChanged(sender, e);
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraCheese_CheckedChanged(sender, e);
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraCheese_CheckedChanged(sender, e);
        }

        private void CalculateCurrentPrice()
        {
            byte Price = 0;
            if (rbSmall.Checked)
                Price += 10;
            if (rbMedium.Checked)
                Price += 20;
            if (rbLarge.Checked)
                Price += 30;
            if (rbThinCrust.Checked)
                Price += 10;
            if (rbThickCrust.Checked)
                Price += 20;
            if (cbExtraCheese.Checked)
                Price += 5;
            if (cbMushrooms.Checked)
                Price += 5;
            if (cbTomatoes.Checked)
                Price += 5;
            if (cbOnion.Checked)
                Price += 5;
            if (cbOlives.Checked)
                Price += 5;
            if (cbGreenPeppers.Checked)
                Price += 5;

            lbCurrentPrice.Text = "$" + Price.ToString();
        }

        private void btResetForm_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            cbExtraCheese.Checked = false;
            cbGreenPeppers.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbOlives.Checked = false;
            cbOnion.Checked = false;

        }

        private void btOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to checkout", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                btResetForm_Click(sender, e);
        }
    }
}
