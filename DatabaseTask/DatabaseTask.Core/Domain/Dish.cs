namespace DatabaseTask.Core.Domain;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!;
    public string? Comment { get; set; }

    public ICollection<DailyMenu> DailyMenus { get; set; } = new List<DailyMenu>();
}