using UnityEngine;
using UnityEngine.UI;

public class SmallButton : MonoBehaviour
{
    public Button smallButton;
    public string buttonText;

    void Start()
    {
        smallButton = this.gameObject.AddComponent<Button>();
        Text textComponent = this.gameObject.AddComponent<Text>();
        textComponent.text = buttonText;

        RectTransform rectTransform = this.gameObject.GetComponent<RectTransform>();
        rectTransform.sizeDelta = new Vector2(100, 50); // Change these values to adjust the size of the button
    }
}
