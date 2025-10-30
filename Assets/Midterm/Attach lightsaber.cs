using UnityEngine;

public class Attachlightsaber : MonoBehaviour
{ public Sprite newSprite;
    public SpriteRenderer SpriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = newSprite;
        SpriteRenderer.color = Color.blue;

    }

    // Update is called once per frame
    void Update()
    {
       

    }
}
