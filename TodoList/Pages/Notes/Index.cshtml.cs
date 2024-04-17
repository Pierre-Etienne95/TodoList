using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TodoList.Data;
using TodoList.Models;

namespace TodoList.Pages.Notes
{
    public class IndexModel : PageModel
    {
        private readonly TodoList.Data.TodoListContext _context;

        public IndexModel(TodoList.Data.TodoListContext context)
        {
            _context = context;
        }

        public IList<Note> Note { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Note != null)
            {
                Note = await _context.Note.ToListAsync();
            }
        }
    }
}
