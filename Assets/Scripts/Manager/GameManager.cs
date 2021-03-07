using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Limite de X e Y do lado esquerdo da camera
    public static Vector2 leftLimit;
    // Limite de X e Y do lado direito da camera
    public static Vector2 rightLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = Camera.main;
        leftLimit = camera.ScreenToWorldPoint(new Vector3(0, 1, 0));
        rightLimit = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }
}
