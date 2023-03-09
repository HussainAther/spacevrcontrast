using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // prevpos = 0, 0, 0, // previous object position; start at 0
        Vector3 boxSize = GetComponent<Renderer>().bounds.size;
        //Debug.Log(gameObject.name);
        //Debug.Log(gameObject.transform.position);
        //// float distance = Vector3.Distance (gameObject.transform.position, prevpos);
        //Debug.Log(boxSize.x);
        //Debug.Log(boxSize.y);
        //Debug.Log(boxSize.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
