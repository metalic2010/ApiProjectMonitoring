# ѕроект мониторинга сервисов
“естовый проект по монииторингу сервисов, создан в цел€х получени€ практического опыта.
ѕроект делитс€ на 2 части:
- ћониторинг (проект мониторинга)
- —ервисы (раздел с 1 api, создана чисто дл€ целей мониторинга)

## ћониторинг
—одержание:
1. Program - стандартный класс с дополнением строк дл€ HealthChecks
2. appsettings.json - стандартный файл с дополнением строк дл€ HealthChecks
## —ервис
—одержание:
1. DataBases
* CategoryMenuDB - таблица категорий меню
-- GetCategoryMenu() - метод со статическим набором информации по категори€м меню
- MenuDB - таблица меню
-- GetMenu() - метод со статическим набором информации о меню
- ViewListMenu - view (динамическое представление объединени€ двух таблиц)
-- GetViewMenu() - метод дл€ join`а таблиц
2. HealthChecks
* APIHealthChecks
-- CheckHealthAsync() - обработка полученного результата
-- IsDatabaseConnectionOkAsync() - получение данных об успешности
3. Controllers
* MenuController (3 get запроса)
-- GetMenu - api ответ с выводом информации о меню
-- GetCategoryMenu - api ответ с выводом информации о категори€х меню
-- GetViewMenu - api ответ с выводом сводной информации о меню
4. Menu - класс с объектами меню, категорий меню и view
5. Program - стандратный класс с дополнением строк дл€ HealthChecks

## »нформаци€ по стеку и пакетам
- C# (ASP .NET Core Web API)
-- [AspNetCore.HealthChecks.UI](https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks)
-- [AspNetCore.HealthChecks.UI.InMemory.Storage](https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks)
-- [AspNetCore.HealthChecks.UI.Client](https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks)