
public class EventService
{
    private readonly List<EventModel> events = new();

    public void AddEvent(EventModel eventModel)
    {
        Console.WriteLine($"EVENTO A AGREGAR: {eventModel.Id}");
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

    public EventModel GetEventById(int id)
    {
        return events.FirstOrDefault(e => e.Id == id);
    }
}