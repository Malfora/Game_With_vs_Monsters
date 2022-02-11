using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{

    public int NewScoreValue;

    private GameScore gameScore;

    private void Start()
    {
        GameObject GameControllerTag = GameObject.FindWithTag("GameController");

        if (GameControllerTag != null)
        {
            gameScore = GameControllerTag.GetComponent<GameScore>();
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Столкновение с объектом");

        gameScore.ScoreCalculation(NewScoreValue);
    }

    


}
