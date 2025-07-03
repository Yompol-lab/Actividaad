using UnityEngine;
using UnityEngine.Events;

public class Npc : MonoBehaviour
{
    public UnityEvent onInteractuar;

    private bool jugadorCerca = false;

    void Update()
    {
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            onInteractuar.Invoke();
            Debug.Log("Interacci�n con NPC");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;
        }
    }
}