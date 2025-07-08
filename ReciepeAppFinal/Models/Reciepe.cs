using SQLite;
namespace ReciepeAppFinal.Models;

public class Recipe
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public string Instructions { get; set; }

}