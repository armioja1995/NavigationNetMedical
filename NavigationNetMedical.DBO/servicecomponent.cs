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
    
    public partial class servicecomponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public servicecomponent()
        {
            this.servicecomponentfields = new HashSet<servicecomponentfields>();
            this.servicecomponentmultimedia = new HashSet<servicecomponentmultimedia>();
        }
    
        public string v_ServiceComponentId { get; set; }
        public string v_ServiceId { get; set; }
        public string v_ComponentId { get; set; }
        public Nullable<int> i_ServiceComponentStatusId { get; set; }
        public Nullable<int> i_ExternalInternalId { get; set; }
        public Nullable<int> i_ServiceComponentTypeId { get; set; }
        public Nullable<int> i_IsVisibleId { get; set; }
        public Nullable<int> i_IsInheritedId { get; set; }
        public Nullable<System.DateTime> d_CalledDate { get; set; }
        public Nullable<System.DateTime> d_StartDate { get; set; }
        public Nullable<System.DateTime> d_EndDate { get; set; }
        public Nullable<int> i_index { get; set; }
        public Nullable<float> r_Price { get; set; }
        public Nullable<int> i_IsInvoicedId { get; set; }
        public Nullable<int> i_IsRequiredId { get; set; }
        public Nullable<int> i_IsManuallyAddedId { get; set; }
        public Nullable<int> i_QueueStatusId { get; set; }
        public string v_NameOfice { get; set; }
        public string v_Comment { get; set; }
        public Nullable<int> i_Iscalling { get; set; }
        public Nullable<int> i_IsApprovedId { get; set; }
        public Nullable<int> i_IsDeleted { get; set; }
        public Nullable<int> i_InsertUserId { get; set; }
        public Nullable<System.DateTime> d_InsertDate { get; set; }
        public Nullable<int> i_UpdateUserId { get; set; }
        public Nullable<System.DateTime> d_UpdateDate { get; set; }
        public Nullable<int> i_ApprovedInsertUserId { get; set; }
        public Nullable<int> i_ApprovedUpdateUserId { get; set; }
        public Nullable<System.DateTime> d_ApprovedInsertDate { get; set; }
        public Nullable<System.DateTime> d_ApprovedUpdateDate { get; set; }
        public Nullable<int> i_InsertUserMedicalAnalystId { get; set; }
        public Nullable<int> i_UpdateUserMedicalAnalystId { get; set; }
        public Nullable<System.DateTime> d_InsertDateMedicalAnalyst { get; set; }
        public Nullable<System.DateTime> d_UpdateDateMedicalAnalyst { get; set; }
        public Nullable<int> i_InsertUserTechnicalDataRegisterId { get; set; }
        public Nullable<int> i_UpdateUserTechnicalDataRegisterId { get; set; }
        public Nullable<System.DateTime> d_InsertDateTechnicalDataRegister { get; set; }
        public Nullable<System.DateTime> d_UpdateDateTechnicalDataRegister { get; set; }
        public Nullable<int> i_Iscalling_1 { get; set; }
        public Nullable<int> i_AuditorInsertUserId { get; set; }
        public Nullable<System.DateTime> d_AuditorInsertUser { get; set; }
        public Nullable<int> i_AuditorUpdateUserId { get; set; }
        public Nullable<System.DateTime> d_AuditorUpdateUser { get; set; }
        public string v_IdUnidadProductiva { get; set; }
        public Nullable<decimal> d_SaldoPaciente { get; set; }
        public Nullable<decimal> d_SaldoAseguradora { get; set; }
        public Nullable<int> i_MedicoTratanteId { get; set; }
        public Nullable<int> i_SystemUserEspecialistaId { get; set; }
        public Nullable<int> i_ConCargoA { get; set; }
        public Nullable<int> i_TipoDesc { get; set; }
        public string v_ComentaryUpdate { get; set; }
        public Nullable<int> i_UserTypeId { get; set; }
        public Nullable<int> i_IsFact { get; set; }
        public string v_Area { get; set; }
        public string v_Cargo { get; set; }
        public Nullable<int> i_PayMedic { get; set; }
        public Nullable<int> i_ApplicantMedic { get; set; }
        public Nullable<decimal> i_Cantidad { get; set; }
        public Nullable<decimal> d_Descuento { get; set; }
    
        public virtual component component { get; set; }
        public virtual service service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicecomponentfields> servicecomponentfields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<servicecomponentmultimedia> servicecomponentmultimedia { get; set; }
    }
}