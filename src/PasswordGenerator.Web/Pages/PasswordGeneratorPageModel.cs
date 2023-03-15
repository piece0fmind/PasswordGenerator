using PasswordGenerator.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace PasswordGenerator.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class PasswordGeneratorPageModel : AbpPageModel
{
    protected PasswordGeneratorPageModel()
    {
        LocalizationResourceType = typeof(PasswordGeneratorResource);
    }
}
