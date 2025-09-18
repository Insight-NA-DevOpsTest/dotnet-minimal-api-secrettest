using System.Text.Json;

namespace insight_dotnet_api_secrettest.ErrorHandling
{
    public class ErrorDetails
    {

        public string TraceId { get; set; }
        public string Message { get; set; }

        public ErrorDetails(string traceId, string message)
        {
            TraceId = traceId;
            Message = message;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}