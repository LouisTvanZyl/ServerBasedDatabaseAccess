using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace HelperLibrary
{
   public class MyDBHandler
    {
       
         static OleDbConnection connection = new OleDbConnection("Provider=SQLNCLI11;Data Source=DESKTOP-J8UU9VC;Integrated Security=SSPI;Initial Catalog=ClientDataMamma");

        public static List<Person> GetData()
        {
            connection.Open();
            List<Person> perList = new List<Person>();



            if (connection.State == ConnectionState.Open)
            {
                OleDbCommand query = new OleDbCommand("Select * From tblClients", connection);
                OleDbDataReader line = query.ExecuteReader();

                while (line.Read())
                {
                    perList.Add(new Person(line.GetInt32(0), line.GetString(1), line.GetString(2), line.GetString(3), line.GetString(4), line.GetString(5)));

                }

                connection.Close();


            }
            return perList;
        }


        public static void Insert(Person nerPer)
        {
            connection.Open();

            OleDbCommand insert = new OleDbCommand("Insert Into tblClients(Initials,Name,Surname,Email,Number) Values('" + nerPer.Initials + "','" + nerPer.Name + "','" + nerPer.Surname + "','" + nerPer.Email + "','" + nerPer.Number + "')", connection);
            insert.ExecuteNonQuery();
            connection.Close();

        }

        public static void Delete(Person delPer)
        {
            connection.Open();
            OleDbCommand qurey = new OleDbCommand("Delete * From tblClients Where Initilials = '" + delPer.Initials + "' And Name = '" + delPer.Name + "'",connection);
            qurey.ExecuteNonQuery();
            connection.Close();

        }

    }
}
