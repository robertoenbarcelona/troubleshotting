
using System.Diagnostics;

namespace ConsoleHost
{
    public static class EventLogWriter
    {
        private const string source="TestLogViewer";
        private const string log = "Application";

        public static void WriteLog(string message, LogEvent logEvent)
        {
            if (!EventLog.SourceExists(EventLogWriter.source)) { EventLog.CreateEventSource(EventLogWriter.source, EventLogWriter.log); }
            EventLog.WriteEntry(EventLogWriter.source, logEvent.ToString(), EventLogEntryType.Error);
        }

        public enum LogEvent
        {
            AppError,
            ExternalError
        }
    }
}
