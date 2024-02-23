namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Task
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int Priority { get; set; }

        public bool Completed { get; set; }

        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
