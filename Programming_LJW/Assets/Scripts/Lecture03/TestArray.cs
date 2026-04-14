using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class TestArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 자료형 이름
        int name = 3;

        // 
        int[] arrayName = new int[10];
        arrayName[0] = 10;
        arrayName[5] = 20;

        for(int i = 0; i < 10; i++)
        {
            arrayName[i] = i;
        }

        List<int> testList = new List<int>();
        testList.Add(5);
        testList.Add(10);
        testList.Add(15);


    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
