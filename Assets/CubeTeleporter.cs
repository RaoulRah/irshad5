using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTeleporter : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform waypoint1, waypoint2, waypoint3;
    private void OnMouseDown()
    {
        StartCoroutine(TeleportPrefabCoroutine());
    }

    private IEnumerator TeleportPrefabCoroutine()
    {
        // Instancier un cube
        GameObject spawnedObject = Instantiate(prefab);
        // Bouger le cube au waypoint 1
        spawnedObject.transform.position = waypoint1.position;

        // attendre 2 secondes
        yield return new WaitForSeconds(2f);

        // Bouger le cube waypoint 2
        spawnedObject.transform.position = waypoint2.position;

        // attendre 2 secondes
        yield return new WaitForSeconds(2f);

        // Bouger le cube waypoint 3
        spawnedObject.transform.position = waypoint3.position;
        // attendre 2 secondes
        yield return new WaitForSeconds(2f);

        // faire disparaitre le cube
        spawnedObject.SetActive(false);
    }
}
