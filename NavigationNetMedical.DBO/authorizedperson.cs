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
    
    public partial class authorizedperson
    {
        public string v_AuthorizedPersonId { get; set; }
        public string v_FirstName { get; set; }
        public string v_FirstLastName { get; set; }
        public string v_SecondLastName { get; set; }
        public Nullable<int> i_DocTypeId { get; set; }
        public string v_DocTypeName { get; set; }
        public string v_DocNumber { get; set; }
        public Nullable<int> i_SexTypeId { get; set; }
        public string v_SexTypeName { get; set; }
        public Nullable<System.DateTime> d_BirthDate { get; set; }
        public string v_OccupationName { get; set; }
        public string v_OrganitationName { get; set; }
        public Nullable<System.DateTime> d_EntryToMedicalCenter { get; set; }
        public string v_ProtocolId { get; set; }
        public string v_ProtocolName { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
    }
}
