using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Weapon
{
    public class Weapon
    {
        public int Tutum;
        public int Say;
        public string Mod;


        public Weapon(int tutum,int say,string mod )
        {
            Tutum = tutum;
            Say = say;  

            Mod = mod;
        }
        public void Shoot()
        {
            if( Say == 0 )
            {
                Console.WriteLine("daraqda gulle yoxdur");
                return;
            }
            if (Mod.ToLower() == "tekli")
            {
                Console.WriteLine("ates edildi");
                Say--;
                Console.WriteLine("GULLE SAYI  "+Say);
                

            }
            else if(Mod.ToLower() == "avtomatik")
            {
                Console.WriteLine("ates edilir");
                while ( Say > 0 )
                {
                    Say--;
                    
                }
                Console.WriteLine("daraqda gulle bitdi "+Say);
            }
        }
        public void Changefiremod()
        {
            if (Mod.ToLower() == "tekli")
            {
                Mod = "avtomatik";
               
                Console.WriteLine("atis modu avtomatik olaraq deyisdirildi");
            }
            else if(Mod.ToLower()=="avtomatik"
            Mod = "tekli";
            Console.WriteLine("mod tekli olraraq deyisdirildi");
            
        }
        public void  Getremainbullet()
        {
            Console.WriteLine("daragin dolmasi cucun lazim olan gulle sayi:  "+(Tutum- Say));
            

        }
        public void Reload()
        {
            if (Say < Tutum)
            {
                int a;
                a= Tutum - Say;
                Say += a;
                Console.WriteLine("daraq tam dolduruldu ,daraqdaki gulle sayi  "+Tutum);
            }
            else { Console.WriteLine("daraq tam doludu"); }
        }
        public void tutumdeyis()
        {
            Tutum = Tutum + 10;
            Console.WriteLine("Silahinizin yeni tutumu "+Tutum);
        }
        public void sayideyis()
        {
            Say++;
            Console.WriteLine("gulle sayi deyisdirilerek 1 vahid artirildi  "+Say);
        }




    }
}
