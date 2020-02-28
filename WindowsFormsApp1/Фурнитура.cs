namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Фурнитура
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Фурнитура()
        {
            Склад_фурнитуры = new HashSet<Склад_фурнитуры>();
            Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(150)]
        public string Наименование { get; set; }

        public double Ширина { get; set; }

        public double? Длина { get; set; }

        [Required]
        [StringLength(50)]
        public string Тип { get; set; }

        public double Цена { get; set; }

        public double? Вес { get; set; }

        [StringLength(1)]
        public string Изображение { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад_фурнитуры> Склад_фурнитуры { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }
    }
}
