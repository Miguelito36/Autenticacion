using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Autenticacion.Pages.Student
{
    [Authorize]
    public class StudentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
