using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace Autenticacion.Pages.Subject
{
    [Authorize]
    public class SubjectModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
