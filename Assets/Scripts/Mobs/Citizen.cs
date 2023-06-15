using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Citizen : Living
{

    public HUD hud;
    private ListView listView;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact()
    {
        hud.OnMobSpeak("こんにちは。ようこそ。");
    }
}
