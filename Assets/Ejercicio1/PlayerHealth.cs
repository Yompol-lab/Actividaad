using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int salud = 100;

    [System.Serializable]
    public class SaludCambiadaEvent : UnityEvent<int> { }

    public SaludCambiadaEvent OnSaludCambiada = new SaludCambiadaEvent();

    public void TomarDaño(int cantidad)
    {
        salud -= cantidad;
        salud = Mathf.Clamp(salud, 0, 100);
        OnSaludCambiada.Invoke(salud);
    }

    public int ObtenerSaludActual()
    {
        return salud;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TomarDaño(10);
        }
    }


}