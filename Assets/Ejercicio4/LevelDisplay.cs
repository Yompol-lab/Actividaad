using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
{
    public LevelManager levelManager;
    public TextMeshProUGUI nivelText;

    void OnEnable()
    {
        if (levelManager != null)
        {
            levelManager.onNivelCambiado.AddListener(ActualizarTextoNivel);
        }
    }

    void OnDisable()
    {
        if (levelManager != null)
        {
            levelManager.onNivelCambiado.RemoveListener(ActualizarTextoNivel);
        }
    }

    public void ActualizarTextoNivel(int nivel)
    {
        nivelText.text = "Nivel: " + nivel.ToString();
    }
}