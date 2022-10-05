using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_training
{
    class Player
    {
        // privateなメンバ変数を宣言
        private string name;
        private int hp;

        // 以下、publicなコンストラクタとメンバメソッドを定義
        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        // Hpプロパティ
        public int Hp
        {
            set
            {
                this.hp = value;
                if (this.hp < 0)
                {
                    this.hp = 0;
                }
            }
            get
            {
                return this.hp;
            }
        }

        public void Attack()
        {
            Console.WriteLine(this.name + "は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
