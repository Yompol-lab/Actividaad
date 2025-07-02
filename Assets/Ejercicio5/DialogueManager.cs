using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public void MostrarDialogo()
    {
        dialogueText.text = "Un forastero!";
        dialogueText.gameObject.SetActive(true);
    }

    public void OcultarDialogo()
    {
        dialogueText.text = "";
        dialogueText.gameObject.SetActive(false);
    }
}