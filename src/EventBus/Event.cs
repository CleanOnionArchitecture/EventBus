namespace CleanOnionArchitecture.EventBus;

using System;
using System.Text;

/// <summary>
/// Concrete event base
/// </summary>
public abstract record Event : IEvent
{
    /// <summary>
    /// 
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime Date { get; }

    /// <summary>
    /// Create an event with default values
    /// </summary>
    protected Event()
    {
        Date = DateTime.Now;
        byte[] bytes = Encoding.UTF8.GetBytes(Date.Ticks.ToString().Substring(0, 16));
        Id = new Guid(bytes);
    }

    /// <summary>
    /// Create an event with default values
    /// </summary>
    /// <param name="id"></param>
    protected Event(Guid id)
    {
        Id = id;
        Date = DateTime.Now;
        byte[] bytes = Encoding.UTF8.GetBytes(Date.Ticks.ToString().Substring(0, 16));
    }

    /// <summary>
    /// Create an event with custom id and custom date
    /// </summary>
    /// <param name="id"></param>
    /// <param name="date"></param>
    protected Event(Guid id, DateTime date)
    {
        Id = id;
        Date = date;
    }
}