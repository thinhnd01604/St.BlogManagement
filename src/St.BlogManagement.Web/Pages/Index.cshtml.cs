using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace St.BlogManagement.Web.Pages;

public class IndexModel : BlogManagementPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
