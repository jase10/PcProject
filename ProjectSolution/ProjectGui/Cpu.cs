using System;
using System.Collections.Generic;

namespace ProjectGui
{
    public partial class Cpu
    {
        public int CpuId { get; set; }
        public string CpuName { get; set; }
        public int? CoreCount { get; set; }
        public double? CoreClock { get; set; }
        public double? BoostClock { get; set; }
        public int? Tdp { get; set; }
        public double? Price { get; set; }


        public override string ToString()
        {
            return $"{CpuId}, {CpuName}, {CoreCount}, {CoreClock}, {BoostClock}, {Tdp}, {Price}";
        }
    }

    
    
}
