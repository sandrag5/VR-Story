using System.Collections;
using TMPro;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public TextMeshPro textDisplay;
    public string[] story;
    private int index;
    public float typingSpeed;

    public GameObject continueButton;
    //public GameObject reticlePointer;

    private Collider storedGameObject;

    public void Start()
    {
        StartCoroutine(ShowDialogMessage());
    }

    private void Update()
    {
        if (textDisplay.text == story[index])
        {
            continueButton.SetActive(true);
            //reticlePointer.SetActive(false);
        }
    }

    IEnumerator ShowDialogMessage()
    {
        foreach (char letter in story[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void StartStory()
    {
        StartCoroutine(ShowDialogMessage());
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        //reticlePointer.SetActive(false);

        if (index < story.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(ShowDialogMessage());
        }
        else
        {
            textDisplay.text = "";
            continueButton.SetActive(false);
            //reticlePointer.SetActive(false);
        }
    }
}
