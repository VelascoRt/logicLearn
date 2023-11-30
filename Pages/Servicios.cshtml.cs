using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace logicLearn.Pages;

public class ServiciosModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public ServiciosModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

