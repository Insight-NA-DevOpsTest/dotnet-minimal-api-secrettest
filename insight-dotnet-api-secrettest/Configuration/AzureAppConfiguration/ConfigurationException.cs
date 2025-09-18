using System.Runtime.Serialization;

namespace insight_dotnet_api_secrettest.Configuration;

[Serializable]
public class ConfigurationException : Exception
{
    public ConfigurationException() { }
    public ConfigurationException(string message) : base(message) { }
    public ConfigurationException(string message, System.Exception inner) : base(message, inner) { }
    protected ConfigurationException(SerializationInfo info, StreamingContext context) : base() { }
}