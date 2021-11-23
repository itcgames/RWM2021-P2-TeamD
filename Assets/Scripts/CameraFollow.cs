using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform m_followTransform;
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position =
            new Vector3(m_followTransform.position.x, m_followTransform.position.y,
            this.transform.position.z);
    }
}
