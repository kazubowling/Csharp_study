﻿/* コンソールに文字列を表示する
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

int playerPosX = 5;
int enemyPosX = 10;

// プレイヤーと敵の位置が等しい場合は敵と遭遇
if (playerPosX == enemyPosX)
{
    Console.WriteLine("敵と遭遇");
}