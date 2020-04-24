namespace _5._5_exercise_code_along
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }
        public override void OpenConnection()
        {
            System.Console.WriteLine("Opening connection for SQL database with the url {0}", ConnectionString);
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Closing connection for SQL database.");
        }

    }

}
