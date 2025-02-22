using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets; 
    private float spawnRate = 1.0f; 
    private int score; 
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive; 
    public Button restartButton;

    void Start()
    {
        isGameActive = true; 
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
        
    }

    IEnumerator SpawnTarget()
    {
        
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);

            
            Instantiate(targets[index], RandomSpawnPosition(), Quaternion.identity);
        }
    }

    Vector3 RandomSpawnPosition()
    {
        
        float xRange = 4.0f; 
        float ySpawnPos = -6.0f; 
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos, 0);
    }

    public void UpdateScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = "Score: " + score; 
    }

    public void GameOver() {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true); 
    }
    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }


    void Update()
    {
        
    }
}

