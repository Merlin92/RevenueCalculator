/* Student Name: Merlin Bierekofen
 * Student ID: 14101805
 * Date: 30.09.2016
 * Assignment: 2

Note: The following task instructions were copied from the Assignment 2 insturction PDF-file.

Task: Stadium Seating

There are three seating categories at an athletic stadium.
For a football game:
Class A seats cost €16 each,
Class B seats cost €11 each,
Class C seats cost €8 each.

Create an application that allows the user to enter the number of tickets sold for each class.

  The application should be able to display the amount of income generated from each class
  of ticket sales and the total revenue generated.

  The application’s form should resemble the one shown below. (the original file showed a screenshot of the application)

  Change the Font properties of the labels to the font and size of your choice.
  
  Follow good programming conventions for object names: include remarks at the top of
  every method and at the top of the file.
  
  Give the stadium a name and display at the top of the form.
  
  Use GroupBox controls for “Tickets Sold” & “Revenue Generated”.
  
  Assign access keys to each button.
  
  Include code to handle invalid inputs errors
  
  Use currency formatting to display the results in euros.
  
  Include your name in the bottom right corner “Programmed by …………….”
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rev_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
           
                //declaring constant variables
                const decimal ASeatCost = 16m;
                const decimal BSeatCost = 11m;
                const decimal CSeatCost = 8m;

                
                int ClassA; //to hold sold cards Class A
                int ClassB; //to hold sold cards Class B
                int ClassC; //to hold sold cards Class C
                decimal RevClassA; //to hold revenue Class A
                decimal RevClassB; //to hold revenue Class B
                decimal RevClassC; //to hold revenue Class C
                decimal TotalRev; //to hold total revenue
 

            //this method tryies to catch input mistakes for ClassATickTextBox 
            if (int.TryParse(ClassATickTextBox.Text, out ClassA))
            {
                //this method tryies to catch input mistakes for ClassBTickTextBox 
                if (int.TryParse(ClassBTickTextBox.Text, out ClassB))
                {
                    //this method tryies to catch input mistakes for ClassCTickTextBox 
                    if (int.TryParse(ClassCTickTextBox.Text, out ClassC))
                    {

                        //this method calculates the revenue revenue of the different seat classes and the total revenue over all classes 
                        RevClassA = ClassA * ASeatCost;
                        RevClassB = ClassB * BSeatCost;
                        RevClassC = ClassC * CSeatCost;
                        TotalRev = RevClassA + RevClassB + RevClassC;

                        //this method shows the revenue of the different seat classes and the total revenue in the corresponding output labels 
                        AOutputLabel.Text = RevClassA.ToString("c");
                        BOutputLabel.Text = RevClassB.ToString("c");
                        COutputLabel.Text = RevClassC.ToString("c");
                        TotalOutputLabel.Text = TotalRev.ToString("c");
                    }
                    else
                    {
                        //display an error message for ClassCTickTextBox
                        MessageBox.Show("Invalid input for number of ticktes sold for Class C.");
                    }
                }
                else
                {
                    //display an error message for ClassBTickTextBox
                    MessageBox.Show("Invalid input for number of ticktes sold for Class B.");
                }
            }
            else
            {
                //display an error message for ClassATickTextBox
                MessageBox.Show("Invalid input for number of ticktes sold for Class A.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //this method clears the input of textboxes as well as the automatically displayed revenues in the output labels 
            ClassATickTextBox.Text = "";
            ClassBTickTextBox.Text = "";
            ClassCTickTextBox.Text = "";
            AOutputLabel.Text = "";
            BOutputLabel.Text = "";
            COutputLabel.Text = "";
            TotalOutputLabel.Text = "";

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //this method closes the application
            this.Close();
        }

    }
}
