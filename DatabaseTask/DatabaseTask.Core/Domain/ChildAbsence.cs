namespace DatabaseTask.Core.Domain;

public class ChildAbsence
{
    public int Id { get; set; }
    public int ChildId { get; set; }
    public Child Child { get; set; } = null!;
    public DateTime AbsenceDate { get; set; }
    public string? Reason { get; set; }
    public string? Comment { get; set; }
}