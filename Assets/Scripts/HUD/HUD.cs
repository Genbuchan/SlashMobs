using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{

    private UIDocument uiDocument;
    private Label label;
    private ScrollView chatLog;

    // Start is called before the first frame update
    void Start()
    {
        uiDocument = GetComponent<UIDocument>();
        label = uiDocument.rootVisualElement.Q<Label>("HP");
        chatLog = uiDocument.rootVisualElement.Q<ScrollView>("ChatLog");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerHPChanged(int hp)
    {
        label.text = "HP: " + hp;
    }

    public void OnMobSpeak(string message)
    {
        chatLog.Add(new Label(message));
    }
}
