using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Caching
{
    public class CacheSettings
    {
        public int SlidingExpiration { get; set; }
    }
}
