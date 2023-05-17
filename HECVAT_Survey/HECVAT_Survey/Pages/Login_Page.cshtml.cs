using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace HECVAT_Survey.Pages
{
    public class Login_PageModel : PageModel
    {
        public login user_login = new login();
        public String errorMessage = "";
        public String success = "";

        public void OnGet()
        {
      
        }

        public void OnPost()
        {
            user_login.username = Request.Form["user_name"];
            user_login.password = Request.Form["password"];


            try
            {
                string connectionString = "Data Source=sql.elmcsis.com;Initial Catalog=HECVAT_DB;Persist Security Info=True;User ID=hecvat;Password=byRQadsknbdkEnB!";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Password FROM Sign_In_Table WHERE Username = @Login";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Login", user_login.username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPassword = reader["Password"].ToString();

                                if (storedPassword == user_login.password)
                                {
                                    // Passwords match, login successful
                                    errorMessage = "";
                                    success = "Login successful";
                                    Response.Redirect("/Survey_1");
                                }
                                else
                                {
                                    // Passwords do not match, login failed
                                    errorMessage = "Incorrect password";
                                }
                            }
                            else
                            {
                                // No matching login found
                                errorMessage = "Invalid login";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return;
            }

        }

    }
}

public class login
{
    public string username;
    public string password;

}