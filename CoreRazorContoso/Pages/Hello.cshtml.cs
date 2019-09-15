using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreRazorContoso.Pages
{
    public class HelloModel : PageModel
    {
        public String name;

        public void OnGet()
        {
            name = null;
        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}