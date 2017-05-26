namespace ConsoleApplication1.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupUser")]
    public partial class GroupUser
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        public int? RoleID { get; set; }
    }
}
