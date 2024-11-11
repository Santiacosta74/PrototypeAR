using UnityEngine;

public class MenuController : MonoBehaviour
{
    public ObjectSpawner objectSpawner; // Referencia al script ObjectSpawner

    public void SelectObject(GameObject newObject)
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetObjectToSpawn(newObject); // Solo selecciona el objeto
        }
        else
        {
            Debug.LogWarning("No se asignó el ObjectSpawner en el inspector.");
        }
    }

}
