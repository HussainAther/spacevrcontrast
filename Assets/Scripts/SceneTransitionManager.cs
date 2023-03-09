using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionManager : MonoBehaviour
{
    // trigger scene transition when distance to earth goes above some threshold
    public float distanceThreshold = 4000;
    // position of earth
    public Transform earthTransform;
    // the id of the scene to transition to
    public string sceneName;

    // fade screen upon scene transition
    public FadeScreen fadeScreen;

    public void GoToScene(string sceneName)
    {
        StartCoroutine(GoToSceneRoutine(sceneName)); ;
    }

    private IEnumerator GoToSceneRoutine(string sceneName)
    {
        fadeScreen.FadeIn();
        yield return new WaitForSeconds(fadeScreen.fadeDuration);

        SceneManager.LoadScene(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if (distanceThreshold < 0)
            return;

        float distance = (earthTransform.position - this.gameObject.transform.position).magnitude;
        // scene transition
        if (distance > distanceThreshold)
        {
            GoToScene(sceneName);
        }
    }
}
