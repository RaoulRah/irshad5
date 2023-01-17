using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform[] waypoints;
    private void OnMouseDown()
    {
        StartCoroutine(TeleportPrefabCoroutine());
    }

    private IEnumerator TeleportPrefabCoroutine()
    {
        // Instancier un cube
        GameObject spawnedObject = Instantiate(prefab);
        if (waypoints.Length < 2) yield break;

        // Bouger le cube au pointB 
        spawnedObject.transform.position = waypoints[0].position;

        for (int i =0; i<waypoints.Length;i++)
        {
            yield return LerpCoroutine(spawnedObject, waypoints[i].position, waypoints[i+1].position);
        }

        // faire disparaitre le cube
        spawnedObject.SetActive(false);
    }

    private IEnumerator LerpCoroutine(GameObject objectToLerp, Vector3 start, Vector3 end)
    {
        float u = 0f;
        while (u<=1f)
        {
            // Déplacer l'objet entre start et end
            objectToLerp.transform.position = Vector3.Lerp(start, end, u);
            u += Time.deltaTime * 0.5f;
            // Attendre la frame suivante
            yield return null;
        }
        objectToLerp.transform.position = end;
    }
}
