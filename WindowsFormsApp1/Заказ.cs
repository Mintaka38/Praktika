namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(150)]
        public string Номер { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(150)]
        public string Дата { get; set; }

        [Column("Этап выполнения")]
        [Required]
        [StringLength(50)]
        public string Этап_выполнения { get; set; }

        [Required]
        [StringLength(150)]
        public string Заказчик { get; set; }

        [StringLength(150)]
        public string Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Заказные_изделия Заказные_изделия { get; set; }

        public virtual Пользователь Пользователь { get; set; }
    }
}
