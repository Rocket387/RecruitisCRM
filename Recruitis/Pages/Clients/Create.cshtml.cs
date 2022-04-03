using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Clients
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
        ViewData["CompanyID"] = new SelectList(_context.Companys, "CompanyID", "CompanyID");
        ViewData["RiskID"] = new SelectList(_context.Risks, "RiskID", "RiskID");
        ViewData["StatusID"] = new SelectList(_context.Statuss, "StatusID", "StatusID");
            return Page();
        }

        [BindProperty]
        public Client Client { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
