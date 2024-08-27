using LibrarySystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers;

[Route("[controller]")]
public class DocumentTypesController : Controller
{
    private readonly ILogger<DocumentTypesController> _logger;
    private readonly ApplicationDbContext _context;



    public DocumentTypesController(ILogger<DocumentTypesController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var allDocumentTypes = _context.DocumentTypes.ToList();
        return View(allDocumentTypes);
    }

}
