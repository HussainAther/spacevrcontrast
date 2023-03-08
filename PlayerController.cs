using UnityEngine;

public class ZoomController : MonoBehaviour {

    [SerializeField]
    private float zoomSpeed = 0.1f;

    void Update() {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0) {
            // get the transform component
            Transform transform = GetComponent<Transform>();
            // calculate the new scale
            float scale = transform.localScale.x + scroll * zoomSpeed;
            // limit the scale to a minimum of 0.1 and a maximum of 10
            scale = Mathf.Clamp(scale, 0.1f, 10f);
            // set the new scale
            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}