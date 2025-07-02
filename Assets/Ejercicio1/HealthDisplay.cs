using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI saludText;

    void OnEnable()
    {
        if (playerHealth != null)
            playerHealth.OnSaludCambiada.AddListener(ActualizarTextoSalud);
    }

    void OnDisable()
    {
        if (playerHealth != null)
            playerHealth.OnSaludCambiada.RemoveListener(ActualizarTextoSalud);
    }

    public void ActualizarTextoSalud(int nuevaSalud)
    {
        saludText.text = "Salud: " + nuevaSalud.ToString();
    }
}