using System;
using System.Collections.Generic;

namespace DalUnlocker
{
    public partial class NddSuprimento
    {
        public double SupplyModelId { get; set; }
        public string BrandName { get; set; }
        public string SupplyColorName { get; set; }
        public string SupplySubFunctionTypeName { get; set; }
        public string Description { get; set; }
        public string InternalCode { get; set; }
        public string PartNumber { get; set; }
        public string SupplyModelQualityName { get; set; }
        public double? BrandId { get; set; }
        public double? SupplyColorId { get; set; }
        public double? SupplySubFunctionTypeId { get; set; }
        public double? SupplyModelQualityId { get; set; }
        public double? SystemType { get; set; }
        public double? Capacity { get; set; }
    }
}