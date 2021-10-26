using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//ここ忘れずに

public class HpBarScript : MonoBehaviour
{
    Slider HpBar;
    float Hp;

    // Start is called before the first frame update
    void Start()
    {
        //スライダーを取得
        HpBar = GameObject.Find("Slider").GetComponent<Slider>();

    }

    // Update is called once per frame
    void Update()
    {
        Hp = Mathf.Clamp(Hp, 0.0f, 1.0f);

        if (Input.GetKeyDown("up"))
        {
            Hp += 0.1f;
        }

        if(Input.GetKeyDown("down"))
        {
            Hp -= 0.1f;
        }

        // HPゲージに値を設定
        HpBar.value = Hp;
    }
}
