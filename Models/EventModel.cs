using System.ComponentModel.DataAnnotations;

public class EventModel
{
    private static int _idCounter = 1;

    public EventModel()
    {
        Id = _idCounter++;
        Attendees = new List<string>();
    }

    public int Id { get; private set; }

    [Required(ErrorMessage = "The Event name is required.")]
    [StringLength(100, ErrorMessage = "The Event name cannot be more than 100 characters.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The event date is required.")]
    [DataType(DataType.Date, ErrorMessage = "It must be a valid date.")]
    public DateTime? Date { get; set; }

    [Required(ErrorMessage = "The event location is required.")]
    [StringLength(200, ErrorMessage = "The event location cannot be more than 200 characters.")]
    public string Location { get; set; }

    public List<string> Attendees { get; set; }
}


