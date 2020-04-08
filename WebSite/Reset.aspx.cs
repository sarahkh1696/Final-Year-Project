using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Class_Library;
public partial class Reset : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //create an instance of the site infor class to store important data about the site
    clsSiteInfo ThisSite = new clsSiteInfo();
    //used to store the details of the current user
    clsUser TheCurrentUser = new clsUser();

    protected void btnDone_Click(object sender, EventArgs e)
    {
        //redirects to the main page
        Response.Redirect("MainForm.aspx");
    }


    protected void btnResetPassword_Click(object sender, EventArgs e)
    {

        //this event is triggered when the user presses the reset my password button
        //var to store the email address
        string Email;
        //var to store the password
        string Password;
        //var to flag if email sent ok
        Boolean Success;
        //clear the error message label
        lblError.Text = "";
        //get the email entered by the user
        Email = txtEmail.Text;
        //get the password for this address
        Password = GetPassword(Email);
        //if the password is not blank i.e. is found
        if (Password != "")
        {
            //try to send the password to the email address
            Success = SendPassword(Email, Password);
            //if the email was sent
            if (Success == true)
            {
                //inform the user
                lblError.Text = "Your password has been sent to your email address.";
            }
            else
            {
                //otherwise display an error
                lblError.Text = "There was a problem sending your password.";
            }
        }
        else
        {
            //the email address was found on the system
            lblError.Text = "Your password has been sent to your email address."; ;
        }

    }

    private bool SendPassword(string Email, string Password)
    {
        //this function sends the password to the specified email address
        Boolean Success;
        //create an instance of my email object
        clsEmail AnEmail = new clsEmail();
        //send the email - success will contain true or fals depending on if it works or not
        Success = AnEmail.SendEmail("sarah.alkhawaja@yahoo.com", Email, "Your QT password", "Your password is " + Password);
        //return success
        return Success;
    }

    private string GetPassword(string Email)
    {
        //this function looks up the password for the specified email address
        //create a connection to the database table selecting records with this email address only
        clsDataConnection AUser = new clsDataConnection("select * from users where email='" + Email + "'");
        //var to store the password
        string Password;
        //if one user is found i.e. only one record
        if (AUser.Count == 1)
        {
            //get the password from the database
            Password = (string)AUser.DataTable.Rows[0]["UserPassword"];
            //return the password
            return Password;
        }
        else
        {
            //password not found so return a blank string
            return "";
        }
    }
}