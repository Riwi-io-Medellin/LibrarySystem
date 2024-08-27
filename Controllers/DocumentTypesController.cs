using LibrarySystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    public async Task<IActionResult> Index()
    {
        var allDocumentTypes = await _context.DocumentTypes.ToListAsync();
        return View(allDocumentTypes);
    }
    

}
