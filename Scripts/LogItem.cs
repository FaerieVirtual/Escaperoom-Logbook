public class LogItem
{
    public LogItemType Type;
    public string Data;
}

public enum LogItemType
{
    Text,
    Image,
    Audio
}
