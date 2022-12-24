using Archlinux.Api.Types;
using Archlinux.Api.Exception;
using Archlinux.Api.Utils;
using Archlinux.Api.Types.Result;
using Newtonsoft.Json;

namespace Archlinux.Api.Methods
{

    public class PackageDetailsCtx
    {
        public string PkgName { get; set; }
        public ArchRepository Repo { get; set; }
        public Arch architecture { get; set; }
        public bool? files { get; set; }
    }
    public class PackageDetails : PackageDetailAll
    {
        private ArchlinuxApi ctx;
        private PackageDetailsCtx pkgcontext = new Archlinux.Api.Methods.PackageDetailsCtx();

        public PackageDetails(ArchlinuxApi ctx, bool usefiles = false)
        {
            this.pkgcontext.files = usefiles;
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

        public PackageDetails GetFiles(bool usefiles)
        {
            this.pkgcontext.files = usefiles;
            return this;
        }

        public async Task<PackageDetailAll> get()
        {
            string uristr;
            if (this.pkgcontext.files == false)
            {
                uristr = $"/packages/{this.pkgcontext.Repo.ToString()}/{this.pkgcontext.architecture.ToString()}/{this.pkgcontext.PkgName.ToString()}/json/";
            }
            else
            {
                uristr = $"/packages/{this.pkgcontext.Repo.ToString()}/{this.pkgcontext.architecture.ToString()}/{this.pkgcontext.PkgName.ToString()}/files/json/";
            }
            HttpInstance res = await this.ctx.http.createReq(uristr);

            if (this.ctx.http.StatusCode() == System.Net.HttpStatusCode.NotFound)
            {
                throw new NotFound();
            }
            else
            {
                if (this.pkgcontext.files == false)
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<PackageDetailsResult>(await this.ctx.http.GetString());
                } else {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<PackageDetailsResultFile>(await this.ctx.http.GetString());
                }
                
            }
            //Console.WriteLine(await res.GetString());
        }
    }
}