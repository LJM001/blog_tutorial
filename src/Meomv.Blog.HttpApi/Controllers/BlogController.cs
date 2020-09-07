using Meomv.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Meomv.Blog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlogController : AbpController
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}