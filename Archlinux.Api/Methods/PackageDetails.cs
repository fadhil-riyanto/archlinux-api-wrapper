

namespace Archlinux.Api.Methods
{
    
    public class PackageDetails
    {
        private ArchlinuxApi ctx;
        private string PkgName;

        public PackageDetails(ArchlinuxApi ctx)
        {
            this.ctx = ctx;
            
        }

        public async Task Get(string PkgName)
        {
            await this.ctx.http.createReq(PkgName);
        }
    }
}