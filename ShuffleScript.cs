using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShuffleScript : MonoBehaviour
{
    public Text[] ShuffleText = new Text[5];

    //引数として受け取った配列の要素番号を並び替える
    private void Shuffle(Text[] num)
    {
        for (int i = 0; i < num.Length; i++)
        {
            Text temp = num[i]; //現在の要素を預けておく
            int randomIndex = Random.Range(0, num.Length); //入れ替える先をランダムに選ぶ
            num[i] = num[randomIndex]; //現在の要素に上書き
            num[randomIndex] = temp; //入れ替え元に預けておいた要素を与える
        }

        for (int j = 0; j < num.Length; j++)
        {
            ShuffleText[j].text = j.ToString(); //要素をテキストで表示
        }
    }

    public void ShuffleStartClick()
    {
        Shuffle(ShuffleText);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
