namespace DatabaseTask.Core.Domain;

public class Child
{
    public int Id { get; set; }
    public int GroupTypeId { get; set; }
    public GroupType GroupType { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string PersonalCode { get; set; } = null!;
    public DateTime BirthDate { get; set; }
    public string? Comment { get; set; }

    public ICollection<WaitingList> WaitingLists { get; set; } = new List<WaitingList>();
    public ICollection<ChildGroupAssignment> ChildGroupAssignments { get; set; } = new List<ChildGroupAssignment>();
    public ICollection<ChildAbsence> ChildAbsences { get; set; } = new List<ChildAbsence>();
}
