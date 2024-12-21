using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Programming
{
    public class EventBasedPublisher
    {
        // bir olayın durumun ya da aksyionun meydana geldiğini takip etmek  ve buna karşın bir tepki vermek amacıyla kullanılan bir özelliktir.
        public delegate void EventBasedHandlerX(); // burada geri değer dönen de olabilir dönmeyen de olabilir.imzası önemli değil.
        EventBasedHandlerX eventBasedHandlerX;
        public event EventBasedHandlerX MyEventBased
        {
            // bu bloklar tanımlanlmadıkları takdirde arka planda çalışır
            add
            {
                Console.WriteLine("Event Abone olundu");
                eventBasedHandlerX += value;

            }
            remove
            {
                Console.WriteLine("Event Abone kaldırıldı");
                eventBasedHandlerX -= value;

            }
        }

        public void RaiseEvent()
        {
            // event fırlatıldı
           // MyEventBased(); // event çağrıldı.
           eventBasedHandlerX?.Invoke(); // event çağrıldı.

          
        }

        // event eğer çağırılsa olay içerisinde onun temsil ettiği uygun delegate çalışır.

        // delegateler public olarak işaretlense de başka bir sınıftan erişilemez. sadece event üzerinden erişilebilir.
       
    }
        //*******************************************************************
        // belirli bir dizinde boyutu 5mb geçince uyaran bir event oluşuralım.  

    class PathControl
    {
        public delegate void PathHandler(float sizeMb);
        public  event PathHandler PathControlEvent;

        public async Task Control(string path)
        {
            while(true)
            {
                await Task.Delay(1000);
                DirectoryInfo directoryInfo = new(path);
                var files = directoryInfo.GetFiles();
                float ByteSize = await Task.Run(() => directoryInfo.EnumerateFiles("*", SearchOption.AllDirectories).Sum(file => file.Length));
                float MbSize = (ByteSize / 1024) / 1024;

                if(MbSize > 20)
                    PathControlEvent(MbSize);
                

            }
        }


    }







}
