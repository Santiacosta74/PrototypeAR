using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class MenuController : MonoBehaviour
{
    [SerializeField] ObjectSpawner objectSpawner; // Referencia al script ObjectSpawner

    public void OnMesaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(0); // Índice para la mesa
        }
        else
        {
            Debug.LogWarning("No se asignó el ObjectSpawner en el inspector.");
        }
    }

    public void OnLamparaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(1); // Índice para la lámpara
        }
        else
        {
            Debug.LogWarning("No se asignó el ObjectSpawner en el inspector.");
        }
    }

    public void OnCamaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(2); // Índice para la cama
        }
        else
        {
            Debug.LogWarning("No se asignó el ObjectSpawner en el inspector.");
        }
    }
}

