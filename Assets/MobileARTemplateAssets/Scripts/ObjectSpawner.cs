using System;
using UnityEngine;
using UnityEngine.InputSystem; // Importar el Input System

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs; // Array de prefabs de los objetos para instanciar
    public int spawnOptionIndex = 0; // �ndice del objeto a spawnear

    // Evento que se activar� cuando se genere un nuevo objeto
    public event Action<GameObject> OnObjectSpawned;

    private Camera arCamera;
    private PlayerInput playerInput; // Agregamos PlayerInput

    void Start()
    {
        arCamera = Camera.main;
        playerInput = GetComponent<PlayerInput>(); // Inicializamos PlayerInput
    }

    // M�todo para establecer el objeto a spawnear
    public void SetObjectToSpawn(GameObject newObjectPrefab)
    {
        for (int i = 0; i < objectPrefabs.Length; i++)
        {
            if (objectPrefabs[i] == newObjectPrefab)
            {
                spawnOptionIndex = i;
                break;
            }
        }
    }

    // M�todo para generar el objeto en la posici�n del clic
    void Update()
    {
        if (playerInput.actions["Click"].WasPressedThisFrame()) // Usamos el Input Action "Click" (definido en el Input System)
        {
            Ray ray = arCamera.ScreenPointToRay(Mouse.current.position.ReadValue()); // Obtenemos la posici�n del mouse con el Input System
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Generar el objeto en la posici�n donde se hizo clic
                SpawnObjectAtPosition(hit.point);
            }
        }
    }

    // M�todo para generar el objeto en una posici�n espec�fica
    public void SpawnObjectAtPosition(Vector3 position)
    {
        if (spawnOptionIndex >= 0 && spawnOptionIndex < objectPrefabs.Length)
        {
            GameObject prefab = objectPrefabs[spawnOptionIndex];
            GameObject spawnedObject = Instantiate(prefab, position, Quaternion.identity);
            OnObjectSpawned?.Invoke(spawnedObject);
        }
        else
        {
            Debug.LogWarning("�ndice de spawn no v�lido.");
        }
    }
}
