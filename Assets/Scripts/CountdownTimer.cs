using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currenttime = 0f;
    float starttime = 10f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currenttime = starttime;
        countdownText.color = Color.black;

    }

    // Update is called once per frame
    void Update()
    {
        currenttime -= 1 * Time.deltaTime;
        countdownText.text = currenttime.ToString("0");
        
        if (currenttime <= 0)
        {
            currenttime = 0;
        }
        if(currenttime<5)
        {countdownText.color = Color.cyan;}

       

    }
}
