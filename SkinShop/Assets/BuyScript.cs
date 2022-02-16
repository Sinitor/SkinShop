using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuyScript : MonoBehaviour
{
    public int skinNum;
    public bool isPurchased;
    public string ppName;
    public Text priceText;
    public int price;
    public int purch;

    private void Start()
    {
        purch = PlayerPrefs.GetInt(ppName, 0);
        if (purch == 0)
        {
            priceText.text = price + "$";
        }
        else
        {
            priceText.text = "SOLID";
            isPurchased = true;
        }
    } 

    public void Buy()
    {
        if (Money.money >= price && isPurchased == false)
        {
            PlayerPrefs.SetInt(ppName, 1);
            Money.money -= price; 
            priceText.text = "SOLID";
            isPurchased = true;
        }
        else if (isPurchased == true)
        {
            StartCoroutine(select());
        }
    } 

    IEnumerator select()
    {
        string lastText = priceText.text;
        priceText.text = "TAKEN";
        Money.selectedSkin = skinNum;
        yield return new WaitForSeconds(0.5f);
        priceText.text = lastText;
    }
}
