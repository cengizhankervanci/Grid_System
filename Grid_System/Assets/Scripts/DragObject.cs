using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private float mZCoord;
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }
    private Vector3 GetMouseAsWorldPoint()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag()
    {
        transform.position = new Vector3(GetMouseAsWorldPoint().x, transform.position.y, GetMouseAsWorldPoint().z);
    }
}
