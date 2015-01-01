using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefrigeratorUIApp
{
    class Refrigerator
    {
        public Refrigerator()
        {
            CurrentWeight = 0;
        }

        public double MaxWeight { private get; set; }
        public double CurrentWeight { get; private set; }

        public void AddWeight(double weight)
        {
            if (CurrentWeight + weight > MaxWeight)
            {
                MessageBox.Show("Your given weight is more then maximum weight.");
            }
            else
            {
                CurrentWeight += weight;
            }
        }

        public double GetTotalWeight(int noOfItems, double weight)
        {
            return noOfItems * weight;
        }

        public double GetRemainingWeight()
        {
            return MaxWeight - CurrentWeight;
        }
    }
}
