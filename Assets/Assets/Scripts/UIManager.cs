using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Object References")]
    [SerializeField] Slider uiGlassesSlider;
    [SerializeField] GameObject player;

    [Header("Settings")]
    [SerializeField] float maxPlayerHeight = 10;
    [SerializeField] float minPlayerHeight = 0;

    // Update is called once per frame
    void Update()
    {
        float currPlayerHeight = player.transform.position.y;
        float meterProgress = Mathf.InverseLerp(minPlayerHeight, maxPlayerHeight, currPlayerHeight);
        uiGlassesSlider.value = meterProgress;
        print("Curr height " + currPlayerHeight);
    }
}
