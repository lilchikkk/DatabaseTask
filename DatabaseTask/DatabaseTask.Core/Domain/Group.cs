namespace DatabaseTask.Core.Domain;

public class Group
{
    public int Id { get; set; }
    public int GroupTypeId { get; set; }
    public GroupType GroupType { get; set; } = null!;
    public string Name { get; set; } = null!;
    public int MaxCapacity { get; set; }
    public string? Comment { get; set; }

    public ICollection<ChildGroupAssignment> ChildGroupAssignments { get; set; } = new List<ChildGroupAssignment>();
    public ICollection<GroupStaffAssignment> GroupStaffAssignments { get; set; } = new List<GroupStaffAssignment>();
    public ICollection<WaitingList> WaitingLists { get; set; } = new List<WaitingList>();
    public ICollection<MealServing> MealServings { get; set; } = new List<MealServing>();
}