using System.Collections;
using System.Collections.Generic;
using Manager;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Text scoreText = null;
    // Start is called before the first frame update
    void Start()
    {
        Data.GlobalPoints = 0;
        scoreText.text = $"Pontuação: 0";
        EventController.addPoints += UpdateScore;
    }

    // Update is called once per frame
    void OnDisable()
    {
        EventController.addPoints -= UpdateScore;
    }



    public void UpdateScore(int score)
    {
        
        scoreText.text = $"Pontuação: {score}";
    }
}
