﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab_4.Models;

namespace Lab_4.Pages.Link
{
    public class FindModel : PageModel
    {
        private readonly Data.AppDbContext _context;

        public FindModel(Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Links> Link { get;set; } = default!;
        public IList<Links> Result { get; set; } = default!;

        [BindProperty]
        public string Search { get; set; } = default;
        public async Task OnGetAsync()
        {
            if (_context.Links != null)
            {
                await SetMessages();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (_context.Links != null)
            {
                await SetMessages();
            }
            return Page();
        }

        private async Task SetMessages()
        {
            Link = await _context.Links.ToListAsync();
            Result = new List<Links>();

            if (Search != null) {
                var words = Search.Split(',');

                foreach (var link in Link)
                {
                    foreach (var word in words)
                    {
                        if (link.Url.Contains(word) || link.Description.Contains(word))
                        {
                            Result.Add(link);
                        }
                    }
                }
            }
           

        }
    }
}
