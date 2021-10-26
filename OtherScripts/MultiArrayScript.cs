using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulitiArrayScript : MonoBehaviour
{
		private int[,] intValues;
		private string[,] stringValues;

		// Use this for initialization
		void Start()
		{

			//　配列の要素数の確保
			intValues = new int[,] //3次元は[,,]
		{
			{0, 1, 2},
			{3, 4, 5},
			{6, 7, 8} //列は,で、行は{}で区切る
		};

			//　配列要素を個別に出力
			Debug.Log(intValues[0, 0] + "," + intValues[0, 2]); //要素は行と列どちらも0から始まる

			//　配列要素の全て出力
			foreach (var intValue in intValues)
			{
				Debug.Log(intValue);
			}

			//　配列の要素数の確保
			stringValues = new string[2, 3];//行,列の要素数

		//　要素を個別に設定
			stringValues[0, 0] = "abc";
			stringValues[0, 1] = "def";
			stringValues[0, 2] = "ghi";

			stringValues[1, 0] = "jkl";
			stringValues[1, 1] = "mno";
			stringValues[1, 2] = "pqr";

		//結果 0列  1列  2列
		//0行 abc, def, ghi
		//1行 jkl, mno, pqr

		//　配列要素の出力
		foreach (var stringValue in stringValues)
			{
				Debug.Log(stringValue);
			}
		}
	}