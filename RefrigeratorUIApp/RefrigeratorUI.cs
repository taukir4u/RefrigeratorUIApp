using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefrigeratorUIApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        Refrigerator aRefrigerator = new Refrigerator();

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRefrigerator.MaxWeight = Convert.ToDouble(maxWeightTextBox.Text);
            MessageBox.Show("Maximum Weight Set");
            maxWeightTextBox.Text = "";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int noOfItems = Convert.ToInt32(noOfItemsTextBox.Text);
            double weight = Convert.ToDouble(weightTextBox.Text);

            double totalWeight = aRefrigerator.GetTotalWeight(noOfItems, weight);
            
            aRefrigerator.AddWeight(totalWeight);
            double currentWeight = aRefrigerator.CurrentWeight;
            double remainingWeight = aRefrigerator.GetRemainingWeight();

            currentWeightTextBox.Text = currentWeight.ToString();
            remainingWeightTextBox.Text = remainingWeight.ToString();
            noOfItemsTextBox.Text = "";
            weightTextBox.Text = "";
         }
        }
    }
