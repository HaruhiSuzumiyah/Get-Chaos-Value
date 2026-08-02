using System;
using System.Collections.Generic;

namespace Ninja_Price.API.PoeNinja;

// poe.ninja prices Forbidden Flame/Flesh per allocated ascendancy passive rather than as a single
// aggregate line, so this overview is keyed differently from the other unique ones: Name is the
// passive ("War of Attrition"), and Variant is the item ("Forbidden Flame" or "Forbidden Flesh").
public class ForbiddenJewels
{
    public class RootObject
    {
        public List<Line> Lines { get; set; }
    }

    public class Line
    {
        public long? Id { get; set; }

        /// <summary>The allocated ascendancy passive, e.g. "War of Attrition" - not the item name.</summary>
        public string Name { get; set; }

        public Uri Icon { get; set; }
        public string BaseType { get; set; }

        /// <summary>The item name: "Forbidden Flame" or "Forbidden Flesh".</summary>
        public string Variant { get; set; }

        public long? ItemClass { get; set; }
        public Sparkline SparkLine { get; set; }
        public string ItemType { get; set; }
        public double? ChaosValue { get; set; }
        public double? ExaltedValue { get; set; }
        public double? DivineValue { get; set; }
        public long? Count { get; set; }
        public string DetailsId { get; set; }
        public long? ListingCount { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Metadata
    {
        public string BaseClass { get; set; }
        public string Ascendancy { get; set; }
        public string PassiveName { get; set; }
    }

    public class Sparkline
    {
        public List<double?> Data { get; set; }
        public double? TotalChange { get; set; }
    }
}
