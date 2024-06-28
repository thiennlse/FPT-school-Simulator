// This script is for the buttons the answers will go on

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Reflection;


public class AnswerButton : MonoBehaviour
{
    private bool isCorrect;
    [SerializeField] private TextMeshProUGUI answerText;
    public Color startColor;
    private Image buttonImage;
    public float delayTime = 2.0f;

    // To make it ask a new question after the first question
    [SerializeField] private QuestionSetup questionSetup;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
        if (buttonImage != null)
        {
            startColor = buttonImage.color;
        }
    }

    public void SetAnswerText(string newText)
    {
        answerText.text = newText;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCorrect = newBool;
    }

    public void SetQuestionSetup(QuestionSetup qs)
    {
        questionSetup = qs;
    }

    public void OnClick()
    {
        if (isCorrect)
        {
            Debug.Log("CORRECT ANSWER");
            GetComponent<Image>().color = Color.green;
        }
        else
        {
            Debug.Log("WRONG ANSWER");
            GetComponent<Image>().color = Color.red;
        }

        // Update score based on the correctness of the answer
        questionSetup.UpdateScore(isCorrect);

        // Get the next question if there are more in the list
        if (questionSetup.questions.Count > 0)
        {
            StartCoroutine(NextQuestion());
        }
    }

    private IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(delayTime);
        // Generate a new question
        questionSetup.Start();
        ResetButtonColor();
    }

    public void ResetButtonColor()
    {
        if (buttonImage != null)
        {
            buttonImage.color = startColor;
        }
    }

}