using System;
using System.Globalization;

namespace ArtShop

{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var leftsource = new List<Size>();
            leftsource.Add(new Size() { Name = "Select a size", Value = "Pick" });
            leftsource.Add(new Size() { Name = "300 by 420", Value = "Small" });
            leftsource.Add(new Size() { Name = "420 by 500", Value = "Medium" });
            leftsource.Add(new Size() { Name = "500 by 620", Value = "Large" });

            this.comboBoxLeft.DataSource = leftsource;
            this.comboBoxLeft.DisplayMember = "Name";
            this.comboBoxLeft.ValueMember = "Value";

            var midsource = new List<Size>();
            midsource.Add(new Size() { Name = "Select a size", Value = "Pick" });
            midsource.Add(new Size() { Name = "300 by 420", Value = "Small" });
            midsource.Add(new Size() { Name = "420 by 500", Value = "Medium" });
            midsource.Add(new Size() { Name = "500 by 620", Value = "Large" });

            this.comboBoxMid.DataSource = midsource;
            this.comboBoxMid.DisplayMember = "Name";
            this.comboBoxMid.ValueMember = "Value";

            var rightsource = new List<Size>();
            rightsource.Add(new Size() { Name = "Select a size", Value = "Pick" });
            rightsource.Add(new Size() { Name = "300 by 420", Value = "Small" });
            rightsource.Add(new Size() { Name = "420 by 500", Value = "Medium" });
            rightsource.Add(new Size() { Name = "500 by 620", Value = "Large" });

            this.comboBoxRight.DataSource = rightsource;
            this.comboBoxRight.DisplayMember = "Name";
            this.comboBoxRight.ValueMember = "Value";
        }
        private void btnLeftCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxLeft.SelectedIndex == 0 && txtBoxLeftQuan.Text == "")
            {
                errorProvider1.SetError(comboBoxLeft, "Please Select A Size");
                errorProvider1.SetError(txtBoxLeftQuan, "Please Select A Quantity");
            }
            else if (comboBoxLeft.SelectedIndex != 0 && txtBoxLeftQuan.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBoxLeftQuan, "Please Select A Quantity");
            }
            else if (comboBoxLeft.SelectedIndex == 0 && txtBoxLeftQuan.Text != "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBoxLeft, "Please Select A Size");
            }
            else
            {
                errorProvider1.Clear();
                decimal leftPrice;
                if (comboBoxLeft.SelectedIndex == 1)
                {
                    leftPrice = 10.00m;
                }
                else if (comboBoxLeft.SelectedIndex == 2)
                {
                    leftPrice = 12.25m;
                }
                else if (comboBoxLeft.SelectedIndex == 3)
                {
                    leftPrice = 15.50m;
                }
                else
                {
                    leftPrice = 0m;
                }
                decimal quantitySelected = Convert.ToDecimal(txtBoxLeftQuan.Text);
                decimal Cost = quantitySelected * leftPrice;
                txtBoxLeftPrice.Text = String.Format("{0:C}", Cost);
            }
        }

        private void btnMidCalculation_Click(object sender, EventArgs e)
        {
            if (comboBoxMid.SelectedIndex == 0 && txtBoxMidQuan.Text == "")
            {
                errorProvider1.SetError(comboBoxMid, "Please Select A Size");
                errorProvider1.SetError(txtBoxMidQuan, "Please Select A Quantity");
            }
            else if (comboBoxMid.SelectedIndex != 0 && txtBoxMidQuan.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBoxMidQuan, "Please Select A Quantity");
            }
            else if (comboBoxMid.SelectedIndex == 0 && txtBoxMidQuan.Text != "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBoxMid, "Please Select A Size");
            }
            else
            {
                errorProvider1.Clear();
                decimal midPrice;
                if (comboBoxMid.SelectedIndex == 1)
                {
                    midPrice = 10.00m;
                }
                else if (comboBoxMid.SelectedIndex == 2)
                {
                    midPrice = 12.25m;
                }
                else if (comboBoxMid.SelectedIndex == 3)
                {
                    midPrice = 15.50m;
                }
                else
                {
                    midPrice = 0m;
                }
                decimal quantitySelected = Convert.ToDecimal(txtBoxMidQuan.Text);
                decimal Cost = quantitySelected * midPrice;
                txtBoxMidPrice.Text = String.Format("{0:C}", Cost);
            }

        }

        private void btnRightCalculation_Click(object sender, EventArgs e)
        {
            if (comboBoxRight.SelectedIndex == 0 && txtBoxRightQuan.Text == "")
            {
                errorProvider1.SetError(comboBoxRight, "Please Select A Size");
                errorProvider1.SetError(txtBoxRightQuan, "Please Select A Quantity");
            }
            else if (comboBoxRight.SelectedIndex != 0 && txtBoxRightQuan.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtBoxRightQuan, "Please Select A Quantity");
            }
            else if (comboBoxRight.SelectedIndex == 0 && txtBoxRightQuan.Text != "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(comboBoxRight, "Please Select A Size");
            }
            else
            {
                errorProvider1.Clear();
                decimal rightPrice;
                if (comboBoxRight.SelectedIndex == 1)
                {
                    rightPrice = 10.00m;
                }
                else if (comboBoxRight.SelectedIndex == 2)
                {
                    rightPrice = 12.25m;
                }
                else if (comboBoxRight.SelectedIndex == 3)
                {
                    rightPrice = 15.50m;
                }
                else
                {
                    rightPrice = 0m;
                }
                decimal quantitySelected = Convert.ToDecimal(txtBoxRightQuan.Text);
                decimal Cost = quantitySelected * rightPrice;
                txtBoxRightPrice.Text = String.Format("{0:C}", Cost);
            }
        }
    }
}