using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject menuPausaUI;
    public GameObject interfazJuegoUI;

    public void MostrarJuegoUI()
    {
        if (interfazJuegoUI != null)
            interfazJuegoUI.SetActive(true);

        if (menuPausaUI != null)
            menuPausaUI.SetActive(false);
    }

    public void MostrarMenuPausaUI()
    {
        if (interfazJuegoUI != null)
            interfazJuegoUI.SetActive(false);

        if (menuPausaUI != null)
            menuPausaUI.SetActive(true);
    }
}