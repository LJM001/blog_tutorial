using Volo.Abp.Modularity;

namespace Meomv.Blog
{
    [DependsOn(
        typeof(BlogApplicationModule),
        typeof(BlogDomainTestModule)
        )]
    public class BlogApplicationTestModule : AbpModule
    {

    }
}