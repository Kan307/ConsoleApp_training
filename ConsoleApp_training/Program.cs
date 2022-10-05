// See https://aka.ms/new-console-template for more information

using ConsoleApp_training;
using System;
using System.Collections.Generic;   // Listを使うので必要
using System.Linq;  // LINQを使うために必要

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {
            //// コンソールに文字列を表示する
            //Console.WriteLine("Hello, C#");

            //// 変数の宣言
            //int money;      // 所持金を代入する変数
            //string name;    // 名前を代入する変数
            ////----------------------------------------------------

            //// 変数に値を代入する
            //money = 5000;
            //name = "きたむら";

            //Console.WriteLine(money);   // 所持金を表示
            //Console.WriteLine(name);    // 名前を表示
            ////----------------------------------------------------

            //int answer; // 計算結果

            //// 加算
            //answer = 3 + 4;
            //Console.WriteLine(answer);

            //// 減算
            //answer = 12 - 18;
            //Console.WriteLine(answer);

            //// 乗算
            //answer = 2 * 7;
            //Console.WriteLine(answer);

            //// 除算
            //answer = 18 / 3;
            //Console.WriteLine(answer);

            //// 剰余
            //answer = 21 % 5;
            //Console.WriteLine(answer);
            ////----------------------------------------------------

            //// 変数の初期化
            //int money = 15000;  // 現在の所持金
            //int salary = 1000;  // 時給
            //int hour = 5;       // 働いた時間

            //// 現在の所持金の合計を計算して表示
            //int sum = money + salary * hour;
            //Console.WriteLine(sum);
            ////----------------------------------------------------

            //int math = 80;      // 数学の点数
            //int english = 66;   // 英語の点数
            //int history = 95;   // 歴史の点数

            //// 平均値を計算して表示
            //float average = (math + english + history) / 3.0f;
            //Console.WriteLine("平均は" + average + "点");
            ////----------------------------------------------------

            //int life = 1;

            //// 「3」だけ増やす
            //life = life + 3;
            //Console.WriteLine(life);
            ////----------------------------------------------------

            //int life = 1;

            //// ライフを「1」だけ増やす
            //life++;
            //Console.WriteLine(life);
            ////----------------------------------------------------

            //int playerPosX = 5; // プレイヤの位置は「X=5」
            //int enemyPosX = 10; // 敵の位置は「X=10」

            //// プレイヤと敵の位置が等しい場合は敵と遭遇
            //if (playerPosX == enemyPosX)
            //{
            //    Console.WriteLine("敵と遭遇");
            //}
            ////----------------------------------------------------

            //int player1PosX = 2;    // プレイヤ1の位置
            //int player2PosX = 6;    // プレイヤ2の位置

            //// プレイヤ1の位置が「2」かつプレイヤ2の位置が「6」の場合に仕掛けを解除
            //if (player1PosX == 2)
            //{
            //    if (player2PosX == 6)
            //    {
            //        Console.WriteLine("仕掛け解除");
            //    }
            //}
            ////----------------------------------------------------

            //int player1PosX = 2;
            //int player2PosX = 6;

            //// プレイヤ1の位置が「2」かつプレイヤ2の位置が「6」の場合に仕掛けを解除
            //if (player1PosX == 2 && player2PosX == 6)
            //{
            //    Console.WriteLine("仕掛け解除");
            //}
            ////----------------------------------------------------

            //int playerPosY = 3;

            //// プレイヤが地上(高さ0以上の位置)にいる場合は走る
            //// そうでなければ水中にいるとみなして泳ぐ
            //if (playerPosY >= 0)
            //{
            //    Console.WriteLine("走る！");
            //}
            //else
            //{
            //    Console.WriteLine("泳ぐ！");
            //}
            ////----------------------------------------------------

            //int hp = 100;
            //int mapType = 2;

            //// 地形の種類によってHPの値を増減する
            //if (mapType == 1)    // 回復地形の場合
            //{
            //    hp += 10;
            //}
            //else if (mapType == 2)  // 毒地形の場合
            //{
            //    hp -= 5;
            //}
            //else if (mapType == 3) // 罠の場合
            //{
            //    hp = 0;
            //}
            //else  // 上記以外は全て通常の地形
            //{
            //    Console.WriteLine("HPの変化なし");
            //}

            //Console.WriteLine("HP=" + hp);
            ////----------------------------------------------------

            //// 参加者を点呼する
            //for (int i = 1; i < 4; i++)
            //{
            //    Console.WriteLine(i + "番！");
            //}
            ////----------------------------------------------------


            //int playerPosX = 5;
            //int missilePosX = 15;

            //// プレイヤの位置とミサイルの位置が等しくなければ
            //// ミサイルの移動を繰り返す
            //while (playerPosX != missilePosX)
            //{
            //    Console.WriteLine("missile at " + missilePosX);
            //    missilePosX--;  // ミサイルを左に動かす
            //}
            //Console.WriteLine("HIT");
            ////----------------------------------------------------

            //float[] weights;        // 配列用の変数を宣言する
            //weights = new float[7]; // 配列の要素数を決める

            //// 配列の要素に値を代入する
            //weights[0] = 41.2f;
            //weights[1] = 42.5f;
            //weights[2] = 44.9f;
            //weights[3] = 43.2f;
            //weights[4] = 45.1f;
            //weights[5] = 43.2f;
            //weights[6] = 42.7f;

            //// 配列の値を全て表示する
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            ////----------------------------------------------------

            //// 配列を初期化する
            //float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f,
            //                    43.2f, 42.7f, 41.5f, 41.4f, 41.9f };

            //// 「変数名.Length」を使って全要素にアクセスする
            //for (int i = 0; i < weights.Length; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            ////----------------------------------------------------

            //float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f,
            //                    45.1f, 43.2f, 42.7f };

            //float sum = 0.0f;   // 1週間の体重の合計を入れる変数

            //// 1週間の体重の合計値を求める
            //for (int i = 0; i < weights.Length; i++)
            //{
            //    sum += weights[i];
            //}

            //// 1週間の体重の平均値を求める
            //float average = sum / weights.Length;
            //Console.WriteLine("平均値は" + average + "です");
            ////----------------------------------------------------

            //int money = 2500;
            //Console.WriteLine("所持金は" + money + "円です");
            //int price = Shop("薬草");
            //money -= price;
            //Console.WriteLine("所持金は" + money + "円です");
            ////----------------------------------------------------

            //// player1のインスタンスを作り、名前と体力を代入
            //Player player1 = new Player();
            //player1.name = "たかし";
            //player1.hp = 100;

            //// player2のインスタンスを作り、名前と体力を代入
            //Player player2 = new Player();
            //player2.name = "ひろし";
            //player2.hp = 50;

            //player1.Attack();   // player1が攻撃する
            //player2.Defense();  // player2が防御する
            ////----------------------------------------------------

            //// player1のインスタンスを作る
            //Player player1 = new Player();

            //// player1の体力をコンソールに表示
            //Console.WriteLine(player1.name + "の体力は" + player1.hp);
            ////----------------------------------------------------

            Player player = new Player("ひろし", 100);
            // playerのHpプロパティに代入
            player.Hp -= 70;
            Console.WriteLine("HPは" + player.Hp);
            //----------------------------------------------------

            Kart[] karts = new Kart[2];

            // インスタンスを生成する
            karts[0] = new SkyKart();
            karts[1] = new TurboKart();

            // クラクションを鳴らす
            for (int i = 0; i < karts.Length; i++)
            {
                karts[i].Horn();
            }
            //----------------------------------------------------

            //// List型の変数を作る
            //List<float> weights = new List<float>();

            //// Listに要素を追加する
            //weights.Add(41.2f);
            //weights.Add(42.5f);
            //weights.Add(44.9f);
            //weights.Add(43.2f);
            //weights.Add(43.2f);
            //weights.Add(42.7f);
            //weights.Add(41.7f);

            //// Listの要素を全て表示する
            //for (int i = 0; i < weights.Count; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            ////----------------------------------------------------

            //// List型の変数を作る
            //List<float> weights = new List<float>();

            //// Listに要素を追加する
            //weights.Add(41.2f);
            //weights.Add(42.5f);
            //weights.Add(3.2f);
            //weights.Add(43.2f);
            //weights.Add(43.2f);
            //weights.Add(42.7f);
            //weights.Add(41.7f);

            //// リストの先頭から3番目の要素を削除する
            //weights.RemoveAt(2);

            //// Listの要素を全て表示する
            //for (int i = 0; i < weights.Count; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            //----------------------------------------------------

            // List型の変数を作る
            //List<float> weights = new List<float>();

            //// Listに要素を追加する
            //weights.Add(41.2f);
            //weights.Add(42.5f);
            //weights.Add(44.9f);
            //weights.Add(43.2f);
            //weights.Add(43.2f);
            //weights.Add(42.7f);
            //weights.Add(41.7f);

            //// 体重を小さい順に並べ替える
            //weights.Sort();

            //// Listの先頭から3つの要素を表示する
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(weights[i]);
            //}
            //----------------------------------------------------

            // Dictionary型の変数を作る
            Dictionary<string, float> weights =
                new Dictionary<string, float>();

            // 日付と体重がペアになった要素を追加する
            weights.Add("2016/12/10", 41.2f);
            weights.Add("2016/12/11", 42.5f);
            weights.Add("2016/12/12", 44.9f);
            weights.Add("2016/12/13", 43.2f);
            weights.Add("2016/12/14", 43.2f);
            weights.Add("2016/12/15", 42.7f);
            weights.Add("2016/12/16", 41.7f);

            // 2016/12/13の体重を表示する
            Console.WriteLine(weights["2016/12/13"]);
            //----------------------------------------------------

            //int[] hp = { 420, 120, 600, 0, 1200 };
            //List<int> newHP = new List<int>();

            //for (int i = 0; i < hp.Length; i++)
            //{
            //    // HPが500以上の場合、新しいリストに追加する
            //    if (hp[i] >= 500)
            //    {
            //        newHP.Add(hp[i]);
            //    }
            //}

            //// newHPの要素を表示する
            //foreach (int n in newHP)
            //{
            //    Console.WriteLine(n);
            //}
            //----------------------------------------------------

            //int[] hp = { 420, 120, 600, 0, 1200 };

            //// LINQを使って、HPが500以上の要素を取り出す
            //var newHP = hp.Where(n => n >= 500);

            //// newHPの要素を表示する
            //foreach (int n in newHP)
            //{
            //    Console.WriteLine(n);
            //}
            //----------------------------------------------------

            //int[] hp = { 550, 420, 600, 800, 220 };
            //List<int> newHP = new List<int>();

            //// hp配列の要素から100を引いた値を新しいリストに追加
            //for (int i = 0; i < hp.Length; i++)
            //{
            //    newHP.Add(hp[i] - 100);
            //}

            //// newHPの要素を表示する
            //foreach (int n in newHP)
            //{
            //    Console.WriteLine(n);
            //}
            //----------------------------------------------------

            //int[] hp = { 550, 420, 600, 800, 220 };

            //// LINQを使って、すべての要素の値を100減らす
            //var newHP = hp.Select(n => n - 100);

            //// newHPの要素を表示する
            //foreach (int n in newHP)
            //{
            //    Console.WriteLine(n);
            //}
            //----------------------------------------------------

            int[] hp = { 550, 0, 600, 0, 220 };
            int num = 0;    // HPが「0」の個体の数をカウントする変数

            for (int i = 0; i < hp.Length; i++)
            {
                // HPが「0」であればnumを「1」増やす
                if (hp[i] == 0)
                {
                    num++;
                }
            }
            Console.WriteLine(num);
            //----------------------------------------------------

            int num1 = 35;
            int num2 = num1;    // num1にnum2の値をコピー
            Console.WriteLine(num2);
            num1 = 0;   // num1に「0」を代入
            Console.WriteLine(num2);
            //----------------------------------------------------

            Player player1 = new Player("たかし", 35);
            Player player2 = new Player("ひろし", 100);

            player2 = player1;  // player2にplayer1をコピーする
            Console.WriteLine(player2.Hp);
            player1.Hp = 0;     // player1の体力を「0」にする
            Console.WriteLine(player2.Hp);
            //----------------------------------------------------


            // 商品名を引数に取り、
            // 対応する商品の値段を返すメソッド
            static int Shop(string itemName)
            {
                Console.WriteLine("いらっしゃいませ！");
                int price = 0;

                if (itemName == "薬草")
                {
                    Console.WriteLine(itemName + "は100円です");
                    price = 100;
                }
                else if (itemName == "棍棒")
                {
                    Console.WriteLine(itemName + "は1500円です");
                    price = 1500;
                }
                else
                {
                    Console.WriteLine("売り切れです");
                    price = 0;
                }

                // 引数に対応する商品の値段を返す
                return price;
            }

        }
    }
}