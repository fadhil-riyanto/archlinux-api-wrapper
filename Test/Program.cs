using Archlinux.Api;
using Archlinux.Api.Methods;
using Archlinux.Api.Types;
class MainTest
{
    public async static Task Main()
    {
        ArchlinuxApi archlinuxctx = new ArchlinuxApi();
        var pkgdetails = new PackageDetails(archlinuxctx);
        await pkgdetails.Name("coreutils").Repository(ArchRepository.community).Architecture(Arch.x86_64).get();
    }

}