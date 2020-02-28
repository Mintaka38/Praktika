namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ткань
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ткань()
        {
            Склад_ткани = new HashSet<Склад_ткани>();
            Изделие = new HashSet<Изделие>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(50)]
        public string Наименование { get; set; }

        [StringLength(50)]
        public string Цвет { get; set; }

        [StringLength(50)]
        public string Рисунок { get; set; }

        [StringLength(50)]
        public string Состав { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        public decimal Цена { get; set; }

        [StringLength(1)]
        public string Изображение { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_ткани> Склад_ткани { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Изделие> Изделие { get; set; }
    }
}
