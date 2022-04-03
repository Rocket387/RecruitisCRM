using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Risks
{
    public class DeleteModel : PageModel
    {
        private readonly Recruitis.Data.RecruitisContext _context;

        public DeleteModel(Recruitis.Data.RecruitisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Risk Risk { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Risk = await _context.Risks.FirstOrDefaultAsync(m => m.RiskID == id);

            if (Risk == null)
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

            Risk = await _context.Risks.FindAsync(id);

            if (Risk != null)
            {
                _context.Risks.Remove(Risk);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
