//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2019
{
    using System;
    using System.Collections.Generic;
    
    public partial class FEMAnalysi
    {
        public int IdFEMAnalysis { get; set; }
        public int IdEmployee { get; set; }
        public byte[] NewPattern { get; set; }
        public string AnalysisResults { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
