using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointGizmo : MonoBehaviour
{
    [SerializeField] float gizmoSize = 0.33f;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
