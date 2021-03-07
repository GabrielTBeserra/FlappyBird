using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    [SerializeField] public GameObject pipe;
    private float lastSpawnedAmmoTime;
    private float timeAmmoCounter;

    private void Start()
    {
    }

    private void Update()
    {
    }

    private void FixedUpdate()
    {
        timeAmmoCounter += Time.deltaTime;


        if (lastSpawnedAmmoTime + 1 < timeAmmoCounter)
        {
            SpawnPipe();
            timeAmmoCounter = 0;
        }
    }

    private void SpawnPipe()
    {
        Instantiate(pipe, new Vector2(-2.25f,
                Random.Range(GameManager.leftLimit.y, GameManager.rightLimit.y)),
            new Quaternion());
    }
}