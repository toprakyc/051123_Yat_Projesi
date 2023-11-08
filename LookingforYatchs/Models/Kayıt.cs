namespace LookingforYatchs.Models
{
    public class Kayıt
    {
        public String? Ad { get; set; }
        public String? Soyad { get; set; }
        public int Yas { get; set; }
        public DateTime KayıtTarihi { get; set; }

        public Kayıt()
        {
                KayıtTarihi= DateTime.Now;
        }
    }
}
