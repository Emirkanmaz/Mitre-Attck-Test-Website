//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mitredeneme.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class TBL_kisi
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [DisplayName("�sim:")]
        public string isim { get; set; }
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [DisplayName("Kullan�c� Ad�:")]
        public string kullaniciAdi { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Bu Alan Zorunludur.")]
        [DisplayName("E-mail:")]
        public string email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Bu Alan Zorunludur.")]
        [DisplayName("�ifre:")]
        public string sifre { get; set; }
        [DataType(DataType.Password)]
        [DisplayName("�ifre Onayla")]
        [Compare("sifre")]
        public string confirmPassword { get; set; }

        public string LoginErrorMessage { get; set; }


    }
}
