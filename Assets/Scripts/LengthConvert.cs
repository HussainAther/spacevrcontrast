using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LengthConvert : MonoBehaviour
{
    public void newScale(GameObject Sun, float newSize) {

        float size = Sun.GetComponent<Renderer> ().bounds.size.y;

        Vector3 rescale = Sun.transform.localScale;

        rescale.y = newSize * rescale.y / size;

        Sun.transform.localScale = rescale;

}
}
