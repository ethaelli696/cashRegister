using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class inputDrinks : Form
    {
        //create the variables
        double burger = 2.49;
        double drinks = 0.99;
        double fries = 1.89;
        int numberofburger;
        int numberofdrinks;
        int numberoffries;
        double subtotal;
        double tax;
        double total;

        public inputDrinks()
        {
            InitializeComponent();
            
        }

        private void calculateTotals_Click_1(object sender, EventArgs e)
        {
            

            //input
            try
            {
                numberofburger = Convert.ToInt16(inputBurgers.Text);
                numberofdrinks = Convert.ToInt16(inputdrink.Text);
                numberoffries = Convert.ToInt16(InputFries.Text);
                subtotal = burger + numberofburger + drinks * numberofdrinks + fries * numberoffries;
                errorbox.Text = "Program Functional";
            }
            catch
            {
                errorbox.Text = "Error. You must select an integer.";
                subtotal = 1;
            }
            
            //size selector
            try
            {
                switch (mealSize.Text)
                {
                    case "Small - Included":
                        subtotalLabel.Text = "Subtotal: $" + subtotal;
                        errorbox.Text = "Program Functional";
                        break;
                    case "Medium - Add $1":
                        subtotal++;
                        subtotalLabel.Text = "Subtotal: $" + subtotal;
                        errorbox.Text = "Program Functional";
                        break;
                    case "Large - Add $3":
                        subtotal = subtotal + 3;
                        subtotalLabel.Text = "Subtotal: $" + subtotal;
                        errorbox.Text = "Program Functional";
                        break;
                    default:
                        if (errorbox.Text == "Error. You must select an integer.")
                        {
                            errorbox.Text = "You must only input integers and select a size.";
                        }
                        else
                        {
                            errorbox.Text = "You must pick a size!";
                        }
                        break;
                }
            }
            catch
            {
                totalLabel.Text = "Error";
            }

            //tax
            tax = subtotal * 0.13;
            total = subtotal + tax;
            taxLabel.Text = "Tax: $" + tax;
            totalLabel.Text = "Total: $" + total;
            }

        private void changeButton_Click(object sender, EventArgs e)
        {
            //more variables
            double tender;
            double change;
            try
            {
                tender = Convert.ToDouble(tenderBox.Text);
                change = -total + tender;
                changeLabel.Text = "Change: $" + change;
                errorbox.Text = "Program Functional";
            }
            catch
            {
                errorbox.Text = "Only input integers!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create graphics objects
            
        }
    }
    }
    
