namespace DatabaseTask.Core.Domain;

public class MealServing
{
    public int Id { get; set; }
    public int DailyMenuId { get; set; }
    public DailyMenu DailyMenu { get; set; } = null!;
    public int GroupId { get; set; }
    public Group Group { get; set; } = null!;
    public int PortionsServed { get; set; }
    public string? Comment { get; set; }
}