using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteScaleText : MonoBehaviour
{
    public Transform referenceObject; // solar system, earth, MW etc.
    public float startScale = 1; // scale of the ruler at the start of the scene, set by user
    private float objectStartScale; // stores the scale of the scene at the start of the scene

    // Start is called before the first frame update
    void Start()
    {
        objectStartScale = referenceObject.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        float currentScale = 1.0f / (referenceObject.localScale.x / objectStartScale * startScale);
        this.gameObject.GetComponent<TextMeshProUGUI>().text =
            currentScale.ToString("G2") + "meters" +
            "\n_______";
        ;
    }
}
