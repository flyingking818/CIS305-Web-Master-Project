using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS305_Web_Master_Project.Demos.WageCalculator
{
    public class Consultant
    {
        //Declaration - this is a better location for the constants to be used by all members of the class.
        const double NORMAL_HOURS = 40;
        const double MCSD_RATE = 0.1;
        const double OVERTIME_RATE = 0.5;

        //Construct some properties based on user inputs/output needs
        //Properties for storing input values
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string SkillSets { get; set; }
        public bool IsMCSD { get; set; }
        public double WorkHours { get; set; }

        //Property for processing result
        public double BillingRate { get; set; }
        //Property for output display
        public double WeeklyWage { get; set; }

        //Let's create a custom constructor
        //The constructor name needs to be the same as your class name!
        public Consultant(string name, string jobTitle, string skillSets, bool isMCSD, double workHours)
        {
            //Store the values in the properties (public)
            Name = name;
            JobTitle = jobTitle;
            SkillSets = skillSets;
            IsMCSD = isMCSD;
            WorkHours = workHours;
        }

        //Create some custom methods for processing and output

        //Custom method 1 - Calculator brain (processing)
        public virtual double CalculateWage(double workHours)
        {
            //put these into a method 
            switch (JobTitle)
            {
                case "JobCode1":
                    BillingRate = 80; //develper
                    break;
                case "JobCode2":
                    BillingRate = 100; //Analyst
                    break;
                case "JobCode3":
                    BillingRate = 120; //Architect
                    break;
                case "JobCode4":
                    BillingRate = 150; //Project lead
                    break;
                default:
                    BillingRate = 80;  //By default, developer rate
                    break;  //Don't forget the break for C#, Swift does not need it.
            }

            if (IsMCSD)
            {
                BillingRate = BillingRate * (1 + MCSD_RATE);
            }

            //CalBrain (the main logic) -- encapsulate this in a method! :)
            if (workHours > NORMAL_HOURS)
            {
                WeeklyWage = BillingRate * NORMAL_HOURS +
                    BillingRate * (1 + OVERTIME_RATE) * (workHours - NORMAL_HOURS);
            }
            else
            {
                WeeklyWage = BillingRate * workHours;
            }

            return WeeklyWage;  //return the final result back to the calling method
        }

        //Custom method 2 - Display the outputs

        public virtual string DisplayResult()
        {
            //Can do the calculate method here.
            WeeklyWage = CalculateWage(WorkHours);
            //Traditionally, in ASP.NET we use string concatenation to build an HTML output.

            //Remove the extra trailing characters of the consultant skills string
            //We are doing string manipulation with C#, each character is 1 byte, consisting of 8 bits.
            SkillSets = SkillSets.Substring(0, SkillSets.Length - 2);

            /* The conditional operator ?:, also known as the ternary conditional operator, evaluates a Boolean expression and 
            returns the result of one of the two expressions*/
            string certification = IsMCSD ? "Certifed" : "Not Certified";

            string htmlOutput = "Thank you, <strong>" + Name + "</strong> for using the wage calculator! ";
            htmlOutput += "Based on your selected profile - " + GetJobTitleText(JobTitle) + ", your MCSD certifiate status (" + certification + "), ";
            htmlOutput += " skills applied - " + SkillSets + ", and " + WorkHours + " work hours,";
            htmlOutput += " your weekly salary is - <strong>" + WeeklyWage.ToString("C") + "</strong>.";

            if (WorkHours > NORMAL_HOURS)
            {   //demo codes for embedding formulas directly in the output message.
                htmlOutput += "<br>Your overtime hours this week are " +
                    (WorkHours - NORMAL_HOURS) + ", and your overtime payment is <strong>" +
                    ((WorkHours - NORMAL_HOURS) * BillingRate * (1 + OVERTIME_RATE)).ToString("C") + "</strong>.";
            }

            return htmlOutput;
        }

        public string GetJobTitleText(string jobTitle)
        {
            switch (jobTitle) {
                case "JobCode1":
                    return "Developer";                    
                case "JobCode2":
                    return "Analyst";                   
                case "JobCode3":
                    return "Architect";                   
                case "JobCode4":
                    return "Project Lead";                   
                default:
                    return "Error";                   
            }
        }

    }
}