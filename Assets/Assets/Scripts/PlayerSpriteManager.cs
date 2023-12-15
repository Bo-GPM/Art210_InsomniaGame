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
    [SerializeField] SpriteRenderer baseSpriteLayer;
    [SerializeField] SpriteRenderer topSpriteLayer;

    [Header("Settings")]
    //[SerializeField] bool snapMode = true;
    //[SerializeField] float snapHeightThreshold = 10;
    [SerializeField] float maxHeight = 0;
    [SerializeField] float minHeight = 0;

    private bool isSketchy = true;

    private void Start()
    {
        topSpriteLayer.color = new Color(1, 1, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float currHeight = transform.position.y;

        float fadeAmount = Mathf.InverseLerp(minHeight, maxHeight, currHeight);
        topSpriteLayer.color = new Color(1, 1, 1, fadeAmount);

        /* SNAP VERSION
        if (isSketchy)
        {
            if (currHeight >= snapHeightThreshold)
            {
                baseSpriteLayer.sprite = fullRenderSprite;
                isSketchy = false;
            }
        }
        else
        {
            if (currHeight < snapHeightThreshold)
            {
                baseSpriteLayer.sprite = sketchySprite;
                isSketchy = true;
            }
        }
        */
    }
}
