using System;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour

{
    public GameObject[] objectPrefabs; // Array de prefabs de los objetos para instanciar

    public int spawnOptionIndex; // Aseg�rate de que sea p�blica si debe ser accesible desde otro script.

    // Evento que se activar� cuando se genere un nuevo objeto
    public event Action<GameObject> OnObjectSpawned;

    // M�todo para generar un objeto
    public void SpawnObject(GameObject prefab)
    {
        GameObject spawnedObject = Instantiate(prefab, transform.position, transform.rotation);
        OnObjectSpawned?.Invoke(spawnedObject); // Llamada al evento
    }
}
