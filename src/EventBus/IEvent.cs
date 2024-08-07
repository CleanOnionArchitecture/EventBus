namespace CleanOnionArchitecture.EventBus;

using System;

/// <summary>
/// Basic structure of an event.
/// </summary>
public interface IEvent
{
    /// <summary>
    /// Identity of this event.
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Date of this event.
    /// </summary>
    public DateTime Date { get; }
}