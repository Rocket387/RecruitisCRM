using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Statuss
{
    public class IndexModel : PageModel
    {
        private readonly Recruitis.Data.RecruitisContext _context;

        public IndexModel(Recruitis.Data.RecruitisContext context)
        {
            _context = context;
        }

        public IList<Status> Status { get;set; }

        public async Task OnGetAsync()
        {
            Status = await _context.Statuss.ToListAsync();
        }
    }
}
