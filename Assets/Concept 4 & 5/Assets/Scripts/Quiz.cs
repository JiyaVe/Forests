using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class Quiz : MonoBehaviour
{
    [SerializeField] GameObject[] Questions;
    [SerializeField] GameObject Next;
    [SerializeField] GameObject QuestionResult;
    [SerializeField] GameObject ScoreBoard;
    [SerializeField] Sprite incorrectImage;
    [SerializeField] Sprite correctImage;
    [SerializeField] AudioSource Click;

    private int currQuestion = 0;
    private int score = 0;

    public void Correct()
    {
        Click.Play();
        GameObject[] incorrectAnswers = Questions[currQuestion].GetComponentsInChildren<Transform>().Where(go => go.CompareTag("Incorrect")).Select(go => go.gameObject).ToArray();
        GameObject correctAnswer = Questions[currQuestion].GetComponentsInChildren<Transform>().FirstOrDefault(go => go.CompareTag("Correct"))?.gameObject;
        foreach (GameObject incorrectAns in incorrectAnswers)
            incorrectAns.SetActive(false);
        
        QuestionResult.SetActive(true);
        Next.SetActive(true);
        QuestionResult.GetComponent<Image>().sprite = correctImage;

        QuestionResult.GetComponentInChildren<TextMeshProUGUI>().text = "Correct";
        correctAnswer.GetComponent<Button>().interactable = false;

        score++;
    }

    public void Incorrect(GameObject selectedAns)
    {
        Click.Play();
        GameObject[] incorrectAnswers = Questions[currQuestion].GetComponentsInChildren<Transform>().Where(go => go.CompareTag("Incorrect")).Select(go => go.gameObject).ToArray();
        GameObject correctAnswer = Questions[currQuestion].GetComponentsInChildren<Transform>().FirstOrDefault(go => go.CompareTag("Correct"))?.gameObject;
        foreach (GameObject incorrectAns in incorrectAnswers)
            incorrectAns.SetActive(false);
        
        selectedAns.SetActive(true);
        selectedAns.GetComponent<Image>().sprite = incorrectImage;

        QuestionResult.SetActive(true);
        Next.SetActive(true);
        QuestionResult.GetComponent<Image>().sprite = incorrectImage;

        QuestionResult.GetComponentInChildren<TextMeshProUGUI>().text = "Incorrect";
        correctAnswer.GetComponent<Button>().interactable = false;
        selectedAns.GetComponent<Button>().interactable = false;
    }

    public void NextQuestion()
    {
        Click.Play();
        Questions[currQuestion].SetActive(false);
        currQuestion++;
        if(currQuestion < 4)
            Questions[currQuestion].SetActive(true);
        else
        {
            ScoreBoard.SetActive(true);
            ScoreBoard.GetComponentInChildren<TextMeshProUGUI>().text = score.ToString();
        }
        QuestionResult.SetActive(false);
        Next.SetActive(false);
    }

    public void ReturnHome()
    {
        Click.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}