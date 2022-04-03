using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Recruitis.Data;
using Recruitis.Models;

namespace Recruitis.Pages.Companys
{
    public class IndexModel : PageModel
    {
        private readonly Recruitis.Data.RecruitisContext _context;

        public IndexModel(Recruitis.Data.RecruitisContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Companys.ToListAsync();
        }
    }
}
