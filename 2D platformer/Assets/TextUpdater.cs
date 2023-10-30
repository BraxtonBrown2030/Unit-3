using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    
    public TextMeshProUGUI coinText;
    public SoOpenTrigger coinAmount;

    void Start()
    {
        coinAmount.value = 0;
    }

    void Update()
    {
        
        coinText.text = "Coins: " + coinAmount.value;


    }
}
