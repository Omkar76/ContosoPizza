namespace ContosoPizza.Models;
public class Pizza
{

    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public bool IsGlutenFree { get; set; }
}