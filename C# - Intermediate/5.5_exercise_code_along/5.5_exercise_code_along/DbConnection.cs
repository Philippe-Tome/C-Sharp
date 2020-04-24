using System;

namespace _5._5_exercise_code_along
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
       
        public DbConnection(string connection)
        {
            if (string.IsNullOrEmpty(connection))
                throw new InvalidOperationException("No string supplied!");
            ConnectionString = connection;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
