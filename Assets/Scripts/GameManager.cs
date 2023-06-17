using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    const int QUESTION_COUNT = 4;

    string[] answers = new string[QUESTION_COUNT];

    void Start()
    {
        answers[0] = "2.6";

        answers[1] = "3.2";
        answers[2] = "2.4";

        answers[3] = "5";
    }

    public bool[] CheckAnswers(TMP_InputField[] answerInputs)
    {
        bool[] results = new bool[QUESTION_COUNT];

        for(int i = 0; i < answerInputs.Length; i++)
        {
            if (answerInputs[i].text.Length >= 1)
            {
                if (answerInputs[i].text == answers[i]) results[i] = true;
                else results[i] = false;
            }
            else results[i] = false;
        }

        return results;
    }
}