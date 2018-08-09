using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;// Required when using Event data.

public abstract class ButtonManager : MonoBehaviour, ISelectHandler
{
    [Header("References")]
    [SerializeField] protected AudioClip selectSound;
    [SerializeField] protected AudioClip pressSound;
    protected AudioSource aSource;

    [SerializeField] Color[] colors;
    [SerializeField] RawImage indicator;

    [SerializeField] protected bool hasColorSwapping;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void OnSelect(BaseEventData eventData)
    {
        indicator.color = colors[Random.Range(0,3)];
        aSource.PlayOneShot(selectSound);
    }

    public abstract void Press();
}
