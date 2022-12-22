using Archlinux.Api;
using Archlinux.Api.Methods;
using Archlinux.Api.Types;
using Archlinux.Api.Types.Result;
class MainTest
{
    public async static Task Main()
    {
        ArchlinuxApi archlinuxctx = new ArchlinuxApi();
        PackageDetails pkgdetails = new PackageDetails(archlinuxctx);
        PackageDetailAll res = await pkgdetails.Name("linux").Repository(ArchRepository.core).Architecture(Arch.x86_64).GetFiles(true).get();


        // Console.WriteLine(res.pkgname);
        // Console.WriteLine(res.pkgbase);
        Console.WriteLine(res.files_count);
    }
}