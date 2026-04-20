static class LogLine
{
    public static string Message(string logLine)
    {
        int pos = logLine.IndexOf(']');
        return logLine.Substring(pos+2).Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int pos = logLine.IndexOf(']');
        return logLine.Substring(1,pos-1).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {

        return Message(logLine) + " (" + LogLevel(logLine) + ")";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
