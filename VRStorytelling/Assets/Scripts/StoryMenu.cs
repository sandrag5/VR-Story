using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryMenu : MonoBehaviour
{
    public GameObject[] storySlots;
    public GameObject DeleteMsgPopUp;

    void Start()
    {

    }

    void Update()
    {
        foreach (GameObject story in storySlots)
        {
            SetElementsForEmptySlots(story);
        }
    }

    // Cambiar a elige una escena
    // TODO Pasar parametros para que cargue segun los datos guardados
    public void DoOnPlayClick()
    {
        SceneManager.LoadScene("ForestScene");
    }

    public void DoOnDeleteClick()
    {
        DeleteMsgPopUp.SetActive(true);
    }

    public void SetElementsForEmptySlots(GameObject story)
    {
        string title = story.GetComponentInChildren<Button>(false).GetComponentInChildren<TextMeshProUGUI>().text;

        if (title == "Vacío")
        {
            //No interactable buttons for empty slots
            story.GetComponentInChildren<Button>().interactable = false;
        }
        else
        {
            //All buttons active
            var buttons = story.GetComponentsInChildren<Button>(true);
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
                button.interactable = true;
            }
        }
    }

}
