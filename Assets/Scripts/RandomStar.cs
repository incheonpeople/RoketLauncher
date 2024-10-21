using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomStar : MonoBehaviour
{
    public GameObject starPrfab;
    public int starCount = 50;


    void Start()
    {
        test();
        for (int i = 0; i < starCount; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(-4f, 4f)); // 랜덤배치도 좋지만, 고정위치로 하는게?? // 화면 사이즈 체크

        }

    }
    public void test()
    {
        
    }

}
