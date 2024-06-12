using System.ComponentModel.DataAnnotations;

namespace semana4.ViewModels;

public class RegisterVM
{
	[Required]
	public string? Nombre { get; set; }
	[Required]
	[DataType(DataType.EmailAddress)]
	public string? Email { get; set; }
	[Required]
	[DataType(DataType.Password)]
	public string? Contraseña { get; set; }

	[Compare("Contraseña", ErrorMessage = "Contraseña.")]
	[Display(Name = "Confirma Contraseña")]
	[DataType(DataType.Password)]
	public string? Confirmar_Contraseña { get; set; }

	[DataType(DataType.MultilineText)]
	public string? Address { get; set; }
}