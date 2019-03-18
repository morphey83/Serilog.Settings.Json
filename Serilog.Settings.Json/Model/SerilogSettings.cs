using System.Collections.Generic;
using System.Linq;

namespace Serilog.Settings.Json.Model
{
    public class SerilogSettings: ISerilogConfig
    {
        public MinimumLevel MinimumLevel { get; set; }
        public List<Using> Using { get; set; }
        public List<WriteTo> WriteTo { get; set; }
        public List<AuditTo> AuditTo { get; set; }
        public List<Filter> Filter { get; set; }
        public List<Enrich> Enrich { get; set; }
        public List<Destructure> Destructure { get; set; }
        public Dictionary<string, string> Properties { get; set; }
        
        public IEnumerable<KeyValuePair<string, string>> GetSettings()
        {
            return new List<KeyValuePair<string, string>>()
                .Concat(MinimumLevel.AsKeyValue("minimum-level"))
                .Concat((Using ?? new List<Using>()).SelectMany(it => it.AsKeyValue("using")))
                .Concat((WriteTo ?? new List<WriteTo>()).SelectMany(it => it.AsKeyValue("write-to")))
                .Concat((AuditTo ?? new List<AuditTo>()).SelectMany(it => it.AsKeyValue("audit-to")))
                .Concat((Filter ?? new List<Filter>()).SelectMany(it => it.AsKeyValue("filter")))
                .Concat((Enrich ?? new List<Enrich>()).SelectMany(it => it.AsKeyValue("enrich")))
                .Concat((Destructure ?? new List<Destructure>()).SelectMany(it => it.AsKeyValue("destructure")))
                .Concat(Properties?.AsEnumerable() ?? new List<KeyValuePair<string,string>>())
                ;
        }
    }
}