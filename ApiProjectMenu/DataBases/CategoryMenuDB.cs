namespace ApiProjectMenu.DataBases;

public class CategoryMenuDB
{
    public static IEnumerable<CategoryMenu> GetCategoryMenu()
    {
        IEnumerable<CategoryMenu> listCatMenu = new List<CategoryMenu> { 
            new CategoryMenu{
                id = 1,
                name = "Салаты",
                description = "Категория салатов"
            },
            new CategoryMenu{
                id = 2,
                name = "Горячие салаты",
                description = "Категория горячих салатов"
            },
            new CategoryMenu{
                id = 3,
                name = "Напитки",
                description = "Категория напитков"
            },
            new CategoryMenu{
                id = 4,
                name = "Десерты",
                description = "Категория десертов"
            }
        };

        return listCatMenu;
    }
}
