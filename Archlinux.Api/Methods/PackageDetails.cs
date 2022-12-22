using Archlinux.Api.Types;
using Archlinux.Api.Exception;
using Archlinux.Api.Utils;
using Newtonsoft.Json;

namespace Archlinux.Api.Methods
{
    
    public class PackageDetailsCtx
    {   
        public string PkgName {get; set;}
        public ArchRepository Repo {get; set;}
        public Arch architecture {get; set;}
    }
    public class PackageDetails
    {
        private ArchlinuxApi ctx;
        private PackageDetailsCtx pkgcontext = new Archlinux.Api.Methods.PackageDetailsCtx();

        public PackageDetails(ArchlinuxApi ctx)
        {
            this.ctx = ctx;
            
        }

        public PackageDetails Name(string PkgName)
        {
            pkgcontext.PkgName = PkgName;
            return this;
        }

        public PackageDetails Repository(ArchRepository Repo)
        {
            this.pkgcontext.Repo = Repo;
            return this;
        }

        public PackageDetails Architecture(Arch arch)
        {
            this.pkgcontext.architecture = arch;
            return this;
        }

        public async Task get()
        {
            HttpInstance res = await this.ctx.http.createReq($"/packages/{this.pkgcontext.Repo.ToString()}/{this.pkgcontext.architecture.ToString()}/{this.pkgcontext.PkgName.ToString()}/json/");

            if (this.ctx.http.StatusCode() == System.Net.HttpStatusCode.NotFound)
            {
                throw new NotFound();
            } else {
                
            }
            Console.WriteLine(await res.GetString());
        }
    }
}