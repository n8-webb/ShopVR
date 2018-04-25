using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using VRTK;

public class ItemInformation : MonoBehaviour
{
    public int itemID;
    public string displayName;
    public TextMeshPro text;
    public string itemName;
    public float price;
    public float discountedPrice;
    public enum isle
    {
        dairy, bakery, meat, biscuitsSnacks, tins, teaCoffee, healthBeauty, fruitVeg, frozen
    };

    public isle isleList;

    public enum discounts
    {
        zeroPercent, tenPercent, twentyPercent, thirtyPercent, fourtyPercent, fiftyPercent
    };

    public discounts discount;// Use this for initialization
    void Start()
    {
        text = this.gameObject.GetComponentInChildren<TextMeshPro>();
        discountedPrice = price;
        CheckDiscount();

        if (discount == discounts.zeroPercent)
        {
            text.text = itemName + " " + price;
        }
        else
        {
            text.text = itemName + " " + price + " Discounted to : " + discountedPrice.ToString() + "0";
        }





    }

    void CheckDiscount()
    {
       
        switch(discount)
        {
            case discounts.zeroPercent:
                break;
            case discounts.tenPercent:
                discountedPrice = price * 0.9f;
                discountedPrice = Mathf.Round(discountedPrice * 100f) / 100f;
                break;
            case discounts.twentyPercent:
                discountedPrice = price * 0.8f;
                discountedPrice = Mathf.Round(discountedPrice * 100f) / 100f;
                break;
            case discounts.thirtyPercent:
                discountedPrice = price * 0.7f;
                discountedPrice = Mathf.Round(discountedPrice * 100f) / 100f;
                break;
            case discounts.fourtyPercent:
                discountedPrice = price * 0.6f;
                discountedPrice = Mathf.Round(discountedPrice * 100f) / 100f;
                break;
            case discounts.fiftyPercent:
                discountedPrice = price * 0.5f;
                discountedPrice = Mathf.Round(discountedPrice * 100f) / 100f;
                break;

        }
       
    }

}

