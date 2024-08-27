using LibrarySystem.Data;
using LibrarySystem.Models;
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

    [Route("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(DocumentType documentType)
    {
        if (ModelState.IsValid)
        {
            _context.Add(documentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        else
        {
            _logger.LogError("Error saving");
            return View(documentType);
        }
    }


}
