using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonManager : MonoBehaviour, ISelectHandler
{
    [Header("References")]
    [SerializeField] private AudioClip buttonSound;
    private AudioSource aSource;

    [SerializeField] TutorialScreen tutorial;

    [SerializeField] Color[] colors;
    [SerializeField] RawImage indicator;

    [Header("Tutorial Info")]
    [SerializeField] string gameName;
    [SerializeField] string tutorialText;
    [SerializeField] Texture tutorialImage;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void OnSelect(BaseEventData eventData)
    {
        indicator.color = colors[Random.Range(0,3)];
        aSource.PlayOneShot(buttonSound);
    }

    public void Press()
    {
        SetTutorial();
        print("Pressed " + gameObject.name);
    }

    void SetTutorial()
    {
        tutorial.gameObject.SetActive(true);
        tutorial.Tutorial(gameName, tutorialText, tutorialImage);
    }
}
