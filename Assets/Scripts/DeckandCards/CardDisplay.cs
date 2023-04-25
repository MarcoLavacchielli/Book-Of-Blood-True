using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
   
    
    public Card card;
    public Text nametext;
    public Text descriptiontext;
    public Image image;
    
    public Text attacktext;
    public Deck scriptdeck;
    public int myslot;
    public int attackdmg;

    public string NombredelaCartayEjecutarPasiva;
    public Player player;

    private void Start()
    {
        
        nametext.text = card.name;
        descriptiontext.text = card.description;
        image.sprite = card.image;
       
        attacktext.text = card.attack.ToString();
       
    }
    public int Thecarddmg()
    {
        if(myslot == 1)
        {
            attackdmg = card.attack;
            return (attackdmg);
        }
        else if(myslot == 2)
        {
            attackdmg = card.attack;
            return (attackdmg);
        }
        else
        {
            attackdmg = card.attack;
            return (attackdmg);
        }
    }
    public void actualizarinfodeUIdeCadaCarta()
    {
        nametext.text = card.name;
        descriptiontext.text = card.description;
        image.sprite = card.image;
        
        attacktext.text = card.attack.ToString();
    }

    public void ejecutarpasivadelacarta()
    {
        NombredelaCartayEjecutarPasiva = card.name;
        /*if(NombredelaCartayEjecutarPasiva=="Sacred Font")
        {
            player.PlayerHealth += 5;
            Debug.Log("te has curado 5 puntos de salud");

        }*/
        switch (NombredelaCartayEjecutarPasiva)
        {
            case "Sacred Font":
                player.PlayerHealth += 5;
                Debug.Log("te has curado 5 puntos de salud");
                break;
           
        }

    }
    
}
