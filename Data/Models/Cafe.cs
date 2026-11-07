using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sharpness_sharp.Data.Models
{
    public class Cafe
    {
        public int Id  {get; set;}
        public string? Imagen { get; set; }
        public string? NombreCafe { get; set; }
        public string? DescripcionCafe { get; set; }
        public decimal PrecioCafe { get; set; }

        public Cafe(
            string imagen,
            string nombreCafe,
            string descripcionCafe,
            decimal precioCafe)
        {
            Imagen = imagen;
            NombreCafe = nombreCafe;
            DescripcionCafe = descripcionCafe;
            PrecioCafe = precioCafe;
        }
        public Cafe()
        {
            
        }
    }
}