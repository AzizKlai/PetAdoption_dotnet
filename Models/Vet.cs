using System.ComponentModel.DataAnnotations;
namespace PetAdoption_dotnet.Models
{
public class Vet
{    
    [Key]
    public Int64 id{ get; set;}
    public string? adress{ get; set;}
    public string? number{ get; set;}
    public string? name{ get; set;}
    public string?  localisation { get; set; }

}
}