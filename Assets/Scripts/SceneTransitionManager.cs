using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    // trigger scene transition when scale of object falls below some threshold
    public float scaleThreshold = 1e-4f;
    // the id of the scene to transition to
    public int sceneIndex;

    // Update is called once per frame
    void Update()
    {
        // scene transition
        if (this.gameObject.transform.localScale.x < scaleThreshold)
        {
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
