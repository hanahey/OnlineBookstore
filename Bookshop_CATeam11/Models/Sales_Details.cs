namespace Bookshop_CATeam11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales_Details
    {
        [Key]
        public int SalesDetailID { get; set; }

        public int SalesID { get; set; }

        public int BookID { get; set; }

        public int MemberID { get; set; }
    }
}
