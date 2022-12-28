using Archlinux.Api.Types.Result;

namespace Archlinux.Api.Types.Result
{
    public class PackageSearchResult {
        public int version { get; set; } 
        public int limit { get; set; } 
        public bool valid { get; set; } 
        public PackageDetailsResult[] results { get; set; } 
        public int num_pages { get; set; } 
        public int page { get; set; } 
        
    } 
}
