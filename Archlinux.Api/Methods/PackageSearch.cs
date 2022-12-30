using Archlinux.Api.Types;
using Archlinux.Api.Exception;
using Archlinux.Api.Utils;
using Archlinux.Api.Types.Result;
using System.Collections.Specialized;
using System.Web;
using Archlinux.Api.Constant;

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

    class buildhttp
    {
        private NameValueCollection data;
        private UriBuilder UriBuilder;
        public buildhttp()
        {
            this.UriBuilder = new UriBuilder();
            this.UriBuilder.Port = -1;
            this.data = HttpUtility.ParseQueryString(this.UriBuilder.Query);
        }

        public void append(string key, string value)
        {
            this.data[key] = value;
        }

        public override string? ToString()
        {
            this.UriBuilder.Query = this.data.ToString();
            return this.data.ToString();

        }
    }
#nullable enable
#nullable disable warnings
    public class PackageSearch : PackageSearchResult
    {
        private ArchlinuxApi ctx;
        private PackageSearchCtx? pkgcontext = new Archlinux.Api.Methods.PackageSearchCtx();
        private buildhttp http;

        public PackageSearch(ArchlinuxApi ctx)
        {
            this.ctx = ctx;
            this.http = new buildhttp();

        }

        public PackageSearch Query(string q)
        {
            this.http.append("q", q);
            return this;
        }

        public PackageSearch Name(string ExactName)
        {
            this.http.append("name", ExactName);
            return this;
        }

        public PackageSearch Description(string Description)
        {
            this.http.append("desc", Description);
            return this;
        }

        public PackageSearch Repository(ArchRepository Repository)
        {
            this.http.append("repo", Repository.PascalCase());
            return this;
        }

        public PackageSearch Architecture(Arch arch)
        {
            this.http.append("arch", arch.ToString());
            return this;
        }

        public PackageSearch Maintainer(string Maintainer)
        {
            this.http.append("maintainer", Maintainer);
            return this;
        }

        public PackageSearch Packager(string Packager)
        {
            this.http.append("packager", Packager);
            return this;
        }

        public PackageSearch Flagged(flagged Flagged)
        {
            this.http.append("flagged", Flagged.ToString());
            return this;
        }

        public async Task<PackageSearchResult> get(int page = 1)
        {
            this.http.append("page", page.ToString());
            HttpInstance res = await this.ctx.http.createReq(Base.BasePackageQuery + this.http.ToString());

            if (this.ctx.http.StatusCode() == System.Net.HttpStatusCode.NotFound)
            {
                throw new NotFound();
            }
            else
            {
                Console.WriteLine(await this.ctx.http.GetString());
                //return null;
                return Newtonsoft.Json.JsonConvert.DeserializeObject<PackageSearchResult>(await this.ctx.http.GetString());
            }
        }
    }
}