using System.Numerics;
using UnityEngine;

public class L2_Monster : MonoBehaviour
{

    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }

        int l = 0;
        while( l < 10)
        {
            l++;
            Debug.Log(l);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += UnityEngine.Vector3.forward * 0.03f;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += UnityEngine.Vector3.left * 0.03f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position += UnityEngine.Vector3.back * 0.03f;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += UnityEngine.Vector3.right * 0.03f;
        }
    }
}
