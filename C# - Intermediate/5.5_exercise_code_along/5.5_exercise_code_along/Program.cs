using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _5._5_exercise_code_along
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type SQL or Oracle to connect:");
            var input = Console.ReadLine().ToLower();
            if (!string.IsNullOrEmpty(input) && input == "sql")
            {
                var sqlConnection = new SqlConnection(input);
                var dbCommand = new DbCommand(sqlConnection, sqlConnection.ConnectionString);
                dbCommand.Execute();
            }
            else if (!string.IsNullOrEmpty(input) && input == "oracle")
            {
                var oracleConnection = new OracleConnection(input);
                var dbCommand = new DbCommand(oracleConnection, oracleConnection.ConnectionString);
                dbCommand.Execute();
            }
            else
            {
                throw new ArgumentException("Not a valid entry.");
            }
        }
    }
}
