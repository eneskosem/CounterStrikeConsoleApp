using ConsoleApp.Entities;
using ConsoleApp.Enums;
using System;

namespace cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nSilah seçin:");
                Console.WriteLine("1. Bıçak");
                Console.WriteLine("2. Roketatar");
                Console.WriteLine("3. Tabanca");
                Console.WriteLine("4. Pompali Tüfek");
                Console.WriteLine("5. Otomatik Tüfek");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();

                Weapon weapon = null;
                switch (choice)
                {
                    case "1":
                        weapon = new Knife();
                        break;
                    case "2":
                        weapon = new RocketLauncher();
                        break;
                    case "3":
                        weapon = new Pistol();
                        break;
                    case "4":
                        weapon = new Rifle(TüfekTipi.Pompali);
                        break;
                    case "5":
                        weapon = new Rifle(TüfekTipi.Otomatik);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        continue;
                }

                TestWeapon(weapon);
            }
        }

        static void TestWeapon(Weapon weapon)
        {
            while (true)
            {
                Console.WriteLine($"\n{weapon.GetType().Name} test ediliyor");
                Console.WriteLine($"Marka: {weapon.Brand}");
                Console.WriteLine($"Model: {weapon.Model}");
                Console.WriteLine($"Menzil: {weapon.MenzilTipi}");
                Console.WriteLine($"Ağırlık: {weapon.Weight}kg");

                if (weapon is Firearm firearm)
                {
                    Console.WriteLine($"Mermi Tipi: {firearm.MermiTipi}");
                    Console.WriteLine($"Mevcut Mermi: {firearm.MevcutMermi}/{firearm.SarjorKapasitesi}");
                    Console.WriteLine($"Kalibre: {firearm.Kalibre}");
                }

                Console.WriteLine("\nEylemler:");
                Console.WriteLine("1. Saldır");
                Console.WriteLine("2. Yeniden Doldur");
                if (weapon is Firearm f && f.ZoomYapabilir)
                {
                    Console.WriteLine("3. Yakınlastırmayı Değiştir");
                }
                Console.WriteLine("4. Silah seçimine geri dön");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        weapon.Attack();
                        break;
                    case "2":
                        weapon.Reload();
                        break;
                    case "3":
                        if (weapon is Firearm atesliSilah3 && atesliSilah3.ZoomYapabilir)
                        {
                            atesliSilah3.YakınlastırmayıDeğiştir();
                        }
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }
            }
        }
    }
}
