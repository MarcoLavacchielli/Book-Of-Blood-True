using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VigorDeck : MonoBehaviour
{
    public VigorCards[] _deck;
    private int availableCardSlots = 3;
    public VigorCardsDisplay Slot4;
    public VigorCardsDisplay Slot5;
    public VigorCardsDisplay Slot6;
    public bool SlotBool4 = false;
    public bool SlotBool5 = false;
    public bool SlotBool6 = false;

    private void Awake()
    {
        _deck = Resources.FindObjectsOfTypeAll<VigorCards>();
    }

    public void DrawCards()
    {
        if (_deck.Length >= 1)
        {
            for (int i = 0; i <= availableCardSlots; i++)
            {
                VigorCards randomCard = _deck[Random.Range(0, _deck.Length)];
                if (i == 0 && SlotBool4 == false)
                {
                    Slot4.card = randomCard;
                    Slot4.actualizarinfodeUIdeCadaCarta();
                    SlotBool4 = true;
                }
                else if (i == 1 && SlotBool5 == false)
                {
                    Slot5.card = randomCard;
                    Slot5.actualizarinfodeUIdeCadaCarta();
                    SlotBool5 = true;
                }
                else if (i == 2 && SlotBool6 == false)
                {
                    Slot6.card = randomCard;
                    Slot6.actualizarinfodeUIdeCadaCarta();
                    SlotBool6 = true;
                }

            }

        }


    }
}
