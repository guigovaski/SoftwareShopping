using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IdentityServer.Pages.Account.Register;

public class Index : PageModel
{
    
    [BindProperty]
    public InputModel Input { get; set; }
    
    public void OnGet()
    {
        
    }

    public IActionResult OnGetLoginAsync(string returnUrl)
    {
        return RedirectToPage("~/Pages/Account/Login", new { ReturnUrl = returnUrl });
    }
}