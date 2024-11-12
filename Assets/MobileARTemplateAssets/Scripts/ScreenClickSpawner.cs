using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class ScreenClickSpawner : MonoBehaviour
{
    public ObjectSpawner objectSpawner;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detectar clic en la pantalla
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Vector3 spawnPosition = hit.point;
                Vector3 spawnNormal = hit.normal; // Normal de la superficie donde se hace clic

                // Llamamos a TrySpawnObject y le pasamos la posición y la normal
                objectSpawner.TrySpawnObject(spawnPosition, spawnNormal);
            }
        }
    }
}
