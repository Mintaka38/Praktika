namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Факт поступления материала")]
    public partial class Факт_поступления_материала
    {
        [Key]
        [Column("Номер поставки", Order = 0)]
        [StringLength(50)]
        public string Номер_поставки { get; set; }

        [Key]
        [Column("Закупаемый материал", Order = 1)]
        [StringLength(50)]
        public string Закупаемый_материал { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Количество { get; set; }

        [Key]
        [Column("Закупочная цена", Order = 3)]
        [StringLength(50)]
        public string Закупочная_цена { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Сумма { get; set; }
    }
}
