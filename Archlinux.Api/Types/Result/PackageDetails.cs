using Archlinux.Api.Types;
using Newtonsoft.Json;

namespace Archlinux.Api.Types.Result
{
    public struct PackageDetailsResult
    {
        public string pkgname { get; set; }
        public string pkgbase { get; set; }
        public string repo { get; set; }
        public string arch { get; set; }
        public string pkgver { get; set; }
        public string pkgrel { get; set; }
        public int epoch { get; set; }
        public string pkgdesc { get; set; }
        public string url { get; set; }
        public string filename { get; set; }
        public int compressed_size { get; set; }
        public int installed_size { get; set; }
        public DateTime build_date { get; set; }
        public DateTime last_update { get; set; }
        public string flag_date { get; set; }
        public string[] maintainers {get; set;}
        public string packager { get; set; }
        public string[] groups {get; set;}
        public string[] licenses {get; set;}
        public string[] conflicts {get; set;}
        public string[] provides {get; set;}
        public string[] replaces {get; set;}
        public string[] depends {get; set;}
        public string[] optdepends {get; set;}
        public string[] makedepends {get; set;}
        public string[] checkdepends {get; set;}



        
        // {
        //     if (this.repo == "community")
        //     {
        //         return ArchRepository.community;
        //     } else if (this.repo == "core") {
        //         return ArchRepository.core;
        //     } else {
        //         return ArchRepository.extra;
        //     }
            
        // }
    }
}

