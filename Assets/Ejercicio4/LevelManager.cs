using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class NivelEvent : UnityEvent<int> { }

public class LevelManager : MonoBehaviour
{
    public NivelEvent onNivelCambiado;
    private int nivelActual = 1;

    public void CambiarNivel(int nuevoNivel)
    {
        nivelActual = nuevoNivel;
        onNivelCambiado.Invoke(nivelActual);
        Debug.Log("Cambiando al nivel: " + nivelActual);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            CambiarNivel(nivelActual + 1);
        }
    }
}