using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework;



public class Card : MonoBehaviour
{
    public TextMeshProUGUI card;
    public int cardNum;
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
            cardGame.OnClickCard(this);
        }
    }

    public void SetCardNum(int newNum)
    {
        card = GetComponentInChildren<TextMeshProUGUI>();

        cardNum = newNum;

        card.text = cardNum.ToString();
    }

    public void ChangeColor(Color newColor)
    {
        GetComponent<Image>().color=newColor;
    }

    public void SetImage(Sprite sprite)
    {
        GetComponent<Image>().sprite = sprite;
    }

    public void Flip(bool isFront)
    {
        this.isFront = isFront;
    }
}
