//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_Football_Club.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goal
    {
        public int Id { get; set; }
        public string PlayerUserName { get; set; }
        public int MatchId { get; set; }
        public int NumberOfGoals { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Card { get; set; }
        public int Point { get; set; }
    
        public virtual Match Match { get; set; }
        public virtual Player Player { get; set; }
    }
}
