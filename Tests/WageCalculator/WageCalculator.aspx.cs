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
            //Declare variables
            //These are variables to capture user inputs(still good)
            string consultantName;
            string jobTitle;
            double baseBillingRate;
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

            if (MSCDCertificate.Text == "Yes")
            {
                isMCSD = true;
            }

            foreach (ListItem item in SkillsList.Items)
            {
                if (item.Selected)
                {
                    consultantSkills += item.Text + ", ";
                }
            }

            //ResultHTML.Text = consultantName + ", " + jobTitle + ", " + workHours;

            //==================Processing====================
            //Instantiate an employee object using a custom constructor. Make sure to follow the prompt.
            Consultant employee = new Consultant(consultantName, jobTitle, consultantSkills, isMCSD, workHours);
            
            //Let's call the method to calculate

            //This is required if you wish to use the weeklyWage in the output in the main. 
            weeklyWage = employee.CalculateWage(workHours);

            //==================Output=========================            

            ResultHTML.Text = employee.DisplayResult();
        }
    }
}