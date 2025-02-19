using Bookist.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bookist.Web.Controllers;

public class TagController : Controller
{
    private readonly TagService _tagService;

    public TagController(TagService tagService)
    {
        _tagService = tagService;
    }

    public async Task<ViewResult> Index()
    {
        var vm = await _tagService.GetAsync();
        return View(vm);
    }
}
