using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeMoveSpeedSolarSystem : MonoBehaviour
{
    private ActionBasedContinuousMoveProvider continuousMoveProvider;
    public float startSpeed = 10f;

    private void Start()
    {
        // Get the ContinuousMoveProvider component
        continuousMoveProvider = GetComponent<ActionBasedContinuousMoveProvider>();
    }

    private void Update()
    {
        float z = this.gameObject.transform.position.z;
        float speed = startSpeed;
        if (z < 0) // Venus and Mercury
        {
            speed = 20f;
        }
        if (z > 20 && z < 200) // asteroids
        {
            speed = 50;
        }
        if (z > 200 & z < 360) // Jupiter
        {
            speed = 80;
        }
        if (z > 360 & z < 780) // Saturn
        {
            speed = 100;
        }
        if (z > 780 & z < 1800) // Uranus
        {
            speed = 250;
        }
        if (z > 1800) // Neptune and beyond
        {
            speed = 300;
        }
        continuousMoveProvider.moveSpeed = speed;
    }
}
