
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gestaopedidos.Models



{
    [Table("tb_pedidos")]
    public class OrdersModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

    
        public String cliente { get; set; }

        public String produto { get; set; }

        public Decimal valor { get; set; }

        public String status { get; set; }

          }
}