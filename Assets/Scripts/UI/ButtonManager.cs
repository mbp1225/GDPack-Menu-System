using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public class ButtonManager : MonoBehaviour, ISelectHandler
{
    [SerializeField] private AudioClip buttonSound;
    private AudioSource aSource;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void OnSelect(BaseEventData eventData)
    {
        aSource.PlayOneShot(buttonSound);
    }

}
