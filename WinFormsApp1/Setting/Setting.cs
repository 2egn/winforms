using System.Data.SqlClient;

class Setting
{
    static void Main()
    {
        string server = "127.0.0.1";
        string masterdatabase = "master";
        string onworkdatabase = "2024지방_1";
        string userid = "sa";
        string userpw = "test1234";
        string masterconnecString = $"Server={server};Database={masterdatabase};Uid={userid};Pwd={userpw};";
        string workconnectString = $"Server={server};Database={onworkdatabase};Uid={userid};Pwd={userpw};";
        using (SqlConnection con = new SqlConnection(masterconnecString))
        {
            con.Open();
            //drop database if exists
            new SqlCommand("DROP DATABASE IF EXISTS [2024지방_1]", con).ExecuteNonQuery();
            //create database
            new SqlCommand("CREATE DATABASE [2024지방_1]", con).ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Created or Recreated Database {onworkdatabase}.");
        }
        try
        {
            using (SqlConnection conn = new SqlConnection(workconnectString))
            {
                conn.Open();

                // new SqlCommand("", conn).ExecuteNonQuery();

                // create 10.user table
                new SqlCommand("CREATE TABLE [DBO].[user] ([U_NO] INT PRIMARY KEY IDENTITY(1,1) NOT NULL, [U_ID] NVARCHAR(20) NULL, [U_PW] NVARCHAR(20) NULL, [U_NAME] NVARCHAR(20) NULL, U_DATE DATE NULL)", conn).ExecuteNonQuery();


                // create 1.area table
                new SqlCommand("CREATE TABLE [dbo].[area] ([a_no]   INT PRIMARY KEY IDENTITY (1, 1) NOT NULL, [a_name] NVARCHAR (20) NULL)", conn).ExecuteNonQuery();
                new SqlCommand("BULK INSERT [dbo].[area] FROM 'C:\\DataFiles\\2\\area.txt' WITH(FIELDTERMINATOR = '\\t', ROWTERMINATOR = '\\n', FIRSTROW = 2)", conn).ExecuteNonQuery();   

                // create 2.cafe table
                 new SqlCommand("CREATE TABLE [dbo].[cafe] (\r\n    [c_no]     NVARCHAR (40)  NOT NULL,\r\n    [c_name]   NVARCHAR (40)  NULL,\r\n    [t_no]     VARCHAR (100) NULL,\r\n    [c_tel]    VARCHAR (15)  NULL,\r\n    [a_no] INT NULL  FOREIGN KEY REFERENCES [area](a_no),\r\n    [c_adress] NVARCHAR (100)  NULL,\r\n    [c_price]  INT   NULL,\r\n    PRIMARY KEY CLUSTERED ([c_no] ASC)\r\n);\r\n", conn).ExecuteNonQuery();
                 new SqlCommand("BULK INSERT [dbo].[cafe]\r\nFROM 'C:\\DataFiles\\2\\cafe.txt'\r\nWITH\r\n(\r\n    FIELDTERMINATOR = '\\t',\r\n    ROWTERMINATOR = '\\n',    \r\n    FIRSTROW = 2\r\n)", conn).ExecuteNonQuery();
                // create 3.genre table 
                new SqlCommand("CREATE TABLE [DBO].[genre] ([G_NO] INT PRIMARY KEY IDENTITY (1,1) NOT NULL, [G_NAME] NVARCHAR(20) NULL");
                // create 4.map table
                // create 5.ping table
                // create 9.reservation table
                new SqlCommand("CREATE TABLE [dbo].[reservation]([r_no] INT NOT NULL PRIMARY KEY IDENTITY, [u_no] INT NULL FOREIGN KEY REFERENCES [user](u_no), [c_no] nvarchar(10) FOREIGN KEY REFERENCES [cafe](c_no), [t_no] INT FOREIGN KEY REFERENCES[THEME](T_NO), [r_date] date, [r_time] varchar(20), [r_people] int, [r_attend] int)", conn)
                    .ExecuteNonQuery();
                new SqlCommand("BULK INSERT [dbo].[reservation] FROM 'C:\\DataFiles\\2\\reservation.txt' WITH(FIELDTERMINATOR = '\\t', ROWTERMINATOR = '\\n', FIRSTROW = 2)", conn).ExecuteNonQuery();
                
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