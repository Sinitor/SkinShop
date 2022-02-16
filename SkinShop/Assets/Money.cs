using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text moneyText;
    public static int money;
    public static int selectedSkin;


    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        Debug.Log(selectedSkin);
    }

    private void FixedUpdate()
    {
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money + "$";
        money += 10;
    }
}
