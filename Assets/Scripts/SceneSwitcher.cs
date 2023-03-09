using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GoToScene(sceneName);
        }
    }
}
