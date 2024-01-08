using System.Data.SqlClient;

class Setting
{
    static void Main()
    {
        string server = "127.0.0.1";
        string database = "sqler_test";
        string userid = "sa";
        string userpw = "test1234";
        string connectString = $"Server={server};Database={database};Uid={userid};Pwd={userpw};";
        try
        {
            using (SqlConnection conn = new SqlConnection(connectString))
            {
                conn.Open();
                var createtable9 = new SqlCommand("CREATE TABLE [dbo].[reservation]([r_no] INT NOT NULL PRIMARY KEY IDENTITY," +
                    "[u_no] INT NULL FOREIGN KEY REFERENCES [user](u_no)," +
                    "[c_no] varchar(10) FOREIGN KEY REFERENCES [cafe](c_no)," +
                    "[t_no] INT FOREIGN KEY REFERENCES[THEME](T_NO)," +
                    "[r_date] date," +
                    "[r_time] varchar(20)," +
                    "[r_people] int," +
                    "[r_attend] int")
                    .ExecuteNonQuery;
                var insertvalue9 = new SqlCommand("BULK INSERT [dbo].[reservation]" +
                    "FROM 'C:\\Users\\0821j\\Desktop\\정보기술\\문제, 지급자료\\제2과제 지급자료\\Datafiles'" +
                    "WITH" +
                    "(" +
                    "FIELDTERMINATOR = '\t'," +
                    "ROWTERMINATOR = '\n'," +
                    "FIRSTROW = 2").ExecuteNonQuery;
                Console.WriteLine("Done Creating!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}