using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyDialogs; // initialises the 'My Dialogs' class, for inputbox control.

namespace Credit_Counter
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            int CostofCredit = Convert.ToInt32(My_Dialogs.InputBox("Please enter a credit cost, above '0'.")); // When the program runs, the user is prompted to enter their chosen credit cost.
            while (CostofCredit <= 0) // This begins a loop, if the entered cost is 0 or below.
            {
                MessageBox.Show("Error! Please enter a credit cost above 0");
                CostofCredit = Convert.ToInt32(My_Dialogs.InputBox("Please enter a credit cost above '0'.")); // The user is prompted until they input a valid integer.
            }
            MessageBox.Show("Welcome to the Credit Counter!");
            textBox_Credit_Cost.Text = CostofCredit.ToString(); // Once validated, the loop ends and their value is inputted into the relevant textbox.

            int NumberOfCredits;
            NumberOfCredits = CostofCredit;
        }

        private void btn_1p_Buy_Click(object sender, EventArgs e)
        {
            
                int OnePenceCount = int.Parse(label_OnePenceCount.Text);
                OnePenceCount++; 
                label_OnePenceCount.Text = OnePenceCount.ToString(); //This sequence of code simply increments the coin counter by one with each click, to represent how many the user has selected. The code, with the exception of variable names and output targets, is uniform for each coin.

                int OnePenceValue = int.Parse(textBox_Total_Pence_Value.Text);
                OnePenceValue++;
                textBox_Total_Pence_Value.Text = OnePenceValue.ToString(); //This adds up the value of the coin, in this case, 1 pence, and adds it to the total pence value selected so far. The code works in the same way for the rest of the coins.

                double OnePenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
                OnePenceValue_InPounds = OnePenceValue_InPounds + 0.01;
                textBox_Total_Pounds_Value.Text = OnePenceValue_InPounds.ToString(); //This adds the value of the coin too, but this time in pounds and pence, a decimal figure. It is then displayed in an appropriate textbox.

                int  CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
                int Credits = OnePenceValue / CreditCount;
                textBox_Credit_Counter.Text = Credits.ToString(); // This creates a new integer out of the user specified credit cost, and divides that by the total in pence to give an amount of current credits.
        }


        private void btn_2p_Buy_Click(object sender, EventArgs e)
        {
            int TwoPenceCount = int.Parse(label_TwoPenceCount.Text);
            TwoPenceCount++;
            label_TwoPenceCount.Text = TwoPenceCount.ToString();


            int TwoPenceValue = int.Parse(textBox_Total_Pence_Value.Text);
            TwoPenceValue = TwoPenceValue + 2;
            textBox_Total_Pence_Value.Text = TwoPenceValue.ToString();

            double TwoPenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            TwoPenceValue_InPounds = TwoPenceValue_InPounds + 0.02;
            textBox_Total_Pounds_Value.Text = TwoPenceValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = TwoPenceValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_5p_Buy_Click(object sender, EventArgs e)
        {
            int FivePenceCount = int.Parse(label_FivePenceCount.Text);
            FivePenceCount++;
            label_FivePenceCount.Text = FivePenceCount.ToString();

            int FivePenceValue = int.Parse(textBox_Total_Pence_Value.Text);
            FivePenceValue = FivePenceValue + 5;
            textBox_Total_Pence_Value.Text = FivePenceValue.ToString();

            double FivePenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            FivePenceValue_InPounds = FivePenceValue_InPounds + 0.05;
            textBox_Total_Pounds_Value.Text = FivePenceValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = FivePenceValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_10p_Buy_Click(object sender, EventArgs e)
        {
            int TenPenceCount = int.Parse(label_TenPenceCount.Text);
            TenPenceCount++;
            label_TenPenceCount.Text = TenPenceCount.ToString();

            int TenPenceValue = int.Parse(textBox_Total_Pence_Value.Text);
            TenPenceValue = TenPenceValue + 10;
            textBox_Total_Pence_Value.Text = TenPenceValue.ToString();

            double TenPenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            TenPenceValue_InPounds = TenPenceValue_InPounds + 0.10;
            textBox_Total_Pounds_Value.Text = TenPenceValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = TenPenceValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_20p_Buy_Click(object sender, EventArgs e)
        {
            int TwentyPenceCount = int.Parse(label_TwentyPenceCount.Text);
            TwentyPenceCount++;
            label_TwentyPenceCount.Text = TwentyPenceCount.ToString();

            int TwentyPenceValue = int.Parse(textBox_Total_Pence_Value.Text);
            TwentyPenceValue = TwentyPenceValue + 20;
            textBox_Total_Pence_Value.Text = TwentyPenceValue.ToString();

            double TwentyPenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            TwentyPenceValue_InPounds = TwentyPenceValue_InPounds + 0.20;
            textBox_Total_Pounds_Value.Text = TwentyPenceValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = TwentyPenceValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_50p_Buy_Click(object sender, EventArgs e)
        {
            int FiftyPenceCount = int.Parse(label_FiftyPenceCount.Text);
            FiftyPenceCount++;
            label_FiftyPenceCount.Text = FiftyPenceCount.ToString();

            int FiftyPenceValue = int.Parse(textBox_Total_Pence_Value.Text);
            FiftyPenceValue = FiftyPenceValue + 50;
            textBox_Total_Pence_Value.Text = FiftyPenceValue.ToString();

            double FiftyPenceValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            FiftyPenceValue_InPounds = FiftyPenceValue_InPounds + 0.50;
            textBox_Total_Pounds_Value.Text = FiftyPenceValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = FiftyPenceValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_One_Pound_Buy_Click(object sender, EventArgs e)
        {
            int OnePoundCount = int.Parse(label_OnePoundCount.Text);
            OnePoundCount++;
            label_OnePoundCount.Text = OnePoundCount.ToString();

            int OnePoundValue = int.Parse(textBox_Total_Pence_Value.Text);
            OnePoundValue = OnePoundValue + 100;
            textBox_Total_Pence_Value.Text = OnePoundValue.ToString();

            double OnePoundValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            OnePoundValue_InPounds = OnePoundValue_InPounds + 1.00;
            textBox_Total_Pounds_Value.Text = OnePoundValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = OnePoundValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

        private void btn_Two_Pound_Buy_Click(object sender, EventArgs e)
        {
            int TwoPoundCount = int.Parse(label_TwoPoundCount.Text);
            TwoPoundCount++;
            label_TwoPoundCount.Text = TwoPoundCount.ToString();

            int TwoPoundValue = int.Parse(textBox_Total_Pence_Value.Text);
            TwoPoundValue = TwoPoundValue + 200;
            textBox_Total_Pence_Value.Text = TwoPoundValue.ToString();

            double TwoPoundValue_InPounds = double.Parse(textBox_Total_Pounds_Value.Text);
            TwoPoundValue_InPounds = TwoPoundValue_InPounds + 2.00;
            textBox_Total_Pounds_Value.Text = TwoPoundValue_InPounds.ToString();

            int CreditCount = Convert.ToInt32(textBox_Credit_Cost.Text);
            int Credits = TwoPoundValue / CreditCount;
            textBox_Credit_Counter.Text = Credits.ToString();
        }

    }
}
