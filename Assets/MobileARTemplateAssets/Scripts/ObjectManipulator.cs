using UnityEngine;

public class ObjectManipulator : MonoBehaviour
{
    private Vector3 offset;
    private Camera arCamera;

    void Start()
    {
        arCamera = Camera.main;
    }

    void OnMouseDrag()
    {
        Vector3 screenPoint = Input.mousePosition;
        screenPoint.z = arCamera.nearClipPlane;
        Vector3 worldPoint = arCamera.ScreenToWorldPoint(screenPoint) + offset;
        transform.position = new Vector3(worldPoint.x, transform.position.y, worldPoint.z);
    }

    void OnMouseDown()
    {
        offset = transform.position - arCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, arCamera.nearClipPlane));
    }
}
//manipulacion
