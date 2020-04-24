using System;

namespace _5._5_exercise_code_along
{
    public class DbCommand
    {
        private DbConnection _dbConnection { get; set; }
        public string _command { get; set; }

        
        public DbCommand(DbConnection dbConnection, string command)
        {
            if (string.IsNullOrEmpty(command))
                throw new InvalidOperationException("No string supplied!");
            _dbConnection = dbConnection;
            _command = command;
        }


        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(_command.ToUpper());
            _dbConnection.CloseConnection();
        }

        
    }
}
