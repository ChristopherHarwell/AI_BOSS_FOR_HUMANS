using UnityEngine;
using UnityEngine.UI;

public class DialogPanel : MonoBehaviour
{
    public GameObject dialogPanel;
    public Text dialogText;

    void Start()
    {
        RectTransform rectTransform = this.gameObject.AddComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0, 0); // Anchor at bottom
        rectTransform.anchorMax = new Vector2(1, 0.3f); // Stretch across screen, take up bottom third of screen

        dialogPanel = this.gameObject;
        dialogText = this.gameObject.AddComponent<Text>();
    }
}
