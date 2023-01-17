using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManager gm;
    [SerializeField] bool revers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("fuuuuuckkk");
       //iTween.MoveTo(gameObject, Vector3.zero*20, 2f);
       Goto(revers);
    }
    

    void Goto(bool rev){

        Transform[] arr = new Transform[gm.wayPointArray.Length]; 

        if(rev){

            Debug.Log("fuuuuuckkk2" + arr);  

            Array.Copy(gm.wayPointArray,arr,gm.wayPointArray.Length);
            //Debug.Log("fuuuuuckkk2" + gm.wayPointArray);
            Array.Reverse<Transform>(arr);
            StartCoroutine( fo(arr));

        }else{

            StartCoroutine( fo(gm.wayPointArray));
            
        }
        
        //return null;
        
    }

    IEnumerator fo(Transform[] arr){

           // Debug.Log("fuuuuuckkk2" + arr.Length);
            foreach (var spawnPoint in arr)
            {
                //    Debug.Log("fuuuuuckkk2" + arr.Length);
                iTween.MoveTo(gameObject, spawnPoint.position, 1f);
                yield return new WaitForSeconds(1.5f);
            } 
            Destroy(gameObject);
    }


}
