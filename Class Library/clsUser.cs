using System;

namespace Class_Library
{
    public class clsUser
    {
        //this class provides info about the current user
        //member variables
        //their user name
        string mUserName;
        //member var for authentication
        Boolean mAuthenticated;
        //member var for email
        string mEmail;
        //member var for administrator
        Boolean mAdmin;
        //member var for first name
        string mFirstName;
        //member var for last name
        string mLastName;
        //declare a connection to the database
        clsDataConnection Users;
        Int32 mUserNo;
        //create an instance of the site info class to store important data about the site
        clsSiteInfo ThisSite = new clsSiteInfo();

        public clsUser(string Email, string Password)
        {
            //get the details for this user
            Users = new clsDataConnection("select * from Users where Email = '" + Email + "' and UserPassword = '" + Password + "'");
            //if there is one user found
            if (Users.Count > 0)
            {
                //flag authenticated as true
                mAuthenticated = true;
                //store the email address
                mEmail = Convert.ToString(Users.DataTable.Rows[0]["Email"]);
                //store the first name
                mFirstName = Convert.ToString(Users.DataTable.Rows[0]["FirstName"]);
                //store the User no
                mUserNo = Convert.ToInt32(Users.DataTable.Rows[0]["UserNo"]);
                //mLastName = Users.RecordNumber(0).Item("LastName")
                mAdmin = Convert.ToBoolean(Users.DataTable.Rows[0]["Administrator"]);
            }
            else
            {
                //else flag authenticated as false
                mAuthenticated = false;
            }
        }

        public clsUser()
        {
        }

        //returns the UserNo of the current user
        public Int32 UserNo
        {
            get
            {
                return mUserNo;
            }
            set
            {
                mUserNo = value;
            }
        }

        //this tells us if the current user is authenticated or not
        public Boolean Authenticated
        {
            get
            {
                return mAuthenticated;
            }
        }

        //this returns the email address of the current user
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        //gets the first name of the current user
        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        //return the last name
        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }

        //is the current user an administrator
        public Boolean Administrator
        {
            get
            {
                return mAdmin;
            }
            set
            {
                mAdmin = value;
            }
        }
    }
}