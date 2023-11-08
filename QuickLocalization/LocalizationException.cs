using System;

namespace QuickLocalization;

public class LocalizationException : Exception
{
    public LocalizationException(string message) : base(message)
    {
    }
    
    public LocalizationException(string message,Exception e) : base(message, e)
    {
    }
}