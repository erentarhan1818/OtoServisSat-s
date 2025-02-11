﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Arac: IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]

        public int MarkaId{ get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Renk{ get; set; }
        [Display(Name = "Fiyatı")]
        public decimal Fiyati { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Modeli { get; set; }
        [StringLength(50)]
        [Display(Name = "Kasa Tipi")]
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı")]
        public int ModelYili{ get; set; }
        [Display(Name = "Satışta Mı?")]
        public bool SatistaMi { get; set; }
        [Display(Name = "AnaSayfa?")]
        public bool AnaSayfa { get; set; }
       
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }
        [StringLength(100)]
        public string? Resim1 { get; set; }
        [StringLength(100)]
        public string? Resim2 { get; set; }
        [StringLength(100)]
        public string? Resim3 { get; set; }
        [StringLength(100)]
        public string? Resim4 { get; set; }
        [StringLength(100)]
        public string? Resim5 { get; set; }
        [StringLength(100)]
        public string? Resim6 { get; set; }
        [StringLength(100)]
        public string? Resim7 { get; set; }
        [StringLength(100)]
        public string? Resim8 { get; set; }
        [StringLength(100)]
        

        public virtual Marka? Marka { get; set; }



    }
}
