using UnityEngine;
using UnityEngine.UI;


public class GameScore : MonoBehaviour
{
    public Text ScoreText;
    public Text EndScore;
    public int GameScoreResult;

    private void Start()
    {
        GameScoreResult = 0;
        ScorePrintText();

    }

    public void ScorePrintText()
    {
        ScoreText.text = " " + GameScoreResult;
        EndScore.text = "You score: " + ScoreText.text;
    }

    public void ScoreCalculation(int ScoreValue)
    {
        GameScoreResult += ScoreValue;
        ScorePrintText();
    }


}
