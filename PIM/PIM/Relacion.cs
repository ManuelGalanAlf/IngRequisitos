//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PIM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Relacion
    {
        public int Id { get; set; }
        public string NombreRelacion { get; set; }
        public int Producto1 { get; set; }
        public int Producto2 { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Producto Producto3 { get; set; }
    }
}
