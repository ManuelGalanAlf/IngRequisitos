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
    
    public partial class Producto
    {
        public Producto()
        {
            this.ValorAtributo = new HashSet<ValorAtributo>();
            this.Categoria1 = new HashSet<Categoria>();
        }
    
        public string SKU { get; set; }
        public string GTIN { get; set; }
        public string nombre { get; set; }
        public string categoria_nombre { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<ValorAtributo> ValorAtributo { get; set; }
        public virtual ICollection<Categoria> Categoria1 { get; set; }
    }
}
