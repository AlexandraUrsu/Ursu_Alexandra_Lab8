using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ursu_Alexandra_Lab8.Data;
using Ursu_Alexandra_Lab8.Models;

namespace Ursu_Alexandra_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Ursu_Alexandra_Lab8.Data.Ursu_Alexandra_Lab8Context _context;

        public IndexModel(Ursu_Alexandra_Lab8.Data.Ursu_Alexandra_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
