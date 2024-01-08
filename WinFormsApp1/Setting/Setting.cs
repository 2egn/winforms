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
                // new SqlCommand("", conn).ExecuteNonQuery();
                //
                new SqlCommand("DROP TABLE IF EXISTS [DBO].[AREA]; " +
                    "DROP TABLE IF EXISTS [DBO].[RESERVATION];" +
                    "DROP TABLE IF EXISTS [DBO].[CAFE]", conn).ExecuteNonQuery();
                // create 1.area table
                new SqlCommand("CREATE TABLE [dbo].[area] (" +
                    "[a_no]   INT  IDENTITY (1, 1) NOT NULL," +
                    "[a_name] NVARCHAR (20) NULL)", conn).ExecuteNonQuery();
                new SqlCommand("BULK INSERT [dbo].[area]" +
                    "FROM 'C:\\DataFiles\\2\\area.txt'" +
                    "WITH(FIELDTERMINATOR = '\\t'," +
                    "ROWTERMINATOR = '\\n'," +
                    "FIRSTROW = 2)", conn).ExecuteNonQuery();   
                // create 2.cafe table
                 new SqlCommand("CREATE TABLE [dbo].[cafe] (\r\n    [c_no]     NVARCHAR (40)  NOT NULL,\r\n    [c_name]   NVARCHAR (40)  NULL,\r\n    [t_no]     VARCHAR (100) NULL,\r\n    [c_tel]    VARCHAR (15)  NULL,\r\n    [a_no]     INT    NULL,\r\n    [c_adress] NVARCHAR (50)  NULL,\r\n    [c_price]  INT   NULL,\r\n    PRIMARY KEY CLUSTERED ([c_no] ASC)\r\n);\r\n", conn).ExecuteNonQuery();
                 new SqlCommand("BULK INSERT [dbo].[cafe]\r\nFROM 'C:\\DataFiles\\2\\cafe.txt'\r\nWITH\r\n(\r\n    FIELDTERMINATOR = '\\t',\r\n    ROWTERMINATOR = '\\n',    \r\n    FIRSTROW = 2\r\n)", conn).ExecuteNonQuery();
                // create 3.genre table 
                // create 4.map table
                // create 5.ping table
                // create 9.reservation table
                new SqlCommand("CREATE TABLE [dbo].[reservation]([r_no] INT NOT NULL PRIMARY KEY IDENTITY," +
                    "[u_no] INT NULL FOREIGN KEY REFERENCES [user](u_no)," +
                    "[c_no] nvarchar(10) FOREIGN KEY REFERENCES [cafe](c_no)," +
                    "[t_no] INT FOREIGN KEY REFERENCES[THEME](T_NO)," +
                    "[r_date] date," +
                    "[r_time] varchar(20)," +
                    "[r_people] int," +
                    "[r_attend] int)", conn)
                    .ExecuteNonQuery();
                new SqlCommand("BULK INSERT [dbo].[reservation]" +
                    "FROM 'C:\\DataFiles\\2\\reservation.txt'" +
                    "WITH(FIELDTERMINATOR = '\\t'," +
                    "ROWTERMINATOR = '\\n'," +
                    "FIRSTROW = 2)", conn).ExecuteNonQuery();
                // create 10.user table
                // create notice table




                Console.WriteLine("Done Creating!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}