namespace Models.FW
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            DIEMs = new HashSet<DIEM>();
        }

        [Key]
        [StringLength(8)]
        public string MASV { get; set; }

        [Required(ErrorMessage="Bạn chưa nhập họ")]
        [StringLength(40)]
        public string HO { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tên")]
        [StringLength(10,ErrorMessage="ký tự tối thiểu là 10")]
        public string TEN { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NGAYSINH { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập phái")]
        [StringLength(3)]
        
        public string PHAI { get; set; }

        [StringLength(50)]
        public string NOISINH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        public bool? NGHIHOC { get; set; }

        [StringLength(8)]
        public string MALOP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DIEM> DIEMs { get; set; }

        public virtual LOP LOP { get; set; }
    }
}
