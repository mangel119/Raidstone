using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public void IncreaseScore(){
        score++;
        scoreText.text = score.ToString();
    }
}
