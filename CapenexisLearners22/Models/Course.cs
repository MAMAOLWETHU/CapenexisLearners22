using System.ComponentModel.DataAnnotations;

namespace CapenexisLearners22;

public class Course
{
    public int Id { get; set; }
    public string? Lecture { get; set; }
    public string? CourseName { get; set; }
    public string? Duration { get; set; }
    public decimal Price { get; set; }
}