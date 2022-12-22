using Archlinux.Api;
using Archlinux.Api.Methods;
using Archlinux.Api.Types;
class MainTest
{
    public async static Task Main()
    {
        ArchlinuxApi archlinuxctx = new ArchlinuxApi();
        PackageDetails pkgdetails = new PackageDetails(archlinuxctx);
        await pkgdetails.Name("coreutils").Repository(ArchRepository.core).Architecture(Arch.x86_64).get();
    }

}