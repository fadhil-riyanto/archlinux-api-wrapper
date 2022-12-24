using Archlinux.Api.Types;
using Archlinux.Api.Exception;
using Archlinux.Api.Utils;
using Archlinux.Api.Types.Result;
using Newtonsoft.Json;

namespace Archlinux.Api.Methods
{

    #nullable enable
    public class PackageSearchCtx
    {
        public string? query { get; set; }
        public string? name { get; set; }
        public string? desc { get; set; }
        public ArchRepository? repo { get; set; }
        public Arch? arch { get; set; }
        public string? maintainer { get; set; }
        public string? packager { get; set; }
        public flagged? flagged { get; set; }
    }
    public class PackageSearch : PackageSearchResult
    {
        private ArchlinuxApi ctx;
        private PackageSearchCtx pkgcontext = new Archlinux.Api.Methods.PackageSearchCtx();

        public PackageSearch(ArchlinuxApi ctx)
        {
            this.ctx = ctx;

        }

        public PackageSearch Query(string q)
        {
            pkgcontext.query = q;
            return this;
        }

        public PackageSearch Name(string ExactName)
        {
            pkgcontext.name = ExactName;
            return this;
        }

        public PackageSearch Description(string Description)
        {
            pkgcontext.desc = Description;
            return this;
        }

        public PackageSearch Repository(ArchRepository Repository)
        {
            pkgcontext.repo = Repository;
            return this;
        }

        public PackageSearch Architecture(Arch arch)
        {
            this.pkgcontext.arch = arch;
            return this;
        }

        public PackageSearch Maintainer(string Maintainer)
        {
            this.pkgcontext.maintainer = Maintainer;
            return this;
        }

        public PackageSearch Packager(string Packager)
        {
            this.pkgcontext.packager = Packager;
            return this;
        }

        public PackageSearch Flagged(flagged Flagged)
        {
            this.pkgcontext.flagged = Flagged;
            return this;
        }

        


    }
}