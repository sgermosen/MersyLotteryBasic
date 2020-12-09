namespace Mersy.Common.Entities
{
    using Helpers;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Acadey Entity TODO: 
    /// </summary>
    /// 
    public class Owner : BaseEntity, IBaseEntity
    {//Todo: change this to Tenant - Tenancy
        public string Rnc { get; set; }

        public string Code { get; set; }

        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Url)]
        public string WebAddress { get; set; }

        public string Address { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Imagen { get; set; }

        public string Tel { get; set; }

        public string PrefixExp { get; set; }

        public string PrefixFact { get; set; }

        
        public DateTime? StartDate { get; set; }

        public string PrefixNcf { get; set; }

        public int? SeqNcf { get; set; }

        public string PrefixFinalFact { get; set; }

        public string NcfEnds { get; set; }

        public int? SeqFact { get; set; }

        public string Header1 { get; set; }

        public string Header2 { get; set; }

        public string Header3 { get; set; }

        public string Footer1 { get; set; }

        public string Footer2 { get; set; }

        public string Footer3 { get; set; }

        public int UsersAvailable { get; set; }

        public int MegabytesAvailable { get; set; }

        public int RegitersAvailable { get; set; }

        public DateTime? PlanActiveUntil { get; set; }

        public long? OwnerTypeId { get; set; }
        public OwnerType OwnerType { get; set; }

        public ICollection<OwnerPlan> OwnerPlans { get; set; }

        public int SeqNcfGub { get; set; }

        public string PrefixNcfGub { get; set; }

        public bool IsActive { get; set; }
        public bool UserNameInReport { get; set; }

        public string FullName
        {
            get {
                return $"{Name} {LastName}";
            }
        }

        public string ImageFullPath => string.IsNullOrEmpty(Imagen)
           ? $"{StaticsValues.PathUrl}/images/noimage.png"
           : $"{StaticsValues.PathUrl}{Imagen.Substring(1)}";

        public Owner()
        {
            OwnerPlans = new Collection<OwnerPlan>();
        }

    }
}
