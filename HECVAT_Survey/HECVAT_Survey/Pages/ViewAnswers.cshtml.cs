using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace HECVAT_Survery.Pages
{
    public class ViewAnswersModel : PageModel
    {

		public List<allAnswers> Answers = new List<allAnswers>();
		public String errorMessage = "";
		public void OnGet()
		{
			try
			{
				string connectionString = "Data Source=sql.elmcsis.com;Initial Catalog=HECVAT_DB;Persist Security Info=True;User ID=hecvat;Password=byRQadsknbdkEnB!";
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					connection.Open();
					//string sql = "SELECT * FROM Page_1";
					string sql = @"
                SELECT * FROM Page_1
                UNION ALL
                SELECT * FROM Page_2
                UNION ALL
                SELECT * FROM Page_3" ;


					using (SqlCommand command = new SqlCommand(sql, connection))
					{
						using (SqlDataReader reader = command.ExecuteReader())
						{
							while (reader.Read())
							{
								allAnswers client = new allAnswers();

								client.ID = reader.GetInt32(0);
								client.question_1 = reader.GetString(1);
								client.question_2 = reader.GetString(2);
								client.question_3 = reader.GetString(3);
								client.question_4 = reader.GetString(4);
								client.question_5 = reader.GetString(5);
								client.question_6 = reader.GetString(6);
								client.question_7 = reader.GetString(7);
								client.question_8 = reader.GetString(8);
								client.question_9 = reader.GetString(9);
								client.question_10 = reader.GetString(10);
								client.question_11 = reader.GetString(11);
								client.question_12 = reader.GetString(12);
								client.question_13 = reader.GetString(13);
								client.question_14 = reader.GetString(14);
								client.question_15 = reader.GetString(15);
								client.question_16 = reader.GetString(16);
								client.question_17 = reader.GetString(17);
								client.question_18 = reader.GetString(18);
								client.question_19 = reader.GetString(19);
								client.question_20 = reader.GetString(20);

								//client.ID2 = reader.GetInt32(21);
								//client.question_21 = reader.GetString(22);
								//client.question_22 = reader.GetString(23);
								//client.question_23 = reader.GetString(24);
								//client.question_24 = reader.GetString(25);
								//client.question_25 = reader.GetString(26);
								//client.question_26 = reader.GetString(27);
								//client.question_27 = reader.GetString(28);
								//client.question_28 = reader.GetString(29);
								//client.question_29 = reader.GetString(30);
								//client.question_30 = reader.GetString(31);
								//client.question_31 = reader.GetString(32);
								//client.question_32 = reader.GetString(33);
								//client.question_33 = reader.GetString(34);
								//client.question_34 = reader.GetString(35); 
								//client.question_35 = reader.GetString(36);
								//client.question_36 = reader.GetString(37);
								//client.question_37 = reader.GetString(38);
								//client.question_38 = reader.GetString(39);
								//client.question_39 = reader.GetString(40);
								//client.question_40 = reader.GetString(41);
								//client.ID3 = reader.GetInt32(42);
								//client.question_41 = reader.GetString(43);
								//client.question_42 = reader.GetString(44);
								//client.question_43 = reader.GetString(45);
								//client.question_44 = reader.GetString(46);
								//client.question_45 = reader.GetString(47);
								//client.question_46 = reader.GetString(48);
								//client.question_47 = reader.GetString(49);
								//client.question_48 = reader.GetString(50);
								//client.question_49 = reader.GetString(51);
								//client.question_50 = reader.GetString(52);
								//client.question_51 = reader.GetString(53);
								//client.question_52 = reader.GetString(54);
								//client.question_53 = reader.GetString(55);
								//client.question_54 = reader.GetString(56);
								//client.question_55 = reader.GetString(57);
								//client.question_56 = reader.GetString(58);
								//client.question_57 = reader.GetString(59);
								//client.question_58 = reader.GetString(60);
								//client.question_59 = reader.GetString(61);
								//client.question_60 = reader.GetString(62);
				
								Answers.Add(client);
							}
						}

					}

				}
			}
			catch (Exception ex)
			{
				errorMessage = ex.Message;
			}

		}
	}

	public class allAnswers
	{
		public int ID;
		public int ID2;
		public int ID3;
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
		public string question_21;
		public string question_22;
		public string question_23;
		public string question_24;
		public string question_25;
		public string question_26;
		public string question_27;
		public string question_28;
		public string question_29;
		public string question_30;
		public string question_31;
		public string question_32;
		public string question_33;
		public string question_34;
		public string question_35;
		public string question_36;
		public string question_37;
		public string question_38;
		public string question_39;
		public string question_40;
		public string question_41;
		public string question_42;
		public string question_43;
		public string question_44;
		public string question_45;
		public string question_46;
		public string question_47;
		public string question_48;
		public string question_49;
		public string question_50;
		public string question_51;
		public string question_52;
		public string question_53;
		public string question_54;
		public string question_55;
		public string question_56;
		public string question_57;
		public string question_58;
		public string question_59;
		public string question_60;
	}

}

