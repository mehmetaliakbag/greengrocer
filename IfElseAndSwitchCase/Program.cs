// Kullanıcıya mevcut ürünleri listeleyip bir seçim yapmasını isteyeceğiz.

Console.WriteLine("Rüya Manavına Hoşgeldiniz:" +
                 "\nElma = 2 TL" +
                 "\nArmut = 3 TL" +
                 "\nÇilek = 2 TL" +
                 "\nMuz = 3 TL" +
                 "\nDiğer tüm meyveler = 4 TL");

Console.Write("\nHangi meyveyi satın almak istersiniz?" +
                  "(Elma\\Armut\\Çilek\\Muz\\Diğer: ");

string fruit = Console.ReadLine();

int price;

fruit = fruit.ToLower();



#region Solution 1 
  
// Tercih ettiği meyvenin fiyatını değişkene atıyacağız 
  
if (fruit == "elma")
{
    price = 2;
}
else if (fruit == "armut")
{
    price = 3;
}
else if (fruit == "çilek")
{
    price = 2;
}
else if (fruit == "muz")
{
    price = 3;
}
else
{
    price = 4;
}

// Alışveriş tutarını konsol ekranına yazdıracağız.

Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {price} TL");


#endregion 

#region Solution 2


// Tercih ettiği meyvenin fiyatını değişkene atıyacağız 

switch (fruit)
{
    case "elma":
        price = 2;
        break;

    case "armut":
        price = 3;
        break;

    case "çilek":
        price = 2;
        break;

    case "muz":
        price = 3;
        break;

    default:
        price = 4;
        break;
}

// Alışveriş tutarını konsol ekranına yazdıracağız.

Console.WriteLine($"Seçtiğiniz meyvenin fiyatı {price} TL");


#endregion

/*
 * Tercih edilecek durum sayısı fazla olduğu için bu tip durumlarda birden fazla if else
 * kullanımına yol açacaktır. Bu durum da hem kodun okunması hem de ortaya çıkan karmaşıklıktan
 * hataya meyil artacaktır.
 * 
 * Bu gibi durumlarda SwitchCase kullanımı daha doğrudur. Hem kodun daha düzenli görünmesi
 * Hem de birden fazla durumu kontrol etmekte daha basittir
 */
