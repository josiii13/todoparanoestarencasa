using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 
namespace sharpness_sharp.Data.Models
{
    public class Ventas
    {
        public int Id{get;set;}
        public string Id_Cliente{get;set;}
        public int Id_Cafe {get;set;}
        public int Cantidad{get;set;}
        public double TotalVenta{get;set;}
        public DateTime Fecha_Venta {get;set;}
        public ApplicationUser Cliente{get; set;}
        public Cafe Cafe{get; set;}


 
        public Ventas(string id_cliente, int id_cafe, int cantidad, double total_venta, DateTime fecha_venta)
        {
            Id_Cliente = id_cliente;
            Id_Cafe = id_cafe;
            Cantidad = cantidad;
            TotalVenta = total_venta;
            Fecha_Venta = fecha_venta;
        }
 
        public Ventas()
        {
           
        }
    }
}