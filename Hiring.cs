using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Programming_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //method to clear everything
        public void clearEverything()
        {
            //clears everything that needs to be cleared
            NameProList.Items.Clear();
            LawyerRadioBtn.Checked = false;
            AgentRadioBtn.Checked = false;
            PersonalAssistantRadioBtn.Checked = false;
            TrainersRadioBtn.Checked = false;
            AthletePaidLabel.Text = "";
            AmountLeftLabel.Text = "";
            nameTxt.Text = "";
            names.Clear();
            salaries.Clear();
        }

        //method to close the program when the exit button is clicked
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        //this calls the method that is going to be executed to clear everything when the button is clicked
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearEverything();

            //this makes it to where the textbox containing the athlete's salary is not able to be edited
            YearSalaryTB.ReadOnly = true;

            //this sets the value of the global counter variable back to 0 so it can be used as a legitamate counter
            i = 0;
        }

        //declare the list for salaries
        List<decimal> salaries = new List<decimal>();

        //declare the list for names
        List<string> names = new List<string>();

        //this is a global counter variable so I can use the calBtn as a type of loop
        int i = 0;

        //This is the button that is pressed to add a professional based on the values entered
        private void CalBtn_Click(object sender, EventArgs e)
        {
            //This is the input validation for the professionals name, it ensures the name entered
            //contains no digits and is longer than one character
            if (!nameTxt.Text.Any(char.IsDigit)
                && nameTxt.Text.Length >= 2)
            {
                //this makes other parts of the form visible
                groupBox2.Visible = true;

                //this declares the variables that will hold the pay of each type of professional
                decimal lawyerPay = salary * 0.10m,
                    paPay = salary * 0.03m,
                    agentPay = salary * 0.07m,
                    trainerPay = salary * 0.05m,
                    totalPaid = 0,
                    amountLeft = 0;
                
                //this is an if statment that decides what salary the professional gets paid
                if (LawyerRadioBtn.Checked == true)
                {
                    //this is if the professional is a lawyer
                    names.Add(nameTxt.Text);
                    salaries.Add(lawyerPay);
                    NameProList.Items.Add(names[i] + " is making " + salaries[i].ToString("c"));
                    i++;
                } 
                else if (PersonalAssistantRadioBtn.Checked == true)
                {
                    //this is if the professional is a personal assistant
                    names.Add(nameTxt.Text);
                    salaries.Add(paPay);
                    NameProList.Items.Add(names[i] + " is making " + salaries[i].ToString("c"));
                    i++;
                } 
                else if (AgentRadioBtn.Checked == true)
                {
                    //this is if the professional is a agent
                    names.Add(nameTxt.Text);
                    salaries.Add(agentPay);
                    NameProList.Items.Add(names[i] + " is making " + salaries[i].ToString("c"));
                    i++;
                } 
                else if (TrainersRadioBtn.Checked == true)
                {
                    //this is if the professional is a trainer
                    names.Add(nameTxt.Text);
                    salaries.Add(trainerPay);
                    NameProList.Items.Add(names[i] + " is making " + salaries[i].ToString("c"));
                    i++;
                }
                else
                {
                    //this ensures a radio button is selected
                    MessageBox.Show("Please ensure a category for the professional is selected");
                }

                //this calculates the total amount the athlete has paid and displays it
                totalPaid = salaries.Sum();
                AthletePaidLabel.Text = totalPaid.ToString("c");

                //this calculates the amount the athlete has left and displays it
                amountLeft = salary - totalPaid;
                AmountLeftLabel.Text = amountLeft.ToString("c");



            } 
            else
            {
                //this is displayed if the professionals name is entered incorrectly
                MessageBox.Show("Please make sure the professionals name \nis entered correctly in the text box");
            }
            
        }

        //this is a global variable meant to store the athlete's salary
        decimal salary;

        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(YearSalaryTB.Text, out salary) 
                && salary >= 0)
            {
                //this starts off by making the rest of the form visible
                NameProList.Visible = true;
                label2.Visible = true;
                groupBox1.Visible = true;
                CalBtn.Visible = true;
                nameTxt.Visible = true;

                //this makes the salary textbox read only
                YearSalaryTB.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please ensure a positive number is entered as the salary");
            }

            

        }

        //this is the form loader event, the code here makes everything except the place where you enter the 
        //athletes salary invisible
        private void Form1_Load(object sender, EventArgs e)
        {
            NameProList.Visible = false;
            label2.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            CalBtn.Visible = false;
            nameTxt.Visible = false;
        }
    }
}
