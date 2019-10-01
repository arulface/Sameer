namespace ConsoleApp3
{
    public class ConnectionFactory
    {
        public static IConnection GetDestinationTypeInstance(string destinationType)
        {
            IConnection _connection = null;
            switch (destinationType)
            {
                case DestinationType.MSSQL:
                    _connection = new SqlConnector();
                    break;
                case DestinationType.FILE:
                    _connection = new FileConnector();
                    break;
            }
            return _connection;
        }
    }
}
