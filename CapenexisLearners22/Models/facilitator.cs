using System.ComponentModel.DataAnnotations;

namespace CapenexisLearners22;

public class Facilitator
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? SurName { get; set; }
    public string? NationalIdentityNumber { get; set; }
    public string? NumberofLearners{ get; set; }
}