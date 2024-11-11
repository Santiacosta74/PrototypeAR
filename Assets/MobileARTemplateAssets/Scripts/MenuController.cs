using UnityEngine;

public class MenuController : MonoBehaviour
{
    public ObjectSpawner objectSpawner; // Referencia al script ObjectSpawner

    // Este m�todo se llamar� cuando se presione el bot�n para seleccionar el mueble
    public void SelectObject(GameObject newObject)
    {
        objectSpawner.SetObjectToSpawn(newObject); // Cambia el objeto a spawnear
    }
}

