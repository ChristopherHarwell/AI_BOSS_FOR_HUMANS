using UnityEngine;
using UnityEngine.UI;

public class LargeButton : MonoBehaviour
{
    public Button largeButton;
    public string buttonText;

    void Start()
    {
        largeButton = this.gameObject.AddComponent<Button>();
        Text textComponent = this.gameObject.AddComponent<Text>();
        textComponent.text = buttonText;

        RectTransform rectTransform = this.gameObject.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(300, 150); // Change these values to adjust the size of the button
    }
}
