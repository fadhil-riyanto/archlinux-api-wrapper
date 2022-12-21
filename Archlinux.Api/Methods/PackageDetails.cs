

namespace Archlinux.Api.Methods
{
    
    class PackageDetails
    {
        private ArchlinuxApi ctx;
        private string PkgName;

        public PackageDetails(ArchlinuxApi ctx, string PkgName)
        {
            this.ctx = ctx;
            this.PkgName = PkgName;
        }

        


    }
}