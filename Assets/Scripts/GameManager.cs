using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;
    [SerializeField] private float slowness = 10f;

    private bool isGameEnded = false;

    void Update()
    {
        if (!isGameEnded)
        {
            float score = Time.timeSinceLevelLoad * 10f;
            scoreText.SetText(score.ToString("0"));
        }
    }

    public void EndGame()
    {
        if (isGameEnded != true)
        {
            isGameEnded = true;
            scoreText.SetText("Game Over");
            StartCoroutine(RestartLevel());
        }
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        yield return new WaitForSeconds(4f / slowness);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}