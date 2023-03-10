using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClassroomNarration : MonoBehaviour
{
    public FadeScreen fadeScreen;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        fadeScreen.FadeIn();
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().Play("cityBgm");
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().Play("classroomNarration");
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
