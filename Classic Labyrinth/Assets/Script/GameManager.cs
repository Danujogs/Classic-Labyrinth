using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject shootCount;
    [SerializeField] TMP_Text totalCount;
    [SerializeField]
    PlayerController player;
    [SerializeField] Hole hole;

    private void Start()
    {
        gameOverPanel.SetActive(false);

    }

    private void Update()
    {
        if (hole.Entered && gameOverPanel.activeInHierarchy == false)
        {
            shootCount.SetActive(false);
            gameOverPanel.SetActive(true);
            totalCount.text = "Total Shots: " + player.ShootCount;
        }
    }

    public void BackToMainMenu()
    {
        SceneLoader.Load("MainMenu");
    }

    public void Replay()
    {
        SceneLoader.ReloadLevel();
    }

    public void PlayNext()
    {
        SceneLoader.LoadNextLevel();
    }
}
