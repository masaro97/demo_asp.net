namespace Models.FW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            DIEMs = new HashSet<DIEM>();
        }

        [Key]
        [StringLength(8)]
        public string MAMH { get; set; }

        [Required]
        [StringLength(30)]
        public string TENMH { get; set; }

        public int? SOTIET_LT { get; set; }

        public int? SOTIET_TH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }
    }
}
