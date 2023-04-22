using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class AnimacionCartas : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Vector3 initialScale; 

    void Start()
    {
        initialScale = transform.localScale; 
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
        LeanTween.scale(gameObject, initialScale * 1.5f, 0.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        LeanTween.scale(gameObject, initialScale, 0.2f);
    }
}
