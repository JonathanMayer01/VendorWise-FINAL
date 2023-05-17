using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace HECVAT_Survery.Pages
{
    public class Page3_Jennifer_Model : PageModel
    {
        public Page3 clientInfo = new Page3();
        public String errorMessage = "";
        public String success = "";

        public void OnPost()
        {
            clientInfo.Question_41 = Request.Form["answer41"];
            clientInfo.Question_42 = Request.Form["answer42"];
            clientInfo.Question_43 = Request.Form["answer43"];
            clientInfo.Question_44 = Request.Form["answer44"];
            clientInfo.Question_45 = Request.Form["answer45"];
            clientInfo.Question_46 = Request.Form["answer46"];
            clientInfo.Question_47 = Request.Form["answer47"];
            clientInfo.Question_48 = Request.Form["answer48"];
            clientInfo.Question_49 = Request.Form["answer49"];
            clientInfo.Question_50 = Request.Form["answer50"];
            clientInfo.Question_51 = Request.Form["answer51"];
            clientInfo.Question_52 = Request.Form["answer52"];
            clientInfo.Question_53 = Request.Form["answer53"];
            clientInfo.Question_54 = Request.Form["answer54"];
            clientInfo.Question_55 = Request.Form["answer55"];
            clientInfo.Question_56 = Request.Form["answer56"];
            clientInfo.Question_57 = Request.Form["answer57"];
            clientInfo.Question_58 = Request.Form["answer58"];
            clientInfo.Question_59 = Request.Form["answer59"];
            clientInfo.Question_60 = Request.Form["answer60"];

            if (clientInfo.Question_42 == null || clientInfo.Question_43 == null || clientInfo.Question_44 == null || clientInfo.Question_45 == null ||
               clientInfo.Question_47 == null || clientInfo.Question_48 == null || clientInfo.Question_50 == null || clientInfo.Question_51 == null ||
               clientInfo.Question_53 == null || clientInfo.Question_54 == null || clientInfo.Question_55 == null || clientInfo.Question_56 == null ||
               clientInfo.Question_59 == null || clientInfo.Question_58 == null || clientInfo.Question_60 == null)
            {
                errorMessage = "All fields must be filled out";
                return;
            }

            if (clientInfo.Question_41.Length == 0 || clientInfo.Question_42.Length == 0 || clientInfo.Question_43.Length == 0 || clientInfo.Question_44.Length == 0 || clientInfo.Question_45.Length == 0 ||
                clientInfo.Question_46.Length == 0 || clientInfo.Question_47.Length == 0 || clientInfo.Question_48.Length == 0 || clientInfo.Question_49.Length == 0 || clientInfo.Question_50.Length == 0 ||
                clientInfo.Question_51.Length == 0 || clientInfo.Question_52.Length == 0 || clientInfo.Question_53.Length == 0 || clientInfo.Question_54.Length == 0 || clientInfo.Question_55.Length == 0 ||
                clientInfo.Question_56.Length == 0 || clientInfo.Question_57.Length == 0 || clientInfo.Question_58.Length == 0 || clientInfo.Question_59.Length == 0 || clientInfo.Question_60.Length == 0)
            {
                errorMessage = "All fields must be filled out";
                return;
            }


            try
            {
                string connectionString = "Data Source=sql.elmcsis.com;Initial Catalog=HECVAT_DB;Persist Security Info=True;User ID=hecvat;Password=byRQadsknbdkEnB!";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO Page_3" +
                        "(Question_41, Question_42, Question_43, Question_44, Question_45, Question_46, Question_47, Question_48, Question_49, Question_50, Question_51, Question_52, Question_53, Question_54, Question_55, Question_56, Question_57, Question_58, Question_59, Question_60) VALUES"
                        + "(@Question_41, @Question_42, @Question_43, @Question_44, @Question_45, @Question_46, @Question_47, @Question_48, @Question_49, @Question_50, @Question_51, @Question_52, @Question_53, @Question_54, @Question_55, @Question_56, @Question_57, @Question_58, @Question_59, @Question_60);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Question_41", clientInfo.Question_41);
                        command.Parameters.AddWithValue("@Question_42", clientInfo.Question_42);
                        command.Parameters.AddWithValue("@Question_43", clientInfo.Question_43);
                        command.Parameters.AddWithValue("@Question_44", clientInfo.Question_44);
                        command.Parameters.AddWithValue("@Question_45", clientInfo.Question_45);
                        command.Parameters.AddWithValue("@Question_46", clientInfo.Question_46);
                        command.Parameters.AddWithValue("@Question_47", clientInfo.Question_47);
                        command.Parameters.AddWithValue("@Question_48", clientInfo.Question_48);
                        command.Parameters.AddWithValue("@Question_49", clientInfo.Question_49);
                        command.Parameters.AddWithValue("@Question_50", clientInfo.Question_50);
                        command.Parameters.AddWithValue("@Question_51", clientInfo.Question_51);
                        command.Parameters.AddWithValue("@Question_52", clientInfo.Question_52);
                        command.Parameters.AddWithValue("@Question_53", clientInfo.Question_53);
                        command.Parameters.AddWithValue("@Question_54", clientInfo.Question_54);
                        command.Parameters.AddWithValue("@Question_55", clientInfo.Question_55);
                        command.Parameters.AddWithValue("@Question_56", clientInfo.Question_56);
                        command.Parameters.AddWithValue("@Question_57", clientInfo.Question_57);
                        command.Parameters.AddWithValue("@Question_58", clientInfo.Question_58);
                        command.Parameters.AddWithValue("@Question_59", clientInfo.Question_59);
                        command.Parameters.AddWithValue("@Question_60", clientInfo.Question_60);



                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            clientInfo.Question_41 = "";
            clientInfo.Question_42 = "";
            clientInfo.Question_43 = "";
            clientInfo.Question_44 = "";
            clientInfo.Question_45 = "";
            clientInfo.Question_46 = "";
            clientInfo.Question_47 = "";
            clientInfo.Question_48 = "";
            clientInfo.Question_49 = "";
            clientInfo.Question_50 = "";
            clientInfo.Question_51 = "";
            clientInfo.Question_52 = "";
            clientInfo.Question_53 = "";
            clientInfo.Question_54 = "";
            clientInfo.Question_55 = "";
            clientInfo.Question_56 = "";
            clientInfo.Question_57 = "";
            clientInfo.Question_58 = "";
            clientInfo.Question_59 = "";
            clientInfo.Question_60 = "";

            success = "Page Updated Successfully";
            Response.Redirect("/Completed_Page");
        }

    }
}
public class Page3
{
    public string Question_41;
    public string Question_42;
    public string Question_43;
    public string Question_44;
    public string Question_45;
    public string Question_46;
    public string Question_47;
    public string Question_48;
    public string Question_49;
    public string Question_50;
    public string Question_51;
    public string Question_52;
    public string Question_53;
    public string Question_54;
    public string Question_55;
    public string Question_56;
    public string Question_57;
    public string Question_58;
    public string Question_59;
    public string Question_60;


}
