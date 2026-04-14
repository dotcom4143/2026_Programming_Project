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


    private List<int> GeneratePairNumbers(int cardCount)
    {

        int pairCount = cardCount / 2;
        List<int> newCardNumbers = new List<int>();

        for(int i = 0; i< pairCount; i++)
        {
            newCardNumbers.Add(i);
            newCardNumbers.Add(i);
        }


        for(int i = newCardNumbers.Count -1; i > 0; i--)
        {
            int rnd = Random.Range(0, i + 1);
            int temp = newCardNumbers[i];
            newCardNumbers[i] = newCardNumbers[rnd];
            newCardNumbers[rnd] = temp; 
        }

        return newCardNumbers;
    }

    private void StartGame()
    {
        List<int> randomPairNumbers = GeneratePairNumbers(cards.Count);

        for (int i = 0; i < cards.Count; ++i)
        {
            cards[i].SetCardNumbers(randomPairNumbers[i]);
            cards[i].SetImage(sprites[randomPairNumbers[i]]);
            cards[i].isFront = false;
        }
    }

    private void CheckCard()
    {
        isChecking = true;

        if(firstCard.cardNumbers == secondCard.cardNumbers)
        {
            firstCard.isMatched = true;
            secondCard.isMatched = true;

            //firstCard.ChangeColor(Color.yellow);
            //secondCard.ChangeColor(Color.yellow);

            firstCard = null;
            secondCard = null;
        }
        else
        {
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
