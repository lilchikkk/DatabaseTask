using System.Text.RegularExpressions;

namespace DatabaseTask.Core.Domain;

public class GroupType
{
    public int Id { get; set; }
    public string TypeName { get; set; } = null!;
    public string? Description { get; set; }
    public string? Comment { get; set; }

    public ICollection<Group> Groups { get; set; } = new List<Group>();
    public ICollection<Child> Children { get; set; } = new List<Child>();
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}