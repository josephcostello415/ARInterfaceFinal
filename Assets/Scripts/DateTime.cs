using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DateTime : MonoBehaviour
{

    public TMP_Text Time;
    private string theTime;
    public TMP_Text Date;
    private string theDate;

    // Update is called once per frame
    void Update()
    {
        theTime = System.DateTime.Now.ToString("MM/dd/yy h:mm tt");
        theDate = System.DateTime.Now.ToString("MM/dd/yyyy"); ;
        Time.SetText(theTime);
        Date.SetText(theDate);
    }
}
