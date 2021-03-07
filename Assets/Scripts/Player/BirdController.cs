using System;
using Base;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    private Transform _position;
    private Rigidbody2D _rigidbody2D;
    public Point _point;
    private void Start()
    {
        Time.timeScale = 1;
        _point = new Point(0);
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _position = GetComponent<Transform>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) _rigidbody2D.AddForce(Vector2.up * 5, ForceMode2D.Impulse);

        if (_position.position.y < GameManager.leftLimit.y)
        {
            var pos = transform.position;

            pos.y = Mathf.Clamp(pos.y, GameManager.leftLimit.y, GameManager.leftLimit.y);

            _position.position = pos;
            _rigidbody2D.velocity = Vector2.zero;
        } else if (_position.position.y > GameManager.rightLimit.y)
        {
            var pos = transform.position;

            pos.y = Mathf.Clamp(pos.y, GameManager.rightLimit.y, GameManager.rightLimit.y);

            _position.position = pos;
            _rigidbody2D.velocity = Vector2.zero;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Pipe"))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("LoseScreen");
        }
        
        
    }
    
}