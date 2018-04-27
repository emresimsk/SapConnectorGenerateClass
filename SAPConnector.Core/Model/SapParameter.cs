
namespace SAPConnector.Core.Model
{
    public class SapParameter
    {
        public string Name { get; set; }
        public string AppServerHost { get; set; }
        public string Client { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string SystemNumber { get; set; }
        public string Language { get; set; }
        public string PoolSize { get; set; }
        public string PeakConnectionsLimit { get; set; }
        public string IdleTimeout { get; set; }
        public string FunctionName { get; set; }
    }
}












