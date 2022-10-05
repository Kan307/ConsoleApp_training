using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_training
{
    // Kartクラスを継承してSkyKartクラスを作る
    class SkyKart : Kart
    {
        // 離陸するメソッドのみ追加
        public void Flying()
        {
            Console.WriteLine("離陸！");
        }

        // Hornメソッドをオーバーライドする
        public override void Horn()
        {
            Console.WriteLine("ピピーッ");
        }
    }
}
