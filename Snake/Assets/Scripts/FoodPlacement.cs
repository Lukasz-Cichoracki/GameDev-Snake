using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodPlacement : MonoBehaviour
{
    public BoxCollider2D gameArea;

    private void Start()
    {
        RandomizePosition();
    }
    private void RandomizePosition()
    {
        Bounds bounds = this.gameArea.bounds;

        float xPos = Mathf.Round(Random.Range(bounds.min.x, bounds.max.x));
        float yPos = Mathf.Round(Random.Range(bounds.min.y, bounds.max.y));

        this.transform.position = new Vector3(xPos, yPos, 0.0f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Snake")
            RandomizePosition();
    }
}
