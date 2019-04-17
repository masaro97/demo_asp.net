namespace Models.FW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEM")]
    public partial class DIEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string MASV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string MAMH { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LAN { get; set; }

        public int HOCKY { get; set; }

        [Column("DIEM")]
        public double DIEM1 { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
