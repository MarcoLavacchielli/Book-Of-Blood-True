using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VigorCardsDisplay : MonoBehaviour
{
    public VigorCards card;
    public Text nametext;
    public Text descriptiontext;
    public Image image;

    public Text vigortext;
    public VigorDeck vigorscriptdeck;
    public int myslot;
    public int thevigorCostOfMyCard;

    public string NombredelaCartadeVigoryEjecutarPasiva;
    public Player player;
    public StadisticPlayer stadisticplayerScipt;

    private void Start()
    {

        nametext.text = card.name;
        descriptiontext.text = card.description;
        image.sprite = card.image;

        vigortext.text = card.vigorcost.ToString();
        thevigorCostOfMyCard = card.vigorcost;

    }
    public void actualizarinfodeUIdeCadaCarta()
    {
        nametext.text = card.name;
        descriptiontext.text = card.description;
        image.sprite = card.image;

        vigortext.text = card.vigorcost.ToString();
    }
    public int actualizarinformacióncostedeVigor()
    {
        thevigorCostOfMyCard = card.vigorcost;
        return (thevigorCostOfMyCard);
    }
    public void ejecutarpasivadelacartadevigor()
    {
        NombredelaCartadeVigoryEjecutarPasiva = card.name;
        
        switch (NombredelaCartadeVigoryEjecutarPasiva)
        {
            case "Warrior Pendant":
                stadisticplayerScipt.health += 5;
                Debug.Log("te has curado 5 puntos de salud");
                break;

        }

    }
}
