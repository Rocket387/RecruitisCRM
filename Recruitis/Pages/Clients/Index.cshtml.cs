using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly Recruitis.Data.RecruitisContext _context;

        public IndexModel(Recruitis.Data.RecruitisContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; }

        public async Task OnGetAsync()
        {
            Client = await _context.Clients
                .Include(c => c.Company)
                .Include(c => c.Risk)
                .Include(c => c.Status).ToListAsync();
        }
    }
}
