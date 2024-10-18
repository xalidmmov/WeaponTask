namespace Weapon
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Weapon weapon=new Weapon(30,10,"tekli");

            bool cixis=false;
            bool logout =false;
            
            do
            {
                Console.WriteLine("emeliyyat sec ");
                Console.WriteLine("1: Ates acmaq ucun");
                Console.WriteLine("2: Daraga lazim olan gulle sayi");
                Console.WriteLine("3: Daragi yenilemek ucun");
                Console.WriteLine("4: Ates modunu deyismek ucun");
                Console.WriteLine("5: Proqrami dayandir");
                Console.WriteLine("6: Yeni menyuya kec");
                string secim=Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        weapon.Shoot();
                        break;  

                    case "2":
                        weapon.Getremainbullet();
                        break;
                    case "3":
                        weapon.Changefiremod();
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                      case "5":
                        Console.WriteLine("emeliyyatdan cixis edildi");
                        return;
                    case "6":
                        
                        
                        do
                        {
                            Console.WriteLine("YENI MENYU ACILDI 7:Tutumu deyismek ucun sec,   8:gulle sayini deyismek ucun sec,    9 geri menyuya qayit");
                            int cixisetmek;

                           logout = int.TryParse(Console.ReadLine(),out cixisetmek);
                           
                            switch(cixisetmek)
                            {
                                case 7:
                                    weapon.tutumdeyis();
                                    break;
                                case 8:
                                    weapon.sayideyis();
                                    break;
                                case 9:
                                    Console.WriteLine("menyudan cixis edildi");
                                    cixis = true;
                                    break;
                            }

                        }
                        while (!cixis);

                        break;
                   
                    case "0":
                        Console.WriteLine($"tutum: {weapon.Tutum}  say:  {weapon.Say}  mod{weapon.Mod}");
                        break;
                     default:
                        Console.WriteLine("DUZGUN SECIM ETMEMISIZ");
                        break;

                }
            }
            while(true);


        }
    }
}
