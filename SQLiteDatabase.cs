/*******************************************************************
* Name: Steven McGraw
* Date: June 7, 2026
* Assignment: SDC320 Course Project - Database Implementation
*
* Class used to create and connect to the One Rep Further SQLite
* database.
*******************************************************************/

using System;
using System.Data.SQLite;

public class SQLiteDatabase
{
    public static SQLiteConnection Connect(string databaseName)
    {
        string connectionString = @"Data Source=" + databaseName;
        SQLiteConnection conn = new SQLiteConnection(connectionString);

        try
        {
            conn.Open();
        }
        catch (Exception e)
        {
            Console.WriteLine("Database connection error: " + e.Message);
        }

        return conn;
    }
}