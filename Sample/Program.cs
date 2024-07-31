/* コンソールに文字列を表示する
Console.WriteLine("Hello, C#");
Console.WriteLine("Goodbye, C#"); */

/* 変数の宣言
int money; // 所持金を代入する変数
string name; // 名前を代入する変数

// 変数に値を代入する
money = 5000;
name = "きたむら";

Console.WriteLine(money);
Console.WriteLine(name);

int answer;

// 加算
answer = 3 + 4;
Console.WriteLine(answer);

// 減算
answer = 12 - 18;
Console.WriteLine(answer);

// 乗算
answer = 2 * 7;
Console.WriteLine(answer);

// 除算
answer = 18 / 3;
Console.WriteLine(answer);

//剰余
answer = 21 % 5;
Console.WriteLine(answer);

// 練習問題 3-1
int answer2;
answer2 = 1 + 2 + 3 + 4 + 5;
Console.WriteLine(answer2);

// 練習問題 3-2
int answer3;
answer3 = 30 % 7;
Console.WriteLine(answer3); */

/* 変数の初期化
int money = 15000; // 現在の所持金
int salary = 1000; // 時給
int hour = 5; // 働いた時間

// 現在の所持金の合計を計算して表示
int sum = money + salary * hour;
Console.WriteLine(sum);

// 練習問題 3-3
int sum2 = money + (salary + 150) * hour;
Console.Write(sum2);

// 練習問題 3-4
int money = 5000;
int salary = 800;
int hour = 2;

int sum = money + salary * hour;
Console.WriteLine(sum); */

/* 平均値を求める
int math = 80; // 数学の点数
int english = 66; // 英語の点数
int history = 95; // 歴史の点数

// 平均値を計算して表示
float average = (math + english + history) / 3.0f;
Console.WriteLine("平均は" + average + "点"); */

/* int a = 45;
int b = 30;

float average = a * 1.0f / b;
Console.WriteLine(average); */

/* int life = 1;

// ライフを「3」だけ増やす
//life = life + 3;
//life += 3;

// ライフを「1」だけ増やす
life++;

Console.WriteLine(life); */

/* 練習問題 3-6
int a = 10;
a--;
a--;

a /= 4;

Console.WriteLine(a); */

/* int playerPosX = 10;
int enemyPosX = 10;

// プレイヤーと敵の位置が等しい場合は敵と遭遇
if (playerPosX == enemyPosX)
{
    Console.WriteLine("敵と遭遇");
} */

// 練習問題 3-7
/* int num = 8;

if (num >= 3)
{
    Console.WriteLine("勝ち");
} */
/* int player1PosX = 1; // プレイヤ1の位置
int player2PosX = 6; // プレイヤ2の位置

// プレイヤ1の位置が「2」かつプレイヤ2の位置が「6」の場合に仕掛けを解除
 if (player1PosX == 2)
{
    if (player2PosX == 6)
    {
        Console.WriteLine("仕掛け解除");
    }
}

if (player1PosX == 2 && player2PosX == 6)
{
    Console.WriteLine("仕掛け解除");
} */

/* 練習問題 3-8
int player1PosX = 6;
int player2PosX = 2;
/* if (player1PosX == 2 || player2PosX == 6)
{
    Console.WriteLine("仕掛け解除");
}

// 練習問題 3-9
 if (player1PosX == 2 || player2PosX == 2)
{
    if (player1PosX == 6 || player2PosX == 6)
    {
        Console.WriteLine("仕掛け解除");
    }
}

 回答例
if ((player1PosX == 2 && player2PosX == 6) || (player1PosX == 6 && player2PosX == 2))
{
    Console.WriteLine("仕掛け解除");
} */

/* int playerPosY = -5;

// プレイヤが地上(高さ0以上の位置)にいる場合は走る
// そうでなければ水中にいるとみなして泳ぐ
if (playerPosY >= 0)
{
    Console.WriteLine("走る！");
}
else
{
    Console.WriteLine("泳ぐ！");
} */

/* 練習問題 3-10
int num = 5;
if (num >= 3)
{
    Console.WriteLine("勝ち");
}
else
{
    Console.WriteLine("負け");
} */

