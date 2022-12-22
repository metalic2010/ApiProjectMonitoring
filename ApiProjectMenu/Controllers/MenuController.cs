using ApiProjectMenu.DataBases;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjectMenu.Controllers;

[ApiController]
[Route("[controller]")]
public class MenuController : ControllerBase
{

    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    [HttpGet("GetMenu")]
    public IEnumerable<Menu> GetListMenu()
    {
        return MenuDB.GetMenu();
    }

    [HttpGet("GetCategoryMenu")]
    public IEnumerable<CategoryMenu> GetListCategoryMenu()
    {
        return CategoryMenuDB.GetCategoryMenu();
    }

    [HttpGet("GetViewMenu")]
    public IEnumerable<ViewMenu> GetViewMenu()
    {
        return ViewListMenu.GetViewMenu();
    }
}