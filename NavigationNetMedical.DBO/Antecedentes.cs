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
    
    public partial class Antecedentes
    {
        public string v_AntecedentesId { get; set; }
        public string v_PersonaId { get; set; }
        public string v_AntPersonales { get; set; }
        public string v_AntFamiliares { get; set; }
        public string v_AntLaborales { get; set; }
        public string v_AntPatologicos { get; set; }
        public Nullable<System.DateTime> d_FechaInsercion { get; set; }
        public Nullable<int> i_UsuarioInsertaId { get; set; }
        public Nullable<System.DateTime> d_FechaActualizacion { get; set; }
        public Nullable<int> i_UsuarioActualizaId { get; set; }
        public Nullable<bool> i_EsEliminado { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}