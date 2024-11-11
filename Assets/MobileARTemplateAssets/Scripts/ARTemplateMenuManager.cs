using UnityEngine;

public class ARTemplateMenuManager : MonoBehaviour
{
    public ObjectSpawner m_ObjectSpawner; // Referencia al script de ObjectSpawner

    public void SetObjectToSpawn(int objectIndex)
    {
        if (m_ObjectSpawner == null)
        {
            Debug.LogWarning("Object Spawner not configured correctly: no ObjectSpawner set.");
            return;
        }

        if (objectIndex < 0 || objectIndex >= m_ObjectSpawner.objectPrefabs.Length)
        {
            Debug.LogWarning("Object index is out of bounds.");
            return;
        }

        m_ObjectSpawner.spawnOptionIndex = objectIndex;
        Debug.Log($"Object index set to: {objectIndex}");

        HideMenu(); // Opcional: ocultar el menú después de seleccionar un objeto
    }

    private void HideMenu()
    {
        // Código para ocultar el menú, si es necesario
    }
}
