using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MederApplication.Models; // Ajuste o namespace conforme necessário

namespace MederApplication.Controllers
{
    public class MedicamentosController : Controller
    {
        private readonly AppDbContext _context;

        public MedicamentosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Medicamentos
        public async Task<IActionResult> Index()
        {
            var medicamentos = await _context.Medicamentos.ToListAsync();
            return View(medicamentos);
        }

        // GET: Medicamentos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medicamentos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MedicamentoId,Nome,Lote,Validade,Localizacao,Quantidade")] Medicamento medicamento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(medicamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(medicamento);
        }
    }
}
