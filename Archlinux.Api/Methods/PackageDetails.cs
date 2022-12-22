using Archlinux.Api.Types;

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
    }
}