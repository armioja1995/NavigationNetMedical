//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NavigationNetMedical.DBO
{
    using System;
    using System.Collections.Generic;
    
    public partial class productwarehouse
    {
        public string v_WarehouseId { get; set; }
        public string v_ProductId { get; set; }
        public Nullable<float> r_StockMin { get; set; }
        public Nullable<float> r_StockMax { get; set; }
        public Nullable<float> r_StockActual { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual product product { get; set; }
        public virtual warehouse warehouse { get; set; }
    }
}