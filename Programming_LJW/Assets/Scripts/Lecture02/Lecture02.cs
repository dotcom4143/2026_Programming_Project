using UnityEngine;

public class Lecture02 : MonoBehaviour
{
    // 객체지향 언어 C#
    // 객체지향 언어란?
    // 객체를 기반으로 객체끼리의 상호작용을 하는 프로그래밍 언어를 뜻한다 

    // class = 일종의 설계도

    // 클래스는 변수와 함수가 합쳐져 만들어진 객체이다

    void Start()
    {
        Human man = new Human();                    // Human 클래스라는 설계도를 사용해 man이라는 객체를 만든다
        man.name = "신구";
        man.age = 20;
        man.height = 185.1f;
        man.weight = 80.0f;
        man.HP = 20;

        Human man2 = new Human();                   // Human 클래스라는 설계도를 사용해 또다른 객체인 man2를 만들었다
        man2.name = "대학생";
        man2.age = 23;
        man2.height = 170.3f;
        man2.weight = 65.0f;
        man.HP = 30;

        man.Introduce();                            // 객체는 자신이 가지고 있는 함수를 호출할 수 있다
        man2.Introduce();

        man.Attack(man2);                           // 객체는 함수를 호출해 다른 객체와 상호작용을 할 수 있다
        man2.Attack(man);

        Debug.Log(man2.HP);
    }

    void Update()
    {
        
    }
}


// 클래스는 변수와 함수가 합쳐져 만들어진 객체이다

public class Human
{
    public string name;
    public int age;
    public float height;
    public float weight;
    public int HP;

    public void walk()
    {
        Debug.Log("걷기");
    }

    public void Eat()
    {
        Debug.Log("먹기");
    }

    public void Sleep()
    {
        Debug.Log("자기");
    }

    public void Introduce()
    {
        Debug.Log("안녕하세요. 제 이름은 " + name + " 입니다.");
    }

    public void Attack(Human target)
    {
        target.HP -= 5;
    }
}