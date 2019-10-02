namespace DataMigration
{
    public class ConnectionFactory
    {
        public static IConnection GetDestinationTypeInstance(string destinationType, string jsonPropertyString)
        {
            IConnection _connection = null;
            switch (destinationType)
            {
                case DestinationType.MSSQL:
                    _connection = new SqlConnector(jsonPropertyString);
                    break;
                case DestinationType.FILE:
                    _connection = new FileConnector(jsonPropertyString);
                    break;
            }
            return _connection;
        }
    }
}
