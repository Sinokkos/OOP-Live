namespace P01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Personel Bilgileri
            //Console.WriteLine("Personel Bilgileri");
            //Console.WriteLine("------------------");

            //// Hazırlanmış olan sınıftan yararlanabilmem için o sınıftan bir nesne (object) yaratıyorum.

            //Personel sinem = new Personel(); // nesne oluşturuluyor.
            //Personel umit = new Personel();



            ////per1.PersonelID = 1;
            ////per1.Ad = "Sinem";
            ////per1.Soyad="Taşpınar";
            ////per1.Maas = 10500;

            //// maaş bilgisi random hesaplansın
            //int maasilk = 9000;
            //int maasson = 20000;

            //sinem.setPersonelBilgileri("Sinem", "Taşpınar", new Random().Next (maasilk,maasson));
            //umit.setPersonelBilgileri("Ümit", "Karaçivi", new Random().Next(maasilk, maasson));

            //Console.WriteLine(sinem.getPersonelBilgileri());
            //Console.WriteLine(umit.getPersonelBilgileri());
            #endregion

            #region CustomerManager, ProductManager

            //customerManager customerManager = new CustomerManager.Add();

            //productManager productManager = new ProductManager.Add();

            #endregion

            #region Farklı class/nesne kullanım şekilleri
            // 1. 
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Sinem";
            customer.LastName = "Taşpınar";
            customer.City = "İstanbul";

            Console.WriteLine($"Müşteri Adı : {customer.FirstName}");

            // 2.
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Sinem",
                LastName = "Taşpınar",
                City = "İstanbul"
            };

            Console.WriteLine($"Müşteri Adı : {customer1.FirstName}");
            #endregion

            Console.ReadKey();
        }
    }
}
