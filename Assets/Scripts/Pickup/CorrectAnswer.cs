using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectAnswer : MonoBehaviour
{
    public void Correct()
    {
        ScoreScript.scoreValue += 50;
    }
}
