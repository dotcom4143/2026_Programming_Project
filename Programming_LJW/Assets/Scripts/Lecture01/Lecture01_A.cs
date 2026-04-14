using UnityEngine;

public class Lecture01_A : MonoBehaviour
{
    void Start()
    {
        // 더하기와 빼기가 둘다 작동하는 함수
        // 인자값을 통해서 더하기를 할지 마이너스를 할지 결정할 수 있음

        Debug.Log(PlusOrMinus(10, 20, true));
        Debug.Log(PlusOrMinus(30, 15, false));
    }

    int PlusOrMinus(int left, int right, bool isAdd)
    {
        if(isAdd)
        {
            return left + right;
        }
        else
        {
            return left - right;
        }
    }

    int MulOrDiv(int left, int right, bool isMul)
    {
        if(isMul)
        {
            return left * right;
        }
        else
        {
            return left / right;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
