//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KSUCorner.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ForumReply
    {
        public int ReplyID { get; set; }
        public string Subject { get; set; }
        public int AccountID { get; set; }
        public int ForumID { get; set; }
        public string Body { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime LastUpdateDate { get; set; }
    }
}
