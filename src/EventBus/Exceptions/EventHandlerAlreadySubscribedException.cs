namespace CleanOnionArchitecture.EventBus.Exceptions;

using System;

/// <summary>
/// 
/// </summary>
public class EventHandlerAlreadySubscribedException : Exception
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    public EventHandlerAlreadySubscribedException(string message)
        : base(message)
    {
    }
}