using System.Diagnostics;

namespace MovieFinder.ConsoleOutDebug;

public static class ConsoleDebug
{

    public static void Init()
    {
        // true - redirects to stderr
        ConsoleTraceListener _listener = new ConsoleTraceListener(true);
        string initializerMessage = $"{DateTime.Now.ToString()} [ mainConsoleTracer] - Starting output to console trace listener.";
        _listener.WriteLine(initializerMessage);
        Trace.Listeners.Add(_listener);
        Trace.AutoFlush = true;
    }

    public static void ToStdOut(object? message)
    {
        Trace.WriteLine(message);
    }
}
