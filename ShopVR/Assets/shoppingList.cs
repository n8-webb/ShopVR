//Original Code by Niall Webb
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class shoppingList : MonoBehaviour {
    public List<string> shopList = new List<string>();
    public TextMeshPro itemCount;
    public float cost = 0f;
   
	// Use this for initialization
	void OnCollisionEnter(Collision col)
    {
        if (col.gameObject)
        {
            ItemInformation item = col.gameObject.GetComponent<ItemInformation>();
            shopList.Add(item.itemName);
            cost = cost + item.discountedPrice;
            Destroy(col.gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
        itemCount.text = "Items: " + shopList.Count.ToString() + "      Total: " + cost.ToString();
	}
}
