using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    public List<Card> cards;
    public List<Sprite> sprites;

    private Card firstCard = null;
    private Card secondCard = null;
    private bool isChecking = false;

    void Start()
    {
        StartGame();
    }


    private List<int> GeneratePairNum(int cardCount)
    {

        int pairCount = cardCount / 2;
        List<int> newCardNum = new List<int>();

        for(int i = 0; i< pairCount; i++)
        {
            newCardNum.Add(i);
            newCardNum.Add(i);
        }


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
    {
        List<int> randomPairNum = GeneratePairNum(cards.Count);

        for (int i = 0; i < cards.Count; ++i)
        {
            cards[i].SetCardNum(randomPairNum[i]);
            cards[i].SetImage(sprites[(randomPairNum[i])]);
        }
    }

    private void CheckCard()
    {
        isChecking = true;

        if(firstCard.cardNum == secondCard.cardNum)
        {
            firstCard.isMatched = true;
            secondCard.isMatched = true;

            firstCard.ChangeColor(Color.yellow);
            secondCard.ChangeColor(Color.yellow);

            firstCard = null;
            secondCard = null;

            isChecking = false;
        }
        else
        {
            Invoke("HideCard", 2.0f);
        }
    }

    private void HideCard()
    {
        firstCard.Flip(false);
        secondCard.Flip(false);

        isChecking = false;

        firstCard = null;
        secondCard = null;
    }

    public void OnClickCard(Card Card)
    {
        if(isChecking)
        {
            return;
        }

        if (firstCard == null)
        {
            firstCard = Card;
            firstCard.Flip(true);
        }
        else if (firstCard !=Card)
        {
            secondCard = Card;
            secondCard.Flip(true);
        }

        if(firstCard != null && secondCard != null)
        {
            CheckCard();
        }
    }
}
