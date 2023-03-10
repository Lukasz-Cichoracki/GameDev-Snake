using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Snake: MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    private List<Transform> _segments;

    public Transform segmentPrefab;

    public int initalSize = 3;

    public float snakeSpeed = 0.60f;

    public SO_DifficultySettings sDS;

    private void Start()
    {
        if (sDS.Difficulty == 2)
            snakeSpeed = 1f;
        else if (sDS.Difficulty == 3)
            snakeSpeed = 1.25f;
        else
            snakeSpeed = 0.85f;
        
        _segments = new List<Transform>();
        _segments.Add(this.transform);
        for(int i = 1; i < initalSize; i++)
        {
            _segments.Add(Instantiate(this.segmentPrefab));
        }
        Time.timeScale = snakeSpeed;

    }

    private void Update()
    {
        if((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && _direction != Vector2.down)
            _direction = Vector2.up;
        else if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && _direction != Vector2.up) 
            _direction = Vector2.down; 
        else if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && _direction !=Vector2.right)
            _direction = Vector2.left;
        else if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && _direction !=Vector2.left)
            _direction = Vector2.right;

    }
    private void FixedUpdate()
    {
        for (int i = _segments.Count-1; i >0 ; i--)
        {
            _segments[i].position = _segments[i - 1].position;
        }

        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x + _direction.x),
            Mathf.Round(this.transform.position.y + _direction.y),
            0.0f
            );
       
    }
    
    private void Grow()
    {
        Transform segment = Instantiate(this.segmentPrefab);
        segment.position = _segments[_segments.Count - 1].position;

        _segments.Add(segment);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Food")
            Grow();
        else if (collision.tag == "Obstacle")
            DeathScreen.SetDeathScreenActive();
            
    }
    
}
