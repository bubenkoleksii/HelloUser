using System.ComponentModel.DataAnnotations;

namespace HelloUser.Models;

public class HelloUserModel
{
    [Display(Name = "Твоє ім'я")]
    [Required(ErrorMessage = "Поле з ім'ям є обов'язковим")]
    public string Name { get; set; } = null!;
}