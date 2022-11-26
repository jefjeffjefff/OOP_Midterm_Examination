namespace OOP_Midterm_Examination.Database
{
    public class MicrosoftSqlDatabase
    {
        private void Connect()
        {
            Console.WriteLine("Microsoft Sql Database is initialized");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnected from MSSQL");
        }

        public void Query(string query)
        {
            Connect();
            Console.WriteLine("Fired a Query: " + query);
            Disconnect();
        }
    }
}
