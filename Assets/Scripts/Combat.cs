using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    private Player player;
    public ParticleSystem damageParticleSlot1;
    public ParticleSystem damageParticleSlot2;
    public ParticleSystem damageParticleSlot3;
    public ParticleSystem damageparticleSlot4;
    //int contador;
    //public EnemyAldeano enemyaldean;
    public Enemy enemyy;
    //private CombatPosition combat;
    //private bool combatmode = false;
    int playercontador;
    public Deck deckscript;
    public CardDisplay carddisplayscriptinSlot1;
    public CardDisplay carddisplayscriptinSlot2;
    public CardDisplay carddisplayscriptinSlot3;
    public VigorCardsDisplay carddisplayscriptinSlot4;
    public VigorCardsDisplay carddisplayscriptinSlot5;
    public VigorCardsDisplay carddisplayscriptinSlot6;
    public Image cardOrange1;
    public Image cardOrange2;
    public Image cardOrange3;
    public Image cardOrange4;
    public Image cardOrange5;
    public Image cardOrange6;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    private bool cartafueUsada = true;
    private bool cartafueUsada2 = true;
    private bool cartafueUsada3 = true;
    private bool cartafueUsada4 = true;
    private bool cartafueUsada5 = true;
    private bool cartafueUsada6 = true;
    private bool enemyattack = false;
    public VigorDeck VigorDeckScript;
    public StadisticPlayer PlayerStadisticsScript;
    //int MoreVigorPerRound=10;

    public object WaitForSeconds3 { get; private set; }

    void Start()
    {
        /*if (enemy >= 1)
        {
            combatmodeON();
            if (combatmode == true)
            {
                for (int turnos = 1; turnos >= 1; turnos++)
                {
                    Debug.Log("Inicia el turno numero " + turnos);
                    //carddmg();
                }
            }
        }*/
    }
    void Update()
    {
        Enemydealsdamage();
    }

    public void activaryDesactivarCartaAlUsarlaSlot1()
    {
        cartafueUsada = !cartafueUsada;
        cardOrange1.gameObject.SetActive(cartafueUsada);

    }
    public void activaryDesactivarCartaAlUsarlaSlot2()
    {
        cartafueUsada2 = !cartafueUsada2;
        cardOrange2.gameObject.SetActive(cartafueUsada2);

    }
    public void activaryDesactivarCartaAlUsarlaSlot3()
    {
        cartafueUsada3 = !cartafueUsada3;
        cardOrange3.gameObject.SetActive(cartafueUsada3);

    }

    public void activaryDesactivarCartaAlUsarlaSlot4()
    {
        cartafueUsada4 = !cartafueUsada4;
        cardOrange4.gameObject.SetActive(cartafueUsada4);

    }
    public void activaryDesactivarCartaAlUsarlaSlot5()
    {
        cartafueUsada5 = !cartafueUsada5;
        cardOrange5.gameObject.SetActive(cartafueUsada5);

    }
    public void activaryDesactivarCartaAlUsarlaSlot6()
    {
        cartafueUsada6 = !cartafueUsada6;
        cardOrange6.gameObject.SetActive(cartafueUsada6);

    }

    public void setenemy(Enemy enemy)
    {
        enemyy = enemy;
    }
    /*public void carddmg()
    {
        if (contador == 0)
        {
            enemyaldean.health -= 2;
            Debug.Log("El player inflingio 2 de daño");
            Debug.Log("Al enemigo le queda " + enemyaldean.health + " de vida ");
            contador += 1;

        }
    }*/
    /*public void combatmodeON()
    {
        combatmode = true;
    }*/
    public void Enemydealsdamage()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enemyattack == true)
        {
            //PlayerStadisticsScript.vigor = MoreVigorPerRound + 1;
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;
            button5.interactable = true;
            button6.interactable = true;
            enemyy.Enemyturn();
            //contador = 0;
            playercontador = 0;
            deckscript.DrawCards();
            VigorDeckScript.DrawCards();

            if (cartafueUsada == false)
            {
                activaryDesactivarCartaAlUsarlaSlot1();
            }
            if (cartafueUsada2 == false)
            {
                activaryDesactivarCartaAlUsarlaSlot2();
            }
            if (cartafueUsada3 == false)
            {
                activaryDesactivarCartaAlUsarlaSlot3();
            }
            if (cartafueUsada4 == false)
            {
                activaryDesactivarCartaAlUsarlaSlot4();
            }
            if (cartafueUsada5 == false)
            {
                activaryDesactivarCartaAlUsarlaSlot5();
            }
            if (cartafueUsada6 == false)
            {
                activaryDesactivarCartaAlUsarlaSlot6();
            }
            enemyattack = false;
        }
    }
    public void clickonslotone()
    {
        if (carddisplayscriptinSlot1.myslot == 1 && playercontador == 0)
        {
            deckscript.SlotBool1 = false;
            int carddmgtrue = carddisplayscriptinSlot1.Thecarddmg();
            enemyy.health -= carddmgtrue;
            carddisplayscriptinSlot1.ejecutarpasivadelacarta();
            damageParticleSlot1.Play();
            Debug.Log("El player inflingio " + carddmgtrue + (" de daño"));
            Debug.Log("Al enemigo le queda " + enemyy.health + " de vida ");
            //contador = 1;
            enemyattack = true;
            playercontador = 1;
            deckscript.DrawCards();
            activaryDesactivarCartaAlUsarlaSlot1();
            button1.interactable = false;
        }
    }
    public void clickonslottwo()
    {
        if (carddisplayscriptinSlot2.myslot == 2 && playercontador == 0)
        {
            deckscript.SlotBool2 = false;
            int carddmgtrue = carddisplayscriptinSlot2.Thecarddmg();
            enemyy.health -= carddmgtrue;
            carddisplayscriptinSlot2.ejecutarpasivadelacarta();
            damageParticleSlot2.Play();
            Debug.Log("El player inflingio " + carddmgtrue + (" de daño"));
            Debug.Log("Al enemigo le queda " + enemyy.health + " de vida ");
            //contador = 1;
            enemyattack = true;
            playercontador = 1;
            activaryDesactivarCartaAlUsarlaSlot2();
            button2.interactable = false;
        }
    }
    public void clickonslotthree()
    {
        if (carddisplayscriptinSlot3.myslot == 3 && playercontador == 0)
        {
            deckscript.SlotBool3 = false;
            int carddmgtrue = carddisplayscriptinSlot3.Thecarddmg();
            enemyy.health -= carddmgtrue;
            carddisplayscriptinSlot3.ejecutarpasivadelacarta();
            damageParticleSlot3.Play();
            Debug.Log("El player inflingio " + carddmgtrue + (" de daño"));
            Debug.Log("Al enemigo le queda " + enemyy.health + " de vida ");
            //contador = 1;
            enemyattack = true;
            playercontador = 1;
            activaryDesactivarCartaAlUsarlaSlot3();
            button3.interactable = false;
        }
    }
    public void clickonslotfour()
    {
        if (PlayerStadisticsScript.vigor >= carddisplayscriptinSlot4.actualizarinformacióncostedeVigor())
        {
            PlayerStadisticsScript.vigor -= carddisplayscriptinSlot4.actualizarinformacióncostedeVigor();
            Debug.Log("restan " + PlayerStadisticsScript.vigor + " puntos de vigor");
            carddisplayscriptinSlot4.ejecutarpasivadelacartadevigor();
            activaryDesactivarCartaAlUsarlaSlot4();

            button4.interactable = false;
            VigorDeckScript.SlotBool4 = false;
            damageparticleSlot4.Play();
        }
    }
    public void clickonslotfive()
    {
        if (PlayerStadisticsScript.vigor >= carddisplayscriptinSlot5.actualizarinformacióncostedeVigor())
        {
            PlayerStadisticsScript.vigor -= carddisplayscriptinSlot5.actualizarinformacióncostedeVigor();
            Debug.Log("restan " + PlayerStadisticsScript.vigor + " puntos de vigor");
            carddisplayscriptinSlot5.ejecutarpasivadelacartadevigor();

            activaryDesactivarCartaAlUsarlaSlot5();
            button5.interactable = false;
            VigorDeckScript.SlotBool5 = false;
        }
    }
    public void clickonslotsix()
    {
        if (PlayerStadisticsScript.vigor >= carddisplayscriptinSlot6.actualizarinformacióncostedeVigor())
        {
            PlayerStadisticsScript.vigor -= carddisplayscriptinSlot6.actualizarinformacióncostedeVigor();
            Debug.Log("restan " + PlayerStadisticsScript.vigor + " puntos de vigor");
            carddisplayscriptinSlot6.ejecutarpasivadelacartadevigor();

            activaryDesactivarCartaAlUsarlaSlot6();
            VigorDeckScript.SlotBool6 = false;
            button6.interactable = false;
        }
    }
}
