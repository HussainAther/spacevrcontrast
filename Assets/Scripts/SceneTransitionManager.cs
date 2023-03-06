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

    // fade screen upon scene transition
    public FadeScreen fadeScreen;

    public void GoToScene(int sceneIndex)
    {
        if (this.gameObject.transform.localScale.x < scaleThreshold)
        {
            StartCoroutine(GoToSceneRoutine(sceneIndex)); ;
        }
    }

    private IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        fadeScreen.FadeIn();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        // scene transition
        if (this.gameObject.transform.localScale.x < scaleThreshold)
        {
            GoToScene(sceneIndex);
        }
    }
}
