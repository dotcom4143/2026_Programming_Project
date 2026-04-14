using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    public List<Card> cards;

    private Card firstCard = null;
    private Card secondCard = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartGame();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private List<int> GeneratePairNum(int cardCount)
    {
        // 페어 카드 넘버 생성

        // 우리의 게임에선 이번에 10개의 페어카드를 만든다

        int pairCount = cardCount / 2; // 몇개의 짝을 만들어야 하는지 계산 실행
        List<int> newCardNum = new List<int>();

        for(int i = 0; i< pairCount; i++)
        {
            newCardNum.Add(i);          // 리스트에는 Add() 라는 함수로 값을 추가한다
            newCardNum.Add(i);
        }

        //  [0] [0] [1] [1] [2] [2] [3] [3] [4] [4]

        for(int i = newCardNum.Count -1; i > 0; i--)
        {
            int rnd = Random.Range(0, i + 1);
            int temp = newCardNum[i];
            newCardNum[i] = newCardNum[rnd];
            newCardNum[rnd] = temp; 
        }

        return newCardNum;
    }

    private void StartGame()
    {// 게임 초기화 
        List<int> randomPairNum = GeneratePairNum(cards.Count);

        for (int i = 0; i < cards.Count; i++)
        {
            cards[i].SetCardNum(randomPairNum[i]);
        }
    }

    private void CheckCard()
    {
        if(firstCard.cardNum == secondCard.cardNum)
        {
            // 정답

            firstCard.isMatched = true;
            secondCard.isMatched = true;

            firstCard.ChangeColor(Color.yellow);
            secondCard.ChangeColor(Color.yellow);

            firstCard = null;
            secondCard = null;
        }
        else
        {
            // 오답

            Invoke("HideCard", 2.0f);
        }
    }

    private void HideCard()
    {
        firstCard.isFront = false;
        secondCard.isFront = false;
    }

    public void OnClickCard(Card Card)
    {
        // 카드가 선택되면 호출

        if (firstCard == null)
        {
            firstCard = Card;
        }
        else
        {
            secondCard = Card;
        }

        if(firstCard != null && secondCard != null)
        {
            CheckCard();
        }
    }
}
