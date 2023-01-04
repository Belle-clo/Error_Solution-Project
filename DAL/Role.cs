using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Role
    {
       public int RoleID { get; set; }
       public string RoleDescription { get; set; }
    }

    public class Solution
    {
        public int SolutionID { get; set; }
        public string SolutionDescription { get; set; }
        public int LecturerID{ get; set; }
    }

    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string UserStatus { get; set; }

    }

    public class ErrorSolution
    {
        public int ErrorSolutionID { get; set; }
        public int ErrorID { get; set; }
        public int SolutionID { get; set; }
        public string SolutionDate { get; set; }

    }
   

    // this is for the Error Description and Error ID
    public class Error
    {
        public int ErrorID { get; set; }
        public string ErrorDescription { get; set; }
        public int ProgLanguageID { get; set; }
        public int StudentID { get; set; }
        public int ModuleID { get; set; }
        public int YearID { get; set; }
        public string ErrorStatus { get; set; }
        public int TopicID { get; set; }
        public string ErrorDate { get; set; }


    }

    public class ProgLang
    {
        public string ProgLangDesc { get; set; }
        public int ProgLanguageID { get; set; }

        public ProgLang()
        {

        }
        public ProgLang(string progLangDesc, int progLangID)
        {
            this.ProgLangDesc = progLangDesc;
            this.ProgLanguageID = progLangID;
        }

    }

    public class  Topic
    {
        public int TopicID { get; set; }
        public string TopicDescription { get; set; }
    }

    public class ModuleTopic
    {
        public int ModuleTopicID { get; set; }
        public int ModuleID { get; set; }
        public string ModuleDescription { get; set; }
        public int TopicID { get; set; }
        public string TopicDescription { get; set; }


        public ModuleTopic()
        {

        }

        public ModuleTopic(string moduleDescription, int ModuleID, int ModuleTopicID, int TopicID, string TopicDescription)
        {
            this.ModuleDescription = moduleDescription;
            this.ModuleID = ModuleID;
            this.ModuleTopicID = ModuleTopicID;
            this.TopicID = TopicID;
            this.TopicDescription = TopicDescription;
        }
    }
    public class Year
    {


        public int YearID { get; set; }
        public string YearDescription { get; set; }

        public Year(int YearID, string YearDescription)
        {
            this.YearID = YearID;
            this.YearDescription = YearDescription;
        }

        public Year()
        {
        }
    }


    public class Module
    {
        public int ModuleID { get; set; }
        public string ModuleDescription { get; set; }
        public int YearID { get; set; }

    }

    public class Office
    {
        public int TimetableID { get; set;}
        public string OfficeDescription { get; set;}
        public string Time { get; set;}
        public string Day { get; set;}
        public int YearID { get; set;}
        public int ModuleID { get; set;}
    }

}
