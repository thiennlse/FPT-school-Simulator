    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TMP_Text coin;
    public int currCoin = 0;
    // Start is called before the first frame update
    private int money = 0;
    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        money = PlayerPrefs.GetInt("money");
        currCoin = money; 
        coin.text = "VND: " + currCoin.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("money", this.currCoin);
    }
    public void PayMoney(int amount)
    {
        currCoin -= amount;
        coin.text = "VND: " + currCoin.ToString();
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("money",500000000);
    }
}
