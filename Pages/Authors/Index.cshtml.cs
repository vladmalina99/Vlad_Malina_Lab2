using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vlad_Malina_Lab2.Data;
using Vlad_Malina_Lab2.Models;

namespace Vlad_Malina_Lab2.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly Vlad_Malina_Lab2.Data.Vlad_Malina_Lab2Context _context;

        public IndexModel(Vlad_Malina_Lab2.Data.Vlad_Malina_Lab2Context context)
        {
            _context = context;
        }

        public IList<Vlad_Malina_Lab2.Models.Authors> Authors { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Authors = await _context.Authors.ToListAsync();
        }
    }
}
