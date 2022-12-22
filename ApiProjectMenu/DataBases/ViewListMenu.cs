namespace ApiProjectMenu.DataBases;

public class ViewListMenu
{
    public static IEnumerable<ViewMenu> GetViewMenu()
    {
        List<ViewMenu> viewMenus= new List<ViewMenu>();

        var result = (from menu in MenuDB.GetMenu()
                     join catMenu in CategoryMenuDB.GetCategoryMenu()
                     on menu.idCategoryMenu equals catMenu.id into viewListMenu
                     from subMenu in viewListMenu.DefaultIfEmpty()
                     select new
                     {
                         id = menu.id,
                         name = menu.name,
                         price = menu.price,
                         description = menu.description,
                         catMenu = subMenu.name
                     });

        foreach (var item in result)
        {
            viewMenus.Add(new ViewMenu(
                item.id,
                item.name,
                item.price,
                item.description,
                item.catMenu
            ));
        }

        return viewMenus;
    }
}
