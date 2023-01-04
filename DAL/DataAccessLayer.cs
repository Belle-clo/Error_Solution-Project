using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source = localhost;Initial Catalog= ErrorProjectDB;Integrated Security = true";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;        
        SqlDataAdapter dbAdapter;
        DataTable dt;

        //frmRole

        public int InsertRoleDescription(Role role)
        {
            try
            {
                dbConn.Open();
            }

            catch
            {

            }

            string sql = "sp_InsertRoleDescription";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetRoleDescription()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetRoleDescription";
            dbComm = new SqlCommand(sql, dbConn);
           
            
            
            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;

        }

        public int UpdateRoleDescription( Role update)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            string sql = "sp_UpdateRoleDescription";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@RoleDescription", update.RoleDescription);
            dbComm.Parameters.AddWithValue("@RoleID", update.RoleID);
           


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }



        //frmLecturer

        public int InsertSolution(Solution solution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            string sql = "sp_InsertSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@SolutionDescription", solution.SolutionDescription);
            dbComm.Parameters.AddWithValue("@LecturerID", solution.LecturerID);



            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetSolutioncmb()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetCmbSoltuionName";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }

        public int UPDATE(Solution update)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            string sql = "sp_UpdateSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@SolutionDescription", update.SolutionDescription);
            dbComm.Parameters.AddWithValue("@LecturerID", update.LecturerID);
            dbComm.Parameters.AddWithValue("@SolutionID", update.SolutionID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertStudent(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertStudent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentID", error.StudentID);
            dbComm.Parameters.AddWithValue("@ErrorDescription", error.ErrorDescription);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", error.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ModuleID", error.ModuleID);
            dbComm.Parameters.AddWithValue("@YearID", error.YearID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);
            dbComm.Parameters.AddWithValue("@TopicID",error.TopicID);
            dbComm.Parameters.AddWithValue("@ErrorDate", error.ErrorDate);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public DataTable GetStudent()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetStudent";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }
        public DataTable StudyYear()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetYear";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }
        public int UpdateStudent(Error error)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            string sql = "sp_UpdateStudent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", error.ErrorID);
            dbComm.Parameters.AddWithValue("@StudentID", error.StudentID);
            dbComm.Parameters.AddWithValue("@ErrorDescription", error.ErrorDescription);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", error.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ModuleID", error.ModuleID);
            dbComm.Parameters.AddWithValue("@YearID", error.YearID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);
            dbComm.Parameters.AddWithValue("@TopicID", error.TopicID);
            dbComm.Parameters.AddWithValue("@ErrorDate", error.ErrorDate);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteStudent(Error error)
        {


            string sql = "sp_DelectStudent";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ErrorID",error.ErrorID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int SolutionDelete(Solution Delete)
        {


            string sql = "sp_DeleteSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@SolutionID",Delete.SolutionID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public DataTable GetSolution()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetSolutionDgv";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }

        //frmLecturer ErrorSolution


        public int InsertErrorSolution(ErrorSolution errorSolution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_InsertErrorSolution";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;

          
            dbComm.Parameters.AddWithValue("@ErrorID", errorSolution.ErrorID);
            dbComm.Parameters.AddWithValue("@SolutionID", errorSolution.SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", errorSolution.SolutionDate);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public DataTable GetErrorSolution() //to fill cmb Error Solution
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetErrorSolution";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetErrorID() //to fill cmb Error 
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetErrorcmb";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }


        public int UPDATEERRORSOLUTION(ErrorSolution updateErrorSolution)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }


            string sql = "sp_UpdateErrorSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorID", updateErrorSolution.ErrorID);
            dbComm.Parameters.AddWithValue("@SolutionID", updateErrorSolution.SolutionID);
            dbComm.Parameters.AddWithValue("@SolutionDate", updateErrorSolution.SolutionDate);
            dbComm.Parameters.AddWithValue("@ErrorSolutionID", updateErrorSolution.ErrorSolutionID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public int DeleteErrorSolution(ErrorSolution hardDelete)
        {


            string sql = "sp_DeleteErrorSolution";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ErrorSolutionID", hardDelete.ErrorSolutionID);

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public DataTable GetErrorSolutionDgvv() //get dgv
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetErrorSolutionDgv";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }
        public DataTable GetLogin(string email, string password)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }
            string sql = "sp_GetLogin";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", email);
            dbComm.Parameters.AddWithValue("@Password", password);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUser()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUserBySelect()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "GetUserBySelect";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetProgLanguage()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUsername()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetUsername";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetYearStudy()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetYearOfStudy";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetTopicModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_GetTopicModule";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUserByID()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }
            string sql = "sp_SeletRole";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);           
            dbConn.Close();
            return dt;
        }
        public DataTable GetError()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
            }
            string sql = "sp_GetError";
            dbComm = new SqlCommand(sql, dbConn);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public int DelectUser(User userError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userError.UserID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DelectError(Error userErrorD)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteError";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ErrorID", userErrorD.ErrorID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int InsertUser(User user)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@RoleID", user.RoleID);
            dbComm.Parameters.AddWithValue("@Username", user.Username);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);
            dbComm.Parameters.AddWithValue("@UserStatus", user.UserStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertError(Error userError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertError";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ErrorDescription", userError.ErrorDescription);
            dbComm.Parameters.AddWithValue("@UserID", userError.StudentID);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", userError.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@TopicModuleID", userError.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ErrorStatus", userError.ProgLanguageID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateUser(User userError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateUser";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@UserID", userError.UserID);
            dbComm.Parameters.AddWithValue("@Username", userError.Username);
            dbComm.Parameters.AddWithValue("@Surname", userError.Surname);
            dbComm.Parameters.AddWithValue("@Email", userError.Email);
            dbComm.Parameters.AddWithValue("@Password", userError.Password);
            dbComm.Parameters.AddWithValue("@UserStatus", userError.UserStatus);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateError(Error userError)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateError";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ErrorDescription", userError.ErrorDescription);
            dbComm.Parameters.AddWithValue("@ProgLanguageID", userError.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ErrorID", userError.ErrorID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        //frmTopic

        public int InsertTopic(Topic topic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertTopicDesription";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TopicDescription", topic.TopicDescription);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;

        }

        public int UpdateTopic(Topic update)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateTopic";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TopicID", update.TopicID);
            dbComm.Parameters.AddWithValue("@TopicDescription", update.TopicDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public DataTable GetTopicDgv() // dgvtopic 
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_GetTopicDgv";
            dbComm = new SqlCommand(sql, dbConn);

            dt = new DataTable();
            dbAdapter = new SqlDataAdapter(dbComm);
            dbAdapter.Fill(dt);

            return dt;
        }
        //frmModule

        public DataTable GetModule()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetModuleDgv", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }




        //frmProgLanguage

        public int InsertProgLanguage(ProgLang progLang)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ProgLanguageDesc",progLang.ProgLangDesc);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;

        }

        

        public int UpdateProgLanguage(ProgLang progLangID, ProgLang progLang)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateProgLanguage";
            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProgLanguageID",progLangID.ProgLanguageID);
            dbComm.Parameters.AddWithValue("@ProgLanguageDesc", progLang.ProgLangDesc);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;




        }

        public int DeleteProgLanguage(ProgLang progLangID)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {
               
            }
            dbComm = new SqlCommand("sp_DeleteProgLang", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ProgLanguageID", progLangID.ProgLanguageID);
           


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;



        }

        //frmModuleTopic

        public int InsertModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_InsertModuleTopic", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", moduleTopic.ModuleID);
            dbComm.Parameters.AddWithValue("@TopicID", moduleTopic.TopicID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
        public int UpdateModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {


            }

            dbComm = new SqlCommand("sp_UpdateModuleTopic", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@TopicModuleID", moduleTopic.ModuleTopicID);
            dbComm.Parameters.AddWithValue("@ModuleID", moduleTopic.ModuleID);
            dbComm.Parameters.AddWithValue("@TopicID", moduleTopic.TopicID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }
        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteModuleTopic", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTopicID", moduleTopic.ModuleTopicID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int InsertYearStudy(Year year)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertYearOfStudy", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@YearDescription", year.YearDescription);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int UpdateYearStudy(Year year)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_UpdateYearOfStudy", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@YearID", year.YearID);
            dbComm.Parameters.AddWithValue("@YearDescription", year.YearDescription);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }
        public int DeleteYearStudy(Year year)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_DeleteYearOfStudy", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@YearID", year.YearID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        //frmModule

        public int InsertModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }
            dbComm = new SqlCommand("sp_InsertModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);
            dbComm.Parameters.AddWithValue("@YearID", module.YearID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateModule(Module module)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {


            }

            dbComm = new SqlCommand("sp_UpdateModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            dbComm.Parameters.AddWithValue("@YearID", module.YearID);
            dbComm.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;

        }


        public int DeleteModule(Module delete)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_DeleteModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", delete.ModuleID);
            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

         //SearchUser

        public DataTable SearchUser(string search)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_Search", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Searchterm", search);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //SearchError
        public DataTable SearchError(string searchE)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_SearchError", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Searchterm",searchE);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Search Topic Error
        public DataTable SearchTopicError(string  searchT)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_SearchErrorTopic", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Searchterm", searchT);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

        

        //GetLecturer name
     

        public DataTable Lecturercmb()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetLecturer", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //Get ErrorProgLang

        public DataTable SearchErrorProg(string searchP)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_SearchErrorProg", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Searchterm", searchP);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        //GetStudent name

        public DataTable Studentcmb()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetStudentName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        //TimeTable


        public int InsertTime(Office office)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_TimeTable";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;


            
            dbComm.Parameters.AddWithValue("@OfficeDescription", office.OfficeDescription);
            dbComm.Parameters.AddWithValue("@Time", office.Time);
            dbComm.Parameters.AddWithValue("@Day", office.Day);
            dbComm.Parameters.AddWithValue("@YearID", office.YearID);
            dbComm.Parameters.AddWithValue("@ModuleID", office.ModuleID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public int UpdateTime(Office update)
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            string sql = "sp_UpdateTimetable";
            dbComm = new SqlCommand(sql, dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;


            dbComm.Parameters.AddWithValue("@TimetableID", update.TimetableID);
            dbComm.Parameters.AddWithValue("@OfficeDescription", update.OfficeDescription);
            dbComm.Parameters.AddWithValue("@Time", update.Time);
            dbComm.Parameters.AddWithValue("@Day", update.Day);
            dbComm.Parameters.AddWithValue("@YearID",update.YearID);
            dbComm.Parameters.AddWithValue("@ModuleID", update.ModuleID);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }


        public DataTable GetTimetable()
        {
            try
            {
                dbConn.Open();
            }
            catch
            {

            }

            dbComm = new SqlCommand("sp_GetTimeTableDgv", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


    }
}
