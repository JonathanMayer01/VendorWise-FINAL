using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace HECVAT_Survey.Pages
{
    public class Survey_1Model : PageModel
    {
        public Page1 survey_1 = new Page1();
        public String errorMessage = "";
        public String success = "";

        
        public void OnPost()
        {
            survey_1.question_1 = Request.Form["answer1"];
            survey_1.question_2 = Request.Form["answer2"];
            survey_1.question_3 = Request.Form["answer3"];
            survey_1.question_4 = Request.Form["answer4"];
            survey_1.question_5 = Request.Form["answer5"];
            survey_1.question_6 = Request.Form["answer6"];
            survey_1.question_7 = Request.Form["answer7"];
            survey_1.question_8 = Request.Form["answer8"];
            survey_1.question_9 = Request.Form["answer9"];
            survey_1.question_10 = Request.Form["answer10"];
            survey_1.question_11 = Request.Form["answer11"];
            survey_1.question_12 = Request.Form["answer12"];
            survey_1.question_13 = Request.Form["answer13"];
            survey_1.question_14 = Request.Form["answer14"];
            survey_1.question_15 = Request.Form["answer15"];
            survey_1.question_16 = Request.Form["answer16"];
            survey_1.question_17 = Request.Form["answer17"];
            survey_1.question_18 = Request.Form["answer18"];
            survey_1.question_19 = Request.Form["answer19"];
            survey_1.question_20 = Request.Form["answer20"];

            if (survey_1.question_1 == null || survey_1.question_4 == null || survey_1.question_10 == null || survey_1.question_17 == null ||
               survey_1.question_18 == null || survey_1.question_19 == null || survey_1.question_20 == null || survey_1.question_8 == null ||
               survey_1.question_9 == null)
            {
                errorMessage = "All fields must be filled out";
                return;
            }


            if (survey_1.question_1.Length == 0 || survey_1.question_2.Length==0 || survey_1.question_3.Length == 0 || survey_1.question_4.Length == 0 ||
                survey_1.question_5.Length == 0 || survey_1.question_6.Length == 0 || survey_1.question_7.Length == 0 || survey_1.question_8.Length == 0 ||
                survey_1.question_9.Length == 0 || survey_1.question_10.Length == 0 || survey_1.question_11.Length == 0 ||
                survey_1.question_12.Length == 0 || survey_1.question_13.Length == 0 || survey_1.question_14.Length == 0 || survey_1.question_15.Length == 0 ||
                survey_1.question_16.Length == 0 || survey_1.question_17.Length == 0 || survey_1.question_18.Length == 0 || survey_1.question_19.Length == 0 ||
                survey_1.question_20.Length == 0)
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
                    string sql_insert = "INSERT INTO Page_1" +
                        "(question_1, question_2, question_3, question_4, question_5, question_6, question_7, question_8, question_9, question_10, question_11, question_12, question_13, question_14, question_15, question_16, question_17, question_18, question_19, question_20) VALUES"
                        + "(@question_1, @question_2, @question_3, @question_4, @question_5, @question_6, @question_7, @question_8, @question_9, @question_10, @question_11, @question_12, @question_13, @question_14, @question_15, @question_16, @question_17, @question_18, @question_19, @question_20);";

                    using (SqlCommand command = new SqlCommand(sql_insert, connection))
                    {
                        command.Parameters.AddWithValue("@question_1", survey_1.question_1);
                        command.Parameters.AddWithValue("@question_2", survey_1.question_2);
                        command.Parameters.AddWithValue("@question_3", survey_1.question_3);
                        command.Parameters.AddWithValue("@question_4", survey_1.question_4);
                        command.Parameters.AddWithValue("@question_5", survey_1.question_5);
                        command.Parameters.AddWithValue("@question_6", survey_1.question_6);
                        command.Parameters.AddWithValue("@question_7", survey_1.question_7);
                        command.Parameters.AddWithValue("@question_8", survey_1.question_8);
                        command.Parameters.AddWithValue("@question_9", survey_1.question_9);
                        command.Parameters.AddWithValue("@question_10", survey_1.question_10);
                        command.Parameters.AddWithValue("@question_11", survey_1.question_11);
                        command.Parameters.AddWithValue("@question_12", survey_1.question_12);
                        command.Parameters.AddWithValue("@question_13", survey_1.question_13);
                        command.Parameters.AddWithValue("@question_14", survey_1.question_14);
                        command.Parameters.AddWithValue("@question_15", survey_1.question_15);
                        command.Parameters.AddWithValue("@question_16", survey_1.question_16);
                        command.Parameters.AddWithValue("@question_17", survey_1.question_17);
                        command.Parameters.AddWithValue("@question_18", survey_1.question_18);
                        command.Parameters.AddWithValue("@question_19", survey_1.question_19);
                        command.Parameters.AddWithValue("@question_20", survey_1.question_20);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }


            survey_1.question_1 = "";
            survey_1.question_2 = "";
            survey_1.question_3 = "";
            survey_1.question_4 = "";
            survey_1.question_5 = "";
            survey_1.question_6 = "";
            survey_1.question_7 = "";
            survey_1.question_8 = "";
            survey_1.question_9 = "";
            survey_1.question_10 = "";
            survey_1.question_11 = "";
            survey_1.question_12 = "";
            survey_1.question_13 = "";
            survey_1.question_14 = "";
            survey_1.question_15 = "";
            survey_1.question_16 = "";
            survey_1.question_17 = "";
            survey_1.question_18 = "";
            survey_1.question_19 = "";
            survey_1.question_20 = "";


            success = "Page Updated Successfully";

            Response.Redirect("/Page2(Brett)");
        }

    }
}



public class Page1
{
    public string question_1;
    public string question_2;
    public string question_3;
    public string question_4;
    public string question_5;
    public string question_6;
    public string question_7;
    public string question_8;
    public string question_9;
    public string question_10;
    public string question_11;
    public string question_12;
    public string question_13;
    public string question_14;
    public string question_15;
    public string question_16;
    public string question_17;
    public string question_18;
    public string question_19;
    public string question_20;


}