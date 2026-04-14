using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework;



public class Card : MonoBehaviour
{
    public TextMeshProUGUI card;
    public int cardNumbers;
    public float rotateSpeed;

    public bool isFront = false;
    public bool isMatched = false;

    public CardGame cardGame;

    private Quaternion flipRotation = Quaternion.Euler(0, 180f, 0);
    private Quaternion originRotation = Quaternion.Euler(0, 0, 0);

    void Update()
    {
        if(isFront)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, originRotation, rotateSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, flipRotation, rotateSpeed * Time.deltaTime);
        }
    }

    public void ClickCard()
    {

        if (!isMatched)
        {
            isFront = !isFront;
            cardGame.OnClickCard(this);
        }
    }

    public void SetCardNumbers(int newNumbers)
    {
        card = GetComponentInChildren<TextMeshProUGUI>();

        cardNumbers = newNumbers;

        card.text = cardNumbers.ToString();
    }

    public void SetImage(Sprite sprite)
    {
        GetComponent<Image>().sprite = sprite;
    }
}
