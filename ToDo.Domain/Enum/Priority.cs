namespace ClassLibrary1.Enum;
using System.ComponentModel.DataAnnotations;
public enum Priority
{
    [Display(Name = "Важно")]
    warning = 1,
    [Display(Name = "Средне")]
    medium = 1,
    [Display(Name = "Можно отложить")]
    easy = 1,
}