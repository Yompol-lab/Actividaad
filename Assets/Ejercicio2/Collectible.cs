using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    [System.Serializable]
    public class EventoRecoleccion : UnityEvent { }

    public EventoRecoleccion onCollected = new EventoRecoleccion();

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected.Invoke();
            Destroy(gameObject);
        }
    }
}