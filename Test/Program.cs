using Archlinux.Api;
using Archlinux.Api.Methods;
class MainTest
{
    public async static Task Main()
    {
        ArchlinuxApi archlinuxctx = new ArchlinuxApi();
        var pkgdetails = new PackageDetails(archlinuxctx);
        await pkgdetails.Get("/packages/core/x86_64/coreutils/json/");
    }

}