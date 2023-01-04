using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class BusinessLogicaLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        //frmRole
        public int InsertRoleDescription(Role role)
        {
            return dal.InsertRoleDescription(role);
        }

        public DataTable GetRoleDescription()
        {
            return dal.GetRoleDescription();
        }

        public int UpdateRoleDescription(Role update)
        {
            return dal.UpdateRoleDescription(update);  
        }

        //frmLecturer Solution
        public int InsertSolution(Solution solution)
        {
            return dal.InsertSolution(solution);
        }

        public DataTable GetSolutioncmb()
        {
            return dal.GetSolutioncmb();
        }

        public int UPDATE(Solution update)
        {
            return dal.UPDATE(update);
        }

        public int SolutionDelete(Solution Delete)
        {
            return dal.SolutionDelete(Delete);
        }

        public DataTable GetSolution()
        {
            return dal.GetSolution();
        }

        //frmLecturer Error Solution

        public int InsertErrorSolution(ErrorSolution errorSolution)
        {
            return dal.InsertErrorSolution(errorSolution);
        }

        public DataTable GetErrorSolution()
        {
            return dal.GetErrorSolution();
        }


        public DataTable GetErrorID()
        {
            return dal.GetErrorID();
        }

        public int UPDATEERRORSOLUTION(ErrorSolution updateErrorSolution)
        {
            return dal.UPDATEERRORSOLUTION(updateErrorSolution);
        }

        public int DeleteErrorSolution(ErrorSolution hardDelete)
        {
            return dal.DeleteErrorSolution(hardDelete);
        }

        public DataTable GetErrorSolutionDgvv()
        {
            return dal.GetErrorSolutionDgvv();
        }
        //frmLogin
        public DataTable GetLogin(string email, string password)
        {
            return dal.GetLogin(email, password);

        }
        //frmUser/Registration
        public DataTable GetUser()
        {
            return dal.GetUser();
        }
        public DataTable GetUsername()
        {
            return dal.GetUsername();
        }
        public int UpdateStudent(Error error)
        {
            return dal.UpdateStudent(error);
        }
        public int DeleteStudent(Error error)
        {
            return dal.DeleteStudent(error);
        }
        public int InsertUser(User userError)
        {
            return dal.InsertUser(userError);
        }
        public DataTable GetUserBySelect()
        {
            return dal.GetUserBySelect();
        }
        public DataTable GetUserByID()
        {
            return dal.GetUserByID();
        }
        public int DelectUser(User userError)
        {
            return dal.DelectUser(userError);
        }
        public int InsertStudent(Error error)
        {
            return dal.InsertStudent(error);
        }
        public DataTable GetStudent()
        {
            return dal.GetStudent();
        }
        public DataTable StudyYear()
        {

            return dal.StudyYear();
        }

        //frmStudent
        public DataTable GetError()
        {
            return dal.GetError();
        }
        public int DelectError(Error userErrorD)
        {
            return dal.DelectError(userErrorD);
        }
       
        public int InsertError(Error userError)
        {
            return dal.InsertError(userError);
        }
        public int UpdateUser(User userError)
        {
            return dal.UpdateUser(userError);
        }
        public int UpdateError(Error userError)
        {
            return dal.UpdateError(userError);
        }
      

        // frmProgLanguage 

        public int InsertProgLanguage(ProgLang progLang)
        {
            return dal.InsertProgLanguage(progLang);
        }
        public DataTable GetProgLanguage() // ok
        {
            return dal.GetProgLanguage();
        }
        public int DeleteProgLanguage(ProgLang progLangID)
        {
            return dal.DeleteProgLanguage(progLangID);
        }
        public int UpdateProgLanguage(ProgLang progLangID, ProgLang progLang)
        {
            return dal.UpdateProgLanguage(progLangID, progLang);
        }

        //frmTopic
       public int InsertTopic(Topic topic)
        {
            return dal.InsertTopic(topic);
        }

        public int UpdateTopic(Topic update)
        {
            return dal.UpdateTopic(update);
        }

        public DataTable GetTopicDgv()
        {
            return dal.GetTopicDgv();
        }


        //frmYear
        public DataTable GetYearStudy()
        {
            return dal.GetYearStudy();
        }
        public int InsertYearStudy(Year year)
        {
            return dal.InsertYearStudy(year);
        }
        public int UpdateYearStudy(Year year)
        {
            return dal.UpdateYearStudy(year);
        }
        public int DeleteYearStudy(Year year)
        {
            return dal.DeleteYearStudy(year);
        }
        
        

        //frmTopicModule
        public DataTable GetTopicModule()
        {
            return dal.GetTopicModule();
        }
        public DataTable GetModule()
        {
            return dal.GetModule();
        }
        public DataTable GetTopic()
        {
            return dal.GetTopicDgv();
        }
        public int InsertModuleTopic(ModuleTopic moduleTopic)
        {
            return dal.InsertModuleTopic(moduleTopic);
        }
        public int UpdateModuleTopic(ModuleTopic moduleTopic)
        {
            return dal.UpdateModuleTopic(moduleTopic);
        }
        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            return dal.DeleteModuleTopic(moduleTopic);
        }

        //frmModule

        public int InsertModule(Module module)
        {
            return dal.InsertModule(module);
        }

        public int UpdateModule(Module module)
        {
            return dal.UpdateModule(module);
        }

        public int DeleteModule(Module delete)
        {
            return dal.DeleteModule(delete);
        }

        //SearchUser

        public DataTable SearchUser(string search)
        {
            return dal.SearchUser(search);
        }

        //SearchError

        public DataTable SearchError(string searchE)
        {
            return dal.SearchError(searchE);
        }

        //SearchProgLang

        public DataTable SearchErrorProg(string searchP)
        {
            return dal.SearchErrorProg(searchP);
        }

        //SearchTopicError

        public DataTable SearchTopicError(string searchT)
        {
            return dal.SearchTopicError(searchT);
        }

        //GetLecturer

        public DataTable Lecturercmb()
        {
            return dal.Lecturercmb();
        }
        //GetStudent

        public DataTable Studentcmb()
        {
            return dal.Studentcmb();
        }

        //Timetable 

      

        public int UpdateTime(Office update)
        {
            return dal.UpdateTime(update);
        }

        public int InsertTime(Office office)
        {
            return dal.InsertTime(office);
        }

        public DataTable GetTimetable()
        {
            return dal.GetTimetable();
        }
    }
}
