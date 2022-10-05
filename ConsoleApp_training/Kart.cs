using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_training
{
    class Kart
    {
        public int weight;  // 重量
        public int speed;   // 速度

        // アクセルを踏むメソッド
        public void Force()
        {
            Console.WriteLine("加速or減速");    // 減速機能を追加
        }

        // クラクションを鳴らす
        public virtual void Horn()
        {
            Console.WriteLine("ブッブー");
        }
    }
}
