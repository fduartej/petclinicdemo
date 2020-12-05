//Carrito es una Orden de Compra detalles productos ID, 
//Precio* y Cantidad*, logueado*

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace petclinicdemo.Models
{
    [Table("t_orden_detail")]
    public class OrdenDetail
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        [Column("productid")]
        public int producID { get; set; }

        [Display(Name="Correo")]
        [Column("email")]
        public String Email { get; set; }
 
        [Display(Name="Cantidad")]
        [Column("quantity")]
        public Decimal Quantity { get; set; }

        [Display(Name="Precio")]
        [Column("price")]
        public Decimal Price { get; set; }
    }
}
       