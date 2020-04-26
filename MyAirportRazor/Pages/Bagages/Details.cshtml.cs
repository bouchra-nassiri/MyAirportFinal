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
    public class DetailsModel : PageModel
    {
        private readonly MyAirport.EF.MyAirportContext _context;

        public DetailsModel(MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

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
    }
}
