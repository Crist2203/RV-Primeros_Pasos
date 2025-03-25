using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public float speed = 2f;
    private bool isGazedAt = false;

    void Update()
    {
        if (isGazedAt)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }

    public void OnPointerEnterXR()
    {
        isGazedAt = true;
    }

    public void OnPointerExitXR()
    {
        isGazedAt = false;
    }
}

