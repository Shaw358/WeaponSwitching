using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMesh;   

    public void SetText(string newText)
    {
        textMesh.text = newText;
    }
}
