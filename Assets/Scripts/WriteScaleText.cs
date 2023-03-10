using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteScaleText : MonoBehaviour
{
    public Transform referenceObject; // Sun, earth, center of MW etc.
    public string referenceObjectName; // Sun, earth, center of MW etc.
    public string unit; // AU, light year, etc.
    public float scaleFactor; // convert the distances of gameobjects to physical distances
    public string startText; // text to display at the start of the scene

    private float tStart;

    void Start()
    {
        tStart = Time.time;
        this.gameObject.GetComponent<TextMeshProUGUI>().text = startText;

        FindObjectOfType<AudioManager>().Play("solarNarration");
        FindObjectOfType<AudioManager>().Play("solarBgm");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - tStart < 5) // show the text for 5s
            return;

        float distance = scaleFactor * (this.gameObject.transform.position - referenceObject.position).magnitude;
        this.gameObject.GetComponent<TextMeshProUGUI>().text =
            "Distance to " + referenceObjectName + " (" + unit + "): " +
            distance.ToString("f2");
        ;
    }
}