/* int hp = 100;
int mapType = 4;

// 地形の種類によってHPの値を増減する
if (mapType == 1)
{
    hp += 10;
}
else if (mapType == 2)
{
    hp -= 5;
}
else if (mapType == 3)
{
    hp = 0;
}
else
{
    Console.WriteLine("HPの変化なし");
}

Console.WriteLine("HP = " + hp); */

/* 攻撃を5回繰り返す
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("攻撃");
} */

/* 練習問題 3-11
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("逃走！");
} */

/* 参加者を点呼する
for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i + "番！");
} */

/* 練習問題 3-13
for (int i = 2; i < 6; i++)
{
    Console.WriteLine(i);
} */

/* 練習問題 3-14
for (int i = 0; i < 5; i += 2)
{
    Console.WriteLine(i);
} */

/* 「3」から「1」までカウントダウンする
for (int i = 3; i > 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("スタート"); */

/* 練習問題 3-15
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
} */

/* int playerPosX = 5;
int missilePosX = 15;

 プレイヤの位置とミサイルの位置が等しくなければミサイルの移動を繰り返す
while (playerPosX != missilePosX)
{
    Console.WriteLine("missile at " + missilePosX);
    missilePosX--; // ミサイルを左に動かす
}

Console.WriteLine("HIT"); */

/* 練習問題 3-16
int i = 10000;
int count = 0;

while (i > 100)
{
    i /= 2;
    count++;
}
Console.WriteLine(count); */

/* int playerPosX = 5;
int missilePosX = 15;

// 常にループする
while (true)
{
    // プレイヤとミサイルが衝突したらwhile文を抜ける
    if (playerPosX == missilePosX)
    {
        break;
    }

    Console.WriteLine("missile at " + missilePosX);
    missilePosX--;
}
Console.WriteLine("HIT"); */

/* 練習問題 3-17
int sum = 0;
int count = 1;
while (true)
{
    sum += count;
    Console.WriteLine(sum);

    if (sum >= 500)
    {
        break;
    }    
    count++;
} */

/* float[] weights; // 配列用の変数を宣言する
weights = new float[7]; // 配列の要素数を決める

// 配列の要素に値を代入する
weights[0] = 41.2f;
weights[1] = 42.5f;
weights[2] = 44.9f;
weights[3] = 43.2f;
weights[4] = 45.1f;
weights[5] = 43.2f;
weights[6] = 42.7f;

// 配列の値をすべて表示する
for (int i = 0; i < 7; i++)
{
    Console.WriteLine(weights[i]);
} */

/* 配列を初期化する
float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f, 41.5f, 41.4f, 41.9f };

// 「変数名.Length」を使って全要素にアクセスする
for (int i = 0; i < weights.Length; i++)
{
    Console.WriteLine(weights[i]);
} */

/* float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 
    45.1f, 43.2f, 42.7f };

 float sum = 0.0f; // 1週間の体重の合計を入れる変数

// 1週間の体重の合計値を求める
for (int i = 0; i < weights.Length; i++)
{
    sum += weights[i];
}

// 1週間の体重の平均値を求める
float average = sum / weights.Length;
Console.WriteLine("平均値は" + average + "です"); 

// 練習問題  3-18
for (int i = 0; i < weights.Length; i++)
{
    if (weights[i] < 43.0f)
    {
        Console.WriteLine(weights[i]);
    }
} */

/* いらっしゃいませ！と表示するメソッドを定義
void Shop()
{
    Console.WriteLine("いらっしゃいませ！");
}

// Shopメソッドを呼び出す
Shop(); */

/* 練習問題 3-19
Thankyou();

void Thankyou()
{
    Console.WriteLine("ありがとうございました！");
} */

// 引数に商品名を受け取り、
// 商品名に応じた値段を表示するメソッド
void Shop(string itemName)
{
    Console.WriteLine("いらっしゃいませ！");

    if (itemName == "薬草")
    {
        Console.WriteLine(itemName + "は100円です");
    }
    else if (itemName == "棍棒")
    {
        Console.WriteLine(itemName + "は1500円です");
    }
    else
    {
        Console.WriteLine("売り切れです");
    }
}

Shop("薬草");