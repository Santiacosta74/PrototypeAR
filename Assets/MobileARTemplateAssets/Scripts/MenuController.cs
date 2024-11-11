using UnityEngine;

public class MenuController : MonoBehaviour
{
    public ObjectSpawner objectSpawner; // Referencia al script ObjectSpawner

    // Este método se llamará cuando se presione el botón para seleccionar el mueble
    public void SelectObject(GameObject newObject)
    {
        objectSpawner.SetObjectToSpawn(newObject); // Cambia el objeto a spawnear
    }
}

