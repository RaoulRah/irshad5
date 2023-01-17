using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointGizmo : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 0.5f);
        Gizmos.color = Color.blue;
    }
}
