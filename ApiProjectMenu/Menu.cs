namespace ApiProjectMenu;

public class Menu
{
    public int id { get; set; }
    public string name { get; set; }
    public decimal price { get; set; }
    public string? description { get; set; }
    public int idCategoryMenu { get; set; }
}
public class CategoryMenu
{
    public int id { get; set; }
    public string name { get; set; }
    public string? description { get; set; }
}
public class ViewMenu
{
    public int id { get; set; }
    public string name { get; set; }
    public decimal price { get; set; }
    public string? description { get; set; }
    public string? catMenu { get; set; }

    public ViewMenu (
        int _id,
        string _name,
        decimal _price,
        string? _description,
        string? _catMenu 
        )
    {
        id = _id;
        name = _name;
        price = _price;
        description = _description;
        catMenu = _catMenu;
    }
}