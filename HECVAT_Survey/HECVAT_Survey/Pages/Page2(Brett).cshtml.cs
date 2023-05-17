using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace HECVAT_Survey.Pages
{
    public class Page2_Brett_Model : PageModel
    {
        public Responses clientInfo = new Responses();
        public String errorMessage = "";
        public String success = "";

        public void OnPost()
        {
            clientInfo.Question_21 = Request.Form["answer21"];
            clientInfo.Question_22 = Request.Form["answer22"];
            clientInfo.Question_23 = Request.Form["answer23"];
            clientInfo.Question_24 = Request.Form["answer24"];
            clientInfo.Question_25 = Request.Form["answer25"];
            clientInfo.Question_26 = Request.Form["answer26"];
            clientInfo.Question_27 = Request.Form["answer27"];
            clientInfo.Question_28 = Request.Form["answer28"];
            clientInfo.Question_29 = Request.Form["answer29"];
            clientInfo.Question_30 = Request.Form["answer30"];
            clientInfo.Question_31 = Request.Form["answer31"];
            clientInfo.Question_32 = Request.Form["answer32"];
            clientInfo.Question_33 = Request.Form["answer33"];
            clientInfo.Question_34 = Request.Form["answer34"];
            clientInfo.Question_35 = Request.Form["answer35"];
            clientInfo.Question_36 = Request.Form["answer36"];
            clientInfo.Question_37 = Request.Form["answer37"];
            clientInfo.Question_38 = Request.Form["answer38"];
            clientInfo.Question_39 = Request.Form["answer39"];
            clientInfo.Question_40 = Request.Form["answer40"];

            if (clientInfo.Question_21 == null || clientInfo.Question_22 == null || clientInfo.Question_23 == null || clientInfo.Question_24 == null ||
               clientInfo.Question_25 == null || clientInfo.Question_26 == null || clientInfo.Question_27 == null || clientInfo.Question_28 == null ||
               clientInfo.Question_29 == null || clientInfo.Question_30 == null || clientInfo.Question_31 == null || clientInfo.Question_32 == null ||
               clientInfo.Question_33 == null || clientInfo.Question_34 == null || clientInfo.Question_35 == null || clientInfo.Question_36 == null ||
               clientInfo.Question_37 == null || clientInfo.Question_38 == null || clientInfo.Question_39 == null || clientInfo.Question_40 == null)
            {
                errorMessage = "All fields must be filled out";
                return;
            }


            if (clientInfo.Question_21.Length == 0 || clientInfo.Question_22.Length == 0 || clientInfo.Question_23.Length == 0 || clientInfo.Question_24.Length == 0 ||
                clientInfo.Question_25.Length == 0 || clientInfo.Question_26.Length == 0 || clientInfo.Question_27.Length == 0 || clientInfo.Question_28.Length == 0 ||
                clientInfo.Question_29.Length == 0 || clientInfo.Question_30.Length == 0 || clientInfo.Question_31.Length == 0 ||
                clientInfo.Question_32.Length == 0 || clientInfo.Question_33.Length == 0 || clientInfo.Question_34.Length == 0 || clientInfo.Question_35.Length == 0 ||
                clientInfo.Question_36.Length == 0 || clientInfo.Question_37.Length == 0 || clientInfo.Question_38.Length == 0 || clientInfo.Question_39.Length == 0 ||
                clientInfo.Question_40.Length == 0)
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
                    string sql = "INSERT INTO Page_2" +
                        "(Question_21, Question_22, Question_23, Question_24, Question_25, Question_26, Question_27, Question_28, Question_29, Question_30, Question_31, Question_32, Question_33, Question_34, Question_35, Question_36, Question_37, Question_38, Question_39, Question_40) VALUES"
                        + "(@Question_21, @Question_22, @Question_23, @Question_24, @Question_25, @Question_26, @Question_27, @Question_28, @Question_29, @Question_30, @Question_31, @Question_32, @Question_33, @Question_34, @Question_35, @Question_36, @Question_37, @Question_38, @Question_39, @Question_40);";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Question_21", clientInfo.Question_21);
                        command.Parameters.AddWithValue("@Question_22", clientInfo.Question_22);
                        command.Parameters.AddWithValue("@Question_23", clientInfo.Question_23);
                        command.Parameters.AddWithValue("@Question_24", clientInfo.Question_24);
                        command.Parameters.AddWithValue("@Question_25", clientInfo.Question_25);
                        command.Parameters.AddWithValue("@Question_26", clientInfo.Question_26);
                        command.Parameters.AddWithValue("@Question_27", clientInfo.Question_27);
                        command.Parameters.AddWithValue("@Question_28", clientInfo.Question_28);
                        command.Parameters.AddWithValue("@Question_29", clientInfo.Question_29);
                        command.Parameters.AddWithValue("@Question_30", clientInfo.Question_30);
                        command.Parameters.AddWithValue("@Question_31", clientInfo.Question_31);
                        command.Parameters.AddWithValue("@Question_32", clientInfo.Question_32);
                        command.Parameters.AddWithValue("@Question_33", clientInfo.Question_33);
                        command.Parameters.AddWithValue("@Question_34", clientInfo.Question_34);
                        command.Parameters.AddWithValue("@Question_35", clientInfo.Question_35);
                        command.Parameters.AddWithValue("@Question_36", clientInfo.Question_36);
                        command.Parameters.AddWithValue("@Question_37", clientInfo.Question_37);
                        command.Parameters.AddWithValue("@Question_38", clientInfo.Question_38);
                        command.Parameters.AddWithValue("@Question_39", clientInfo.Question_39);
                        command.Parameters.AddWithValue("@Question_40", clientInfo.Question_40);



                        command.ExecuteNonQuery();
                    }
                }
            }

            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

            clientInfo.Question_21 = "";
            clientInfo.Question_22 = "";
            clientInfo.Question_23 = "";
            clientInfo.Question_24 = "";
            clientInfo.Question_25 = "";
            clientInfo.Question_26 = "";
            clientInfo.Question_27 = "";
            clientInfo.Question_28 = "";
            clientInfo.Question_29 = "";
            clientInfo.Question_30 = "";
            clientInfo.Question_31 = "";
            clientInfo.Question_32 = "";
            clientInfo.Question_33 = "";
            clientInfo.Question_34 = "";
            clientInfo.Question_35 = "";
            clientInfo.Question_36 = "";
            clientInfo.Question_37 = "";
            clientInfo.Question_38 = "";
            clientInfo.Question_39 = "";
            clientInfo.Question_40 = "";

            success = "Page Updated Successfully";

            Response.Redirect("/Page3(Jennifer)");

        }
    }
}

public class Responses
{
    public string Question_21;
    public string Question_22;
    public string Question_23;
    public string Question_24;
    public string Question_25;
    public string Question_26;
    public string Question_27;
    public string Question_28;
    public string Question_29;
    public string Question_30;
    public string Question_31;
    public string Question_32;
    public string Question_33;
    public string Question_34;
    public string Question_35;
    public string Question_36;
    public string Question_37;
    public string Question_38;
    public string Question_39;
    public string Question_40;
}

