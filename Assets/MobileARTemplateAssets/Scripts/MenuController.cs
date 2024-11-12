using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class MenuController : MonoBehaviour
{
    [SerializeField] ObjectSpawner objectSpawner; // Referencia al script ObjectSpawner

    public void OnMesaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(0); // �ndice para la mesa
        }
        else
        {
            Debug.LogWarning("No se asign� el ObjectSpawner en el inspector.");
        }
    }

    public void OnLamparaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(1); // �ndice para la l�mpara
        }
        else
        {
            Debug.LogWarning("No se asign� el ObjectSpawner en el inspector.");
        }
    }

    public void OnCamaButtonPressed()
    {
        if (objectSpawner != null)
        {
            objectSpawner.SetSpawnOptionIndex(2); // �ndice para la cama
        }
        else
        {
            Debug.LogWarning("No se asign� el ObjectSpawner en el inspector.");
        }
    }
}

