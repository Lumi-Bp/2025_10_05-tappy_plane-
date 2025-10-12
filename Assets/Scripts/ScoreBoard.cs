using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public GameObject scoreBoard;
    public GameObject medal;
    [Header("Medals")]
    public Sprite gold;
    public Sprite silver;
    public Sprite bronze;

    [Header("Textboxes")]
    public TextMeshProUGUI score_text;
    public TextMeshProUGUI best_text;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard.SetActive(false);
    }
    public void ShowScore(int score)
    {
        score_text.text = score.ToString();
        scoreBoard.SetActive(true);

        if (PlayerPrefs.HasKey("BestScore"))
        {
            var best = PlayerPrefs.GetInt("BestScore");
            if (best > score)
            {
                best_text.text = best.ToString();
                //medal = bronze;
            }
            else if (best == score)
            {
                //medal = silver;
            }
            else
            {
                //medal = gold;
                best_text.text = score.ToString();
                PlayerPrefs.SetInt("BestScore", score);
                PlayerPrefs.Save();

            }
        }
        else
            {
            //medal = gold;
            best_text.text = score.ToString();
            PlayerPrefs.SetInt("BestScore", score);
            PlayerPrefs.Save();

            }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
