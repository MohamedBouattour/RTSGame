using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI  timerText;
    [SerializeField] float  scale = 2;
    float minutes;
    float days =0;
    float hours =0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    minutes += Time.deltaTime*scale;
    if (minutes >= 60) // Assuming elapsed time is in seconds and 60 seconds = 1 minute
    {
        hours += 1;
        minutes = 0;
    }
    if (hours >= 24)
    {
        days += 1;
        hours=0;
    }

    // Displaying time in the format: 00Days 00Hours 00Minutes
    timerText.text = string.Format("{0:00}Days {1:00}Hours {2:00}Minutes", days, hours, minutes);
    }

}
