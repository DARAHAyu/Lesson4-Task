using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // 発展課題①：int型の変数mpを宣言し、53で初期化する

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを与えた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 発展課題②: mpを消費して魔法攻撃をするMagic関数を作成する
    public void Magic()
    {
        // 発展課題③: mpが5以上の時に5減らし、コンソールに「魔法攻撃をした。残りMPは○○。」と表示する
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        // 発展課題③: mpが足りない場合、「MPが足りないため、魔法が使えない。」と表示する
        else if (mp < 5)
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 通常課題①: 要素の個数が5の、int型の配列arrayを宣言して、好きな値で初期化する
        int[] array = new int[5];

        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 通常課題②: for文を使い、配列の各要素の値を順番に表示する
        for (int i = 0; i <= 4; i++)
        {
            Debug.Log(array[i]);
        }

        // 通常課題③: for文を使い、配列の各要素の値を逆順に表示する
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 発展課題④: Magic関数を呼び出して魔法を使う
        lastboss.Magic();
        // 発展課題⑤: Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示する
        for (int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
    }
}
