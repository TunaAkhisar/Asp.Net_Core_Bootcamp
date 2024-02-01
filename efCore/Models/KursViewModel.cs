using System.ComponentModel.DataAnnotations;

namespace efCore.Models
{
    public class Kurs{
        [Key]
        public int KursId {get;set;}
        public string? Baslik {get;set;}
        public int? OgretmenId {get;set;}
    }
}