using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Slider :IEntity
    {
        public int Id { get; set; }
        [StringLength(150),Display(Name ="Başlık")]
        public string? Baslık { get; set; }
        [StringLength(500), Display(Name = "Açıklama")]
        public string? Acıklama { get; set; }
        [StringLength(100)]
        public string? Resim { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }

    }
}
