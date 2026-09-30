namespace DatabaseTask.Core.Domain;

public class Position
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Department { get; set; }
    public string? Comment { get; set; }

    public ICollection<GroupStaffAssignment> GroupStaffAssignments { get; set; } = new List<GroupStaffAssignment>();
    public ICollection<KitchenStaffAssignment> KitchenStaffAssignments { get; set; } = new List<KitchenStaffAssignment>();
}