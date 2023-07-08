using UnityEngine;
using UnityEngine.UI;

public class StorePanel : MonoBehaviour
{
    public GameObject storePanel;
    public Text storeText;

    void Start()
    {
        RectTransform rectTransform = this.gameObject.AddComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0.1f, 0.1f); // Anchor in center of screen
        rectTransform.anchorMax = new Vector2(0.9f, 0.9f); // Stretch to fill most of the screen

        storePanel = this.gameObject;
        storeText = this.gameObject.AddComponent<Text>();
    }
}
