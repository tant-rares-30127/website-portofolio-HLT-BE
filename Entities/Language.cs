using Newtonsoft.Json;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level Understanding { get; set; }
        public Level Speaking { get; set; }
        public Level Writing { get; set; }
    }
}

public enum Level
{
    L0,
    L1,
    L2,
    L3,
    L4
}