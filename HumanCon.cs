using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Connection1
{
    public class HumanCon
    {
        private SqlConnection con;

        private int rowsAffected { get; set; }

        public string ResultText { get; set; }

        public void InsertParm(Human human)

        {
            rowsAffected = 0;
            string sql = "INSERT INTO parm (ID, Name, LastName, Age)";
            sql += $"VALUES({human.ID},'{human.Name}', '{human.LastName}', {human.Age} )";

            try
            {
                using (con = new SqlConnection("Server=DESKTOP-K84SPV3;Database=Human;Trusted_Connection=True;"))
                {
                    using (SqlCommand command = new SqlCommand(sql, con))
                    {
                        command.CommandType = CommandType.Text;
                        con.Open();
                        rowsAffected = command.ExecuteNonQuery();
                        ResultText = "Rows Affected: " + rowsAffected.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
            }
        }
    }
}
