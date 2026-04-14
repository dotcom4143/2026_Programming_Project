using UnityEngine;

public class Lecture01 : MonoBehaviour
{
    void Start()
    {

        // 더하기와 빼기가 둘다 작동하는 함수
        // 인자값을 통해서 더하기를 할지 마이너스를 할지 결정할 수 있음
        // bool = true false

        // 정수
        // 실수
        //

        int age = 0;
        float height = 177.5f;
        double height2 = 177.5d;
        string name = "헨리";
        bool isMale = false;

        // 앞으로의 코딩은 변수를 사용한다
        // 변수를 사용하기 위해선 선언하고 초기화를 해야한다

        age = 22; // 대입연산자를 넣으면 변수가 바뀐다
        height = 175.5f;
        name = "신구";
        bool a = true;

        age = age + 1;
        age = age - 1;
        age = age * 2;
        age = age / 2;

        age += 1;
        age -= 1;
        age += 2;
        age /= 2;

        // 
        int number = 100;
        // 10을 더하고 30으로 나눠봐

        // number = number + 10;
        // number = number / 30;
    
        number = (number + 10) / 30;

        // 함수 
        int firstNumber = Plus(10, 20);

        // 나누기
        // 곱하기

        Debug.Log(Plus(10, 40));

        int hp = 100;

        // 조건문 : if/else

        if(hp <= 0)
        {
            // 몬스터 죽음
        }
        else
        {
            // 몬스터 생존
        }

        Debug.Log(GetBigger(10, 20));


    }


    int GetBigger(int left, int right)
    {
       if(left > right)
       {
            return left;
       } 
       else
       {
            return right;
       }
    }

    void Funtion(int left, int right)
    {

    }

    int Funtion2(int left, int right)
    {
        // 로직

        return 0;
    }

    int Plus(int left, int right)
    {
        return left + right;
    }

    int Minus(int left, int right)
    {
        return left - right;
    }

    float Multiplication(float left, float right)
    {
        return left * right;
    }

    float Division(float left, float right)
    {
        return left / right;
    }

    void Update()
    {
        
    }
}
