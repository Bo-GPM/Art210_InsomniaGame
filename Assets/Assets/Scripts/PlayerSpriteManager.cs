using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class PlayerSpriteManager : MonoBehaviour
{
    [Header("Assets")]
    [SerializeField] Sprite sketchySprite;
    [SerializeField] Sprite fullRenderSprite;

    [Header("Object References")]
    [SerializeField] SpriteRenderer playerSpriteRender;

    [Header("Settings")]
    [SerializeField] float maxSketchyHeight = 10;

    private bool isSketchy = true;

    // Update is called once per frame
    void Update()
    {
        float currHeight = transform.position.y;

        if (isSketchy)
        {
            if (currHeight >= maxSketchyHeight)
            {
                playerSpriteRender.sprite = fullRenderSprite;
                isSketchy = false;
            }
        } 
        else
        {
            if (currHeight < maxSketchyHeight)
            {
                playerSpriteRender.sprite = sketchySprite;
                isSketchy = true;
            }
        }
    }
}
