using System.Collections;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] story;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    public GameObject reticlePointer;

    private Collider storedGameObject;

    public void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        if(textDisplay.text == story[index])
        {
            continueButton.SetActive(true);
            reticlePointer.SetActive(false);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in story[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void StartStory()
    {
        StartCoroutine(Type());
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        reticlePointer.SetActive(false);

        if (index < story.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            reticlePointer.SetActive(false);
        }
    }
}
