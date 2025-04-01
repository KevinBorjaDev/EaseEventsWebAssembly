using System.ComponentModel.DataAnnotations;

public class EventModel
{
  [Required(ErrorMessage = "El nombre del evento es obligatorio.")]
  [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
  public string Name { get; set; }

  [Required(ErrorMessage = "La fecha del evento es obligatoria.")]
  [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha válida.")]
  public DateTime? Date { get; set; }

  [Required(ErrorMessage = "El lugar del evento es obligatorio.")]
  [StringLength(200, ErrorMessage = "El lugar no puede exceder los 200 caracteres.")]
  public string Location { get; set; }
}