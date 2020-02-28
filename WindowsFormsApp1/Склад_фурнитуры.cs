namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Склад фурнитуры")]
    public partial class Склад_фурнитуры
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Партия { get; set; }

        [Key]
        [Column("Артикул фурнитуры", Order = 1)]
        [StringLength(150)]
        public string Артикул_фурнитуры { get; set; }

        public double Количество { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
