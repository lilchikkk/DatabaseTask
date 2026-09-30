namespace DatabaseTask.Core.Domain;

public class DailyMenu
{
    public int Id { get; set; }
    public int DishId { get; set; }
    public Dish Dish { get; set; } = null!;
    public DateTime MenuDate { get; set; }
    public string? Comment { get; set; }

    public ICollection<MealServing> MealServings { get; set; } = new List<MealServing>();
}