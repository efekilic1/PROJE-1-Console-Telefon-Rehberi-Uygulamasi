using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTelephoneDirectory
{
    public class directory
    {
        List<contactCard> contactCard = new List<contactCard>();

        public directory()
        {
            contactCard.Add(new contactCard("Ali", "demir", "1234"));
            contactCard.Add(new contactCard("Emre", "göksu", "5678"));
            contactCard.Add(new contactCard("Mehmet", "öner", "9123"));
            contactCard.Add(new contactCard("Selim", "aslan", "4567"));
            contactCard.Add(new contactCard("Fethi", "budak", "8910"));

        }

        public void addNumber()
        {
            contactCard member = new();
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("Lütfen isim giriniz              : ");
            member.name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz           :");
            member.surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz  :");
            member.number = Console.ReadLine();

            contactCard.Add(member);
            Console.WriteLine("Yeni kişi eklendi    :");
            Console.WriteLine("İsim : {0}", member.name);
            Console.WriteLine("Soyisim : {0}", member.surname);
            Console.WriteLine("Telefon Numarası : {0}",member.number);
        }

        public void deleteNumber()
        {
            again:
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string nameOrSurname = Console.ReadLine();

            int cnt = 0;
            foreach (var card in contactCard)
            {
                if(nameOrSurname.ToLower() == card.name.ToLower() || nameOrSurname.ToLower() == card.surname.ToLower())
                {
                    cnt++;
                    Console.WriteLine("Bu kişiyi silmek istediğinizden emin misiniz  İsim : "+ card.name + ", Soyisim: "+card.surname+", Numara: "+ card.number + " (y/n) ");
                    if(Console.ReadLine() == "y")
                    {
                        contactCard.RemoveAt(contactCard.IndexOf(card));
                        Console.WriteLine("Silindi");
                        break;
                    }

                }



            }
            if (cnt == 0)
            {
                Console.WriteLine("Böyle bir kişi yok");
                flag:
                Console.WriteLine("Silmeyi sonlandırmak için: (1)");
                Console.WriteLine("Yeniden denemek için: (2)");
                int num = int.Parse(Console.ReadLine());

                if(num == 2)
                {
                    goto again;
                }else if(num==1){

                }
                else
                {
                    Console.WriteLine("Lütfen 1 veya 2 tuşlayınız");
                    goto flag;
                }

            }



        }

        public void update()
        {
            again:
            Console.WriteLine("Lütfen bilgilerini güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string nameOrSurname = Console.ReadLine();

            int cnt = 0;
            foreach (var card in contactCard)
            {
                if (nameOrSurname.ToLower() == card.name.ToLower() || nameOrSurname.ToLower() == card.surname.ToLower())
                {
                    cnt++;
                    Console.WriteLine("Lütfen yeni ismi giriniz");
                    card.name = Console.ReadLine();
                    Console.WriteLine("Lütfen yeni soyismi giriniz");
                    card.surname = Console.ReadLine();
                    Console.WriteLine("Lütfen yeni numarayı giriniz");
                    card.number = Console.ReadLine();

                    Console.WriteLine("Başarıyla güncellendi İsim: " + card.name + ", Soyisim: " + card.surname + ", Numara: " + card.number);
                    break;

                }



            }
            if  (cnt == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                flag:
                Console.WriteLine("Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("Yeniden denemek için              : (2)");
             
                int num = int.Parse(Console.ReadLine());

                if (num == 2)
                {
                    goto again;
                }
                else if (num == 1)
                {

                }
                else
                {
                    Console.WriteLine("Lütfen 1 veya 2 tuşlayınız");
                    goto flag;
                }



            }





        }



        public void SortDictionary()
        {
            start:
            int flag = 0; 
            Console.WriteLine("A'dan Z'ye sıralama için 1'e, Z'den A'ya sıralama için 2'ye basınız.");
            flag = int.Parse(Console.ReadLine());
            
            if (flag == 1)
            {
                contactCard.Sort((m1, m2) =>
                {
                    return m1.name.CompareTo(m2.name);
                });

            }else if(flag == 2)
            {
                contactCard.Sort((m1, m2) =>
                {
                    return m2.name.CompareTo(m1.name);
                });
            }
            else
            {
                Console.WriteLine("Lütfen 1 veya 2'ye basınız");
                goto start;
            }




            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************");
            Console.WriteLine("Rehberde Toplam {0} kişi bulunmaktadır..", contactCard.Count);
            foreach (var card in contactCard)
            {
                Console.WriteLine("İsim: {0}", card.name);
                Console.WriteLine("Soyisim: {0}", card.surname);
                Console.WriteLine("Numara: {0}", card.number);
                Console.WriteLine("------------");
            }


        }



        public void FindDictionary()
        {
            again:
            Console.WriteLine("Bulmak istediğiniz kişinin ismini yazınız: ");
            string name = Console.ReadLine();
            int flag = 0;

            foreach(var card in contactCard)
            {
                if(card.name.ToLower() == name.ToLower())
                {
                    flag = 1;
                    Console.WriteLine("İsim: " + card.name + " Soyisim: " + card.surname + " Numara: " + card.number);
                    
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("{0} isimli bir kayıt bulunamadı.", name);
                Console.WriteLine("Tekrar denemek için 1'e basınız.");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    goto again;
                }
                



            }

        }



    }
}
