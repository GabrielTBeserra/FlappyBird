using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    
    [Range(-1f, 1f)]
    public float XSpeed = 0.5f;

    private Vector2 _offset;
    private Material _material;
    
    private void Start()
    {
        _material = GetComponent<Renderer>().material;
        _offset = new Vector2(XSpeed, 0);
    }

    private void Update()
    {
        _material.mainTextureOffset += _offset * Time.deltaTime;
    }
}