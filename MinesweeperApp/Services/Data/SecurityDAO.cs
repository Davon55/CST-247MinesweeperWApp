
using MinesweeperApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MinesweeperApp.Services.Data
{
    public class SecurityDAO
    {
        //connect to database
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MinesweeperDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal bool FindByUser(UserModel user)
        {

            //assuming that nothing is found
            bool success = false;
            //write the sql expression
            string queryString = "SELECT * FROM dbo.Users WHERE username = @userName AND password = @password";
            
            // create and open the connection to the database inside the using block when done
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // creat the command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);
                //associate @username with user.username
                command.Parameters.Add("@userName", System.Data.SqlDbType.VarChar, 50).Value = user.userName;

                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = user.password;

                //open the datanase and run the command
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        success = true;
                    }
                    reader.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return success;
        }
        public RegisterModel getById(int Id)
        {
            

            // access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT * FROM dbo.Users WHERE Id =@Id";

               

                // creat the command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.Add("@Id,", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                RegisterModel register = new RegisterModel();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        // create a new user object. add it to the list to return 
                       
                        register.Id = reader.GetInt32(0);
                        register.firstName = reader.GetString(1);
                        register.lastName = reader.GetString(2);
                        register.sex = reader.GetString(3);
                        register.age = reader.GetInt32(4);
                        register.state = reader.GetString(5);
                        register.email = reader.GetString(6);
                        register.address = reader.GetString(7);
                        register.username = reader.GetString(8);
                        register.password = reader.GetString(9);

                       

                    }
                }
                return register;
            }
            
        }
        public List<RegisterModel> FindAll()
        {
            List<RegisterModel> returnList = new List<RegisterModel>();

            // access the database
            using (SqlConnection connection = new SqlConnection())
            {
                string queryString = "SELECT * FROM [dbo].[Users]";

                // creat the command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // create a new user object. add it to the list to return 
                        RegisterModel register = new RegisterModel();
                        register.Id = reader.GetInt32(0);
                        register.firstName = reader.GetString(1);
                        register.lastName = reader.GetString(2);
                        register.sex = reader.GetString(3);
                        register.age = reader.GetInt32(4);
                        register.state = reader.GetString(5);
                        register.email = reader.GetString(6);
                        register.address = reader.GetString(7);
                        register.username = reader.GetString(8);
                        register.password = reader.GetString(9);

                        returnList.Add(register);

                    }
                }

            }
            return returnList;
        }
    }
}
