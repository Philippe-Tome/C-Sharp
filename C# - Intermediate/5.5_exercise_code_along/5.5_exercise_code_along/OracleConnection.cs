namespace _5._5_exercise_code_along
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }
        public override void OpenConnection()
        {
            System.Console.WriteLine("Opening connection for Oracle database with the url {0} ", ConnectionString);
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Closing connection for Oracle database.");
        }

    }

}
