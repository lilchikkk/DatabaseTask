namespace DatabaseTask.Core.Domain;

public class WaitingList
{
    public int Id { get; set; }
    public int ChildId { get; set; }
    public Child Child { get; set; } = null!;
    public int? PreferredGroupId { get; set; }
    public Group? PreferredGroup { get; set; }
    public DateTime ApplicationDate { get; set; }
    public string Status { get; set; } = null!;
    public string? Comment { get; set; }
}