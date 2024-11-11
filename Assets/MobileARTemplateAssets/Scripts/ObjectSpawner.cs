using System;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour

{
    public GameObject[] objectPrefabs; // Array de prefabs de los objetos para instanciar

    public int spawnOptionIndex; // Asegúrate de que sea pública si debe ser accesible desde otro script.

    // Evento que se activará cuando se genere un nuevo objeto
    public event Action<GameObject> OnObjectSpawned;

    // Método para generar un objeto
    public void SpawnObject(GameObject prefab)
    {
        GameObject spawnedObject = Instantiate(prefab, transform.position, transform.rotation);
        OnObjectSpawned?.Invoke(spawnedObject); // Llamada al evento
    }
}
