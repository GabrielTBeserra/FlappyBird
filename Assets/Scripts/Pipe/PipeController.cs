using System.Collections;
using System.Collections.Generic;
using Base;
using Manager;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    
    private BirdController _bird;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.velocity = Vector2.left * 3;
        Destroy(gameObject, 3.5f);
        _bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        _bird._point.AddPoint(1);  
        print(_bird._point.Points);
        Data.GlobalPoints = _bird._point.Points;
        EventController.addPoints( _bird._point.Points);
    }
    
}
