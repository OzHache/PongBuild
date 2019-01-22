using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum PlayerGoal { Player1, Player2}

public class Goal : MonoBehaviour
{
    public PlayerGoal ScoreFor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.GetGameManager.Score(ScoreFor);
    }
}
