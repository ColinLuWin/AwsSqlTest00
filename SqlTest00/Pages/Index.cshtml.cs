using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SqlTest00.Db;
using SqlTest00.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlTest00.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyDbContext Context;

        public List<Student> Students;

        public IndexModel(ILogger<IndexModel> logger, MyDbContext ctx)
        {
            _logger = logger;
            Context = ctx;
        }

        public void OnGet()
        {
            Students = Context.Students.ToList();
            return;
        }
    }
}
