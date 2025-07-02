using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int cantidadObjetos = 0;

    public void AddItem()
    {
        cantidadObjetos++;
        Debug.Log("Objeto recolectado. Total: " + cantidadObjetos);
    }
}