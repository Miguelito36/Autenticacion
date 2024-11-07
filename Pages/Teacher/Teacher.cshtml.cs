using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Autenticacion.Pages.Teacher
{
    [Authorize]
    public class TeacherModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
