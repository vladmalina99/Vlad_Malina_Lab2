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
    public class DetailsModel : PageModel
    {
        private readonly Vlad_Malina_Lab2.Data.Vlad_Malina_Lab2Context _context;

        public DetailsModel(Vlad_Malina_Lab2.Data.Vlad_Malina_Lab2Context context)
        {
            _context = context;
        }

        public Vlad_Malina_Lab2.Models.Authors Authors { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var authors = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);
            if (authors == null)
            {
                return NotFound();
            }
            else
            {
                Authors = authors;
            }
            return Page();
        }
    }
}
