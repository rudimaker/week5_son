
using week5_son;

List<Car> Araba = new List<Car>();


GelSor:
bool deger = true;

while (deger)
{
    Console.WriteLine("Araba nesnesi üretilsin mi? ( e/h )");
    string cevap = Console.ReadLine().ToLower().Trim();

    if (cevap == "e")
{
    Console.WriteLine("Araba nesnesi oluşturuluyor");
        Car car1 = new Car();

        Console.WriteLine("Arabanın seri no giriniz");
        car1.SerialNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Arabanın markasını giriniz");
        car1.Brand = Console.ReadLine();

        Console.WriteLine("Arabanın modelini giriniz");
        car1.Model = Console.ReadLine();

        Console.WriteLine("Arabanın rengini giriniz");
        car1.Color = Console.ReadLine();

        


    DoorControl:
        try
        {
            Console.WriteLine("Arabanın kapı sayısını giriniz");

            string input = Console.ReadLine();

            car1.DoorCount = int.Parse(input);
            
        }

        catch(Exception ex)
        {
            Console.WriteLine("2 veya 4 rakamından farklı bir değer girdiniz");
            goto DoorControl;
        }



        Araba.Add(car1);

        Console.WriteLine(""+car1.SerialNumber);
        Console.WriteLine("" + car1.Brand);
        Console.WriteLine("" + car1.Model);
        Console.WriteLine("" + car1.Color);
        Console.WriteLine("" + car1.DoorCount);

        Console.WriteLine("Program sonlansın mı? e/h");
        string cevap2 = Console.ReadLine();
        if (cevap2 == "h")
        {
            goto GelSor;
        }
        else
        {
            foreach (var Car in Araba)
            {
                Console.WriteLine($"Seri Numarası: {Car.SerialNumber}, Marka: {Car.Brand}, Model : {Car.Model}, Renk : {Car.Color}, Oluşturulma tarihi {Car.ProductionDate}");
            }
        }

        break;
}

else if (cevap == "h")
{
    Console.WriteLine("Kullanıcı isteği üzerine nesne üretilmeden program sonlandırıldı.");
   break;
}

else
{
    Console.WriteLine("Yanlış bir değer girildi. Tekrar değer giriniz");

    }

   


}