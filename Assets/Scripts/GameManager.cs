using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public Image[] lifeImages;
    public Sprite activeLife;
    public Sprite deactiveLife;

    public GameObject winUi;
    public GameObject loseUi;

    public int nextLevelIndex;

    public void UpdateScoreUi(int score)
    {
        scoreText.text = score.ToString();
    }

    public void UpdateLifeUi(int life)
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < life)
            {
                lifeImages[i].sprite = activeLife;
            }
            else
            {
                lifeImages[i].sprite = deactiveLife;
            }
        }
    }

    public void WinGame()
    {
        winUi.SetActive(true);
    }
    public void LoseGame()
    {
        loseUi.SetActive(true);
    }

    public void OnMainMenuClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void OnNextLevelClicked()
    {
        SceneManager.LoadScene(nextLevelIndex);
    }
    public void OnRetryClicked()
    {
        int i = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(i);
    }
}
