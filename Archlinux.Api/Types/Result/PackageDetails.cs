using Archlinux.Api.Types;
using Newtonsoft.Json;

namespace Archlinux.Api.Types.Result
{
    public class PackageDetailAll
    {
        public virtual string pkgname { get; set; }
        public virtual string pkgbase { get; set; }
        public virtual string repo { get; set; }
        public virtual string arch { get; set; }
        public virtual string pkgver { get; set; }
        public virtual string pkgrel { get; set; }
        public virtual int epoch { get; set; }
        public virtual string pkgdesc { get; set; }
        public virtual string url { get; set; }
        public virtual string filename { get; set; }
        public virtual int compressed_size { get; set; }
        public virtual int installed_size { get; set; }
        public virtual DateTime build_date { get; set; }
        public virtual DateTime last_update { get; set; }
        public virtual string flag_date { get; set; }
        public virtual string[] maintainers {get; set;}
        public virtual string packager { get; set; }
        public virtual string[] groups {get; set;}
        public virtual string[] licenses {get; set;}
        public virtual string[] conflicts {get; set;}
        public virtual string[] provides {get; set;}
        public virtual string[] replaces {get; set;}
        public virtual string[] depends {get; set;}
        public virtual string[] optdepends {get; set;}
        public virtual string[] makedepends {get; set;}
        public virtual string[] checkdepends {get; set;}

        // if use files params

        public virtual DateTime pkg_last_update { get; set; }
        public virtual DateTime files_last_update { get; set; }
        public virtual int files_count { get; set; }
        public virtual int dir_count { get; set; }
        public virtual string[] files { get; set; }

    }
    public class PackageDetailsResult : PackageDetailAll
    {
        public override string pkgname { get; set; }
        public override string pkgbase { get; set; }
        public override string repo { get; set; }
        public override string arch { get; set; }
        public override string pkgver { get; set; }
        public override string pkgrel { get; set; }
        public override int epoch { get; set; }
        public override string pkgdesc { get; set; }
        public override string url { get; set; }
        public override string filename { get; set; }
        public override int compressed_size { get; set; }
        public override int installed_size { get; set; }
        public override DateTime build_date { get; set; }
        public override DateTime last_update { get; set; }
        public override string flag_date { get; set; }
        public override string[] maintainers {get; set;}
        public override string packager { get; set; }
        public override string[] groups {get; set;}
        public override string[] licenses {get; set;}
        public override string[] conflicts {get; set;}
        public override string[] provides {get; set;}
        public override string[] replaces {get; set;}
        public override string[] depends {get; set;}
        public override string[] optdepends {get; set;}
        public override string[] makedepends {get; set;}
        public override string[] checkdepends {get; set;}
    }

    public class PackageDetailsResultFile : PackageDetailAll
    {
        public override string pkgname { get; set; }
        public override string repo { get; set; }
        public override string arch { get; set; }
        public override DateTime pkg_last_update { get; set; }
        public override DateTime files_last_update { get; set; }
        public override int files_count { get; set; }
        public override int dir_count { get; set; }
        public override string[] files { get; set; }
    }
}

