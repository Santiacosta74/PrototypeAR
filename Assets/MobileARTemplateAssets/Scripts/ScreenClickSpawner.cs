using UnityEngine;

public class ScreenClickSpawner : MonoBehaviour
{
    public ObjectSpawner objectSpawner;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detectar clic en la pantall
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 spawnPosition = hit.point;
                objectSpawner.SpawnObjectAtPosition(spawnPosition); // Instanciar el objeto en la posici
            }
        }
    }
}
