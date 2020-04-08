using System;

namespace Class_Library
{
    public class clsEmail
    {
        public bool SendEmail(string SenderEmail, string RecipientEmail, string SubjectLine, string Message)
        {
            clsDataConnection DB = new clsDataConnection("select * from tblEmail");
            //DB.NewRecord["SenderEmail"] = SenderEmail;
            //DB.NewRecord["RecipientEmail"] = RecipientEmail;
            //DB.NewRecord["SubjectLine"] = SubjectLine;
            //DB.NewRecord["Message"] = Message;
            //DB.AddNewRecord();
            //DB.SaveChanges();
            return true;
        }
    }
}