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
    
    public partial class rolenodecomponentprofile
    {
        public string v_RoleNodeComponentId { get; set; }
        public Nullable<int> i_NodeId { get; set; }
        public Nullable<int> i_RoleId { get; set; }
        public string v_ComponentId { get; set; }
        public Nullable<int> i_Read { get; set; }
        public Nullable<int> i_Write { get; set; }
        public Nullable<int> i_Dx { get; set; }
        public Nullable<int> i_Approved { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public string v_ComentaryUpdate { get; set; }
    
        public virtual component component { get; set; }
        public virtual rolenode rolenode { get; set; }
    }
}