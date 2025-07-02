using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    public UnityEvent onGameStart;
    public UnityEvent onGamePause;

    private bool isGamePaused = false;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return) && isGamePaused)
        {
            ReanudarJuego();
        }


        if (Input.GetKeyDown(KeyCode.Escape) && !isGamePaused)
        {
            PausarJuego();
        }
    }

    public void PausarJuego()
    {
        isGamePaused = true;
        Time.timeScale = 0f;
        onGamePause.Invoke();
        Debug.Log("Juego Pausado");
    }

    public void ReanudarJuego()
    {
        isGamePaused = false;
        Time.timeScale = 1f;
        onGameStart.Invoke();
        Debug.Log("Juego Reanudado");
    }
}

