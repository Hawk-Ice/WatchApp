//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class WatchTable
    {
        public int Id { get; set; }
        public string image { get; set; }
        public string item_number { get; set; }
        public string short_desc { get; set; }
        public string full_desc { get; set; }
        public string price { get; set; }
        public string caliber { get; set; }
        public string movement { get; set; }
        public string chronograph { get; set; }
        public string weight { get; set; }
        public string height { get; set; }
        public string diameter { get; set; }
        public string thickness { get; set; }
        public string jewel { get; set; }
        public string case_material { get; set; }
        public string strap_material { get; set; }
        public string product_name { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
