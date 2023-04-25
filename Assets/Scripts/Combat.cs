using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combat : MonoBehaviour
{
    private Player player;
    public ParticleSystem damageParticles;
    public ParticleSystem damageParticlesSlot2;
    public ParticleSystem damageParticlesSlot3;
    //public EnemyAldeano enemyaldean;
    public Enemy enemyy;
    private CombatPosition combat;
    private bool combatmode = false;
    int playercontador;
    int contador;
    public Deck deckscript;
    public CardDisplay carddisplayscriptinSlot1;
    public CardDisplay carddisplayscriptinSlot2;
    public CardDisplay carddisplayscriptinSlot3;
    public Image cardOrange1;
    public Image cardOrange2;
    public Image cardOrange3;
    public Button button1;
    public Button button2;
    public Button button3;
    private bool cartafueUsada = true;
    private bool cartafueUsada2 = true;
    private bool cartafueUsada3 = true;
    private bool enemyattack = false;

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
    public void combatmodeON()
    {
        combatmode = true;
    }
    public void Enemydealsdamage()
    {
        if (Input.GetKeyDown(KeyCode.Space) && enemyattack == true)
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            enemyy.Enemyturn();
            //contador = 0;
            playercontador = 0;
            deckscript.DrawCards();
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
            damageParticles.Play();
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
            damageParticlesSlot2.Play();
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
            damageParticlesSlot3.Play();
            Debug.Log("El player inflingio " + carddmgtrue + (" de daño"));
            Debug.Log("Al enemigo le queda " + enemyy.health + " de vida ");
            //contador = 1;
            enemyattack = true;
            playercontador = 1;
            activaryDesactivarCartaAlUsarlaSlot3();
            button3.interactable = false;
        }
    }
}
