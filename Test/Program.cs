using Archlinux.Api;
using Archlinux.Api.Methods;
using Archlinux.Api.Types;
using Archlinux.Api.Types.Result;
class MainTest
{
    public async static Task Main()
    {
        ArchlinuxApi archlinuxctx = new ArchlinuxApi();
        PackageDetails pkgdetails = new PackageDetails(archlinuxctx, usefiles: false);
   
        PackageDetailAll res = await pkgdetails.Name("0ad").Repository(ArchRepository.FromString("community")).Architecture(Arch.FromString("x86_64")).get();


        Console.WriteLine(res.pkgdesc);
        // Console.WriteLine(res.pkgbase);
        // Console.WriteLine(res.pkgdesc);

        // community
        // PackageSearch pkgsearch = new PackageSearch(archlinuxctx);
        // PackageSearchResult pkgres = await pkgsearch.Query("a").Repository(ArchRepository.FromString("community")).get(1);

        // Console.WriteLine(pkgres.results[0].pkgdesc);
    }
}