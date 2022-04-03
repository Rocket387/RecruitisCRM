using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Risks
{
    public class CreateModel : PageModel
    {
        private readonly Recruitis.Data.RecruitisContext _context;

        public CreateModel(Recruitis.Data.RecruitisContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Risk Risk { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Risks.Add(Risk);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
