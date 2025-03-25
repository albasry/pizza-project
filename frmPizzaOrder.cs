using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void btnOrderExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * The data type of the Tag property is object,
         * can be assigned to any data type.
         *
         * Single is an alias for the Float data type, 
         * you need it to convert from ( Tag ) to Float.
         */

        float GetToppingsPrice()
        {
            float toppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkExtraChees.Tag);

            if (chkMushrooms.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);

            if (chkTomatoes.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            if (chkOnion.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);

            if (chkOlives.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);

            if (chkGreenPepper.Checked)
                toppingsTotalPrice += Convert.ToSingle(chkGreenPepper.Tag);


            return toppingsTotalPrice;
        }

        float GetCrustPrice()
        {
            if (rdThinCrust.Checked)
                return Convert.ToSingle(rdThinCrust.Tag);
            else if (rdThickCrust.Checked)
                return Convert.ToSingle(rdThickCrust.Tag);
            else
                return 0;
        }

        float GetSizePrice()
        {
            if (rdSmallPizza.Checked)
                return Convert.ToSingle(rdSmallPizza.Tag);
            else if (rdMedPizza.Checked)
                return Convert.ToSingle(rdMedPizza.Tag);
            else if (rdLargePizza.Checked)
                return Convert.ToSingle(rdLargePizza.Tag);
            else
                return 0;
        }

        float GetWhereToEatPrice()
        {
            if (rdEatIn.Checked)
                return Convert.ToSingle(rdEatIn.Tag);
            else if (rdTakeOut.Checked)
                return Convert.ToSingle(rdTakeOut.Tag);
            else
                return 0;
        }

        float CalculateTotalPrice()
        {
            return GetWhereToEatPrice() + GetSizePrice() + GetCrustPrice() + GetToppingsPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPriceSummary.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rdEatIn.Checked)
            {
                lblWhereEatSummary.Text = "Eat in";
                return;
            }

            if (rdTakeOut.Checked)
            {
                lblWhereEatSummary.Text = "Take Out";
                return;
            }
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rdSmallPizza.Checked)
            {
                lblSizeSummary.Text = "Small";
                return;
            }

            if (rdMedPizza.Checked)
            {
                lblSizeSummary.Text = "Meduim";
                return;
            }

            if (rdLargePizza.Checked)
            {
                lblSizeSummary.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rdThinCrust.Checked)
            {
                lblCrustSummary.Text = "Thin Crust";
                return;
            }

            if (rdThickCrust.Checked)
            {
                lblCrustSummary.Text = "Thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkGreenPepper.Checked)
            {
                sToppings += ", Green Pepper";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            lblToppingsSummary.Text = sToppings;
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdSmallPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdMedPizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("Order placed, thanks!", "Done");

                btnOrderPizza.Enabled = false;
                grpWhereEat.Enabled = false;
                grpSize.Enabled = false;
                grpCrustType.Enabled = false;
                grpToppings.Enabled = false;
                
            }
            
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            btnOrderPizza.Enabled = true;

            // =======================
            grpWhereEat.Enabled = true;
            rdEatIn.Checked = false;
            rdTakeOut.Checked = false;

            // =======================
            grpSize.Enabled = true;
            rdSmallPizza.Checked = false;
            rdMedPizza.Checked = false;
            rdLargePizza.Checked = false;

            // =======================
            grpCrustType.Enabled = true;
            rdThinCrust.Checked = false;
            rdThickCrust.Checked = false;

            // =======================
            grpToppings.Enabled = true;
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPepper.Checked = false;

            // =======================
            lblWhereEatSummary.Text = "None";
            lblSizeSummary.Text = "None";
            lblCrustSummary.Text = "None";
            lblToppingsSummary.Text = "None";

            // =======================
            lblTotalPriceSummary.Text = "0";
        }
    }
}
