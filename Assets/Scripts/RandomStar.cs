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
            Vector2 randomPosition = new Vector2(Random.Range(-2f, 2f), Random.Range(-4f, 4f)); // ������ġ�� ������, ������ġ�� �ϴ°�?? // ȭ�� ������ üũ

        }

    }
    public void test()
    {
        
    }

}
