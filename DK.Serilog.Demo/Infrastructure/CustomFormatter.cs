using Serilog.Events;
using Serilog.Formatting;

namespace DK.Serilog.Demo.Infrastructure
{
    public class CustomFormatter:ITextFormatter
    {
        public void Format(LogEvent logEvent, TextWriter output)
        {
            // Format the log event as per your custom logic
            string formattedLog =
                $"{logEvent.Timestamp:yyyy-MM-dd HH:mm:ss} [{logEvent.Level}] {logEvent.Properties["Message"]}{Environment.NewLine}";

            // Write the formatted log event to the output
            output.Write(formattedLog);
        }
    }
}
