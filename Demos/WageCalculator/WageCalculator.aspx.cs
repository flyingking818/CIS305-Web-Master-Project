using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS305_Web_Master_Project.Demos.WageCalculator   
{
    public partial class WageCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            //============================INPUTS ========================
            //Declare variables
            //These are variables to capture user inputs(still good)
            string consultantName;
            string jobTitle;
            double baseBillingRate;  //conditional based on the job title.
            bool isMCSD = false;
            double workHours;
            string consultantSkills = "";

            //This is variable to store the result.
            double weeklyWage;

            //=============Let's get user inputs! :0)====================
            //The variable names out the Consultant class can be different. Most developers use the same

            consultantName = Name.Text;
            jobTitle = JobTitle.SelectedValue;
            workHours = double.Parse(WorkHours.Text);

            if (MCSDCertificate.Text == "Yes")
            {
                isMCSD = true;
            }

            //Concatenante the selected skills into one text string

            foreach (ListItem item in SkillsList.Items)
            {
                if (item.Selected) //Whether it's selected or not?
                {
                    consultantSkills += item.Text + ", ";
                }
            }

            //======================PROCESSING========================
            //Here, we're using the black box approach (class)

            //Instantiate an employee object using a custom constructor. Make sure to follow the prompt.
            Consultant employee = new Consultant(consultantName, jobTitle, consultantSkills, isMCSD, workHours);

            //This is preferred if you wish to use the outcome of the method somewhere else.
            //weeklyWage = employee.CalculateWage(workHours);

            //isFairPay = Assessment.Evaluate(weeklyWage)
            
            ResultHTML.Text = employee.DisplayResult();

        }
    }

    //Option 1 - Create your Consultant Class here.

}

