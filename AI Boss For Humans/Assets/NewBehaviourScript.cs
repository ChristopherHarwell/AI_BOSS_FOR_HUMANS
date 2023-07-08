using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    // Reference to the button
    public Button myButton;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Button has been initialized!");

        // Set the button's onClick event
        myButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // This will be called when the button is clicked
    public void OnButtonClick()
    {
        Debug.Log("Button has been clicked!!!");
    }
}
