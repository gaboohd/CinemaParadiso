using System.ComponentModel.DataAnnotations;

namespace semana4.ViewModels;

public class LoginVM
{
	[Required(ErrorMessage = "Se requiere un Usuario.")]
	public string? Usuario { get; set; }

	[Required(ErrorMessage = "Se requiere una Contraseña.")]
	[DataType(DataType.Password)]
	public string? Contraseña { get; set; }

	[Display(Name = "Hacerme acordar")]
	public bool RememberMe { get; set; }
}