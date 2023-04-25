using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deck : MonoBehaviour
{
    //public ScriptableObject[] _deck;
    /*private void Start()
    {
        //quiero llamar a las carpeta Cards de los assets para llenar el array y no puedo.
        //_deck = ScriptableObject.FindObjectsOfTypeIncludingAssets(Cards);
        


    }*/

    //public List<Card> _deck = new List<Card>(4);
    public Card[] _deck;
    private int availableCardSlots = 3;
    public CardDisplay Slot1;
    public CardDisplay Slot2;
    public CardDisplay Slot3;
    public bool SlotBool1 = false;
    public bool SlotBool2 = false;
    public bool SlotBool3 = false;

    private void Awake()
    {
        _deck = Resources.FindObjectsOfTypeAll<Card>();
    }

    public void DrawCards()
    {
        if (_deck.Length >= 1)
        {
            for (int i = 0; i <= availableCardSlots; i++)
            {
                Card randomCard = _deck[Random.Range(0, _deck.Length)];
                if (i == 0 && SlotBool1 == false)
                {
                    Slot1.card = randomCard;
                    Slot1.actualizarinfodeUIdeCadaCarta();
                    SlotBool1 = true;
                }
                else if (i == 1 && SlotBool2 == false)
                {
                    Slot2.card = randomCard;
                    Slot2.actualizarinfodeUIdeCadaCarta();
                    SlotBool2 = true;
                }
                else if (i == 2 && SlotBool3 == false)
                {
                    Slot3.card = randomCard;
                    Slot3.actualizarinfodeUIdeCadaCarta();
                    SlotBool3 = true;
                }

            }

        }


    }
}
