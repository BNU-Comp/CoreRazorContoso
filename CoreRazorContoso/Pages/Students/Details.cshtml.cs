﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreRazorContoso.Models;

namespace CoreRazorContoso.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly CoreRazorContoso.Models.UniversityContext _context;

        public DetailsModel(CoreRazorContoso.Models.UniversityContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Student = await _context.Student.FirstOrDefaultAsync(m => m.StudentID == id);

            Student = await _context.Student
                                    .Include(s => s.Enrollments)
                                        .ThenInclude(e => e.Course)
                                    .AsNoTracking()
                                    .FirstOrDefaultAsync(m => m.StudentID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
