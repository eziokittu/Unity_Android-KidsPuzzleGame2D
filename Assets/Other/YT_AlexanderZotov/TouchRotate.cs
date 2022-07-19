using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        transform.eulerAngles += new Vector3(0.0f, 0.0f, -90.0f);
        //transform.Rotate(0f, 0f, -90f);

        Debug.Log("Touched " + transform.name + ", Rotation : " + transform.eulerAngles);
    }
}
