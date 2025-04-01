using System.Collections.Generic;

public class EventService
{
    private readonly List<EventModel> events = new();

    public void AddEvent(EventModel eventModel)
    {
        events.Add(eventModel);
    }

    public List<EventModel> GetEvents()
    {
        foreach (var evento in events)
        {
            Console.WriteLine($"Eventos: {evento.Name}");
        }
        return events;
    }
}