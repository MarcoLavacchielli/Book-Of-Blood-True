using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    Player player;
    public Image combatUI;
    public bool cardsEquiped = false;
    //Variables del mazo
    public List<Card> deck = new List<Card>();
    public Transform[] cardslots;
    public bool[] availableCardSlots;
    public Text deckSizeText;
    //PROFE si ve esto  es solo prueba del script de mazo, nada más
    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            Card randomCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    // randomCard.gameObject.setActive(true);
                    //randomCard.transform.position = cardslots[i].position;
                    availableCardSlots[i] = false;
                    deck.Remove(randomCard);
                    return;
                }
            }
        }

       //  void Update()
        //{
            //deckSizeText.text = deck.Count.ToString();
        //}
    }



































    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        player = FindObjectOfType<Player>();
    }
    public Player Player()
    {
        
        {
            return player;
        }
    }
    public static Transform PlayerTransform
    {
        get
        {
            return instance.player.transform;

        }

    }

    public void activeUI()
    {
        cardsEquiped = !cardsEquiped;
        combatUI.gameObject.SetActive(cardsEquiped);

    }
}
