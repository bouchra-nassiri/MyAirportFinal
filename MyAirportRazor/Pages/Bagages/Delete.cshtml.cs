using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyAirport.EF;

namespace MyAirportRazor.Pages.Bagages
{
    public class DeleteModel : PageModel
    {
        private readonly MyAirport.EF.MyAirportContext _context;

        public DeleteModel(MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Bagage Bagage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bagage = await _context.Bagages
                .Include(b => b.Vol).FirstOrDefaultAsync(m => m.BagageID == id);

            if (Bagage == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bagage = await _context.Bagages.FindAsync(id);

            if (Bagage != null)
            {
                _context.Bagages.Remove(Bagage);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
