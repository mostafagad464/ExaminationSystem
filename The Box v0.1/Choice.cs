//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace The_Box_v0._1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Choice
    {
        public string C_ID { get; set; }
        public string Choice_Text { get; set; }
        public int Q_ID { get; set; }
    
        public virtual Question Question { get; set; }
    }
}