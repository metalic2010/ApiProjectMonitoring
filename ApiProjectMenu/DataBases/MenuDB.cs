namespace ApiProjectMenu.DataBases;

public class MenuDB
{
    public static IEnumerable<Menu> GetMenu()
    {
        IEnumerable<Menu> listMenu = new List<Menu>
        {
            new Menu
            {
                id = 1,
                name = "Салат крабовый",
                price = 100,
                description = "Салат из крабовых палочек",
                idCategoryMenu = 1
            },
            new Menu
            {
                id = 2,
                name = "Салат кальмаровый",
                price = 150,
                description = "Салат из крабовых палочек",
                idCategoryMenu = 1
            },
            new Menu
            {
                id = 3,
                name = "Салат восточный",
                price = 300,
                description = "Горячий салат из говядины по восточному",
                idCategoryMenu = 2
            },
            new Menu
            {
                id = 4,
                name = "Кофе",
                price = 50,
                description = "Кофе 3 в 1",
                idCategoryMenu = 3
            },
            new Menu
            {
                id = 5,
                name = "Чай",
                price = 50,
                description = "Чай чёрный цейлонский",
                idCategoryMenu = 3
            },
            new Menu
            {
                id = 6,
                name = "Наполеон",
                price = 500,
                description = "Торт наполеон",
                idCategoryMenu = 4
            }
        };

        return listMenu;
    }
}