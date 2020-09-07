using Meomv.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Meomv.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}