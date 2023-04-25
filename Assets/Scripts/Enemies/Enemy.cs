using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player player;
    public Combat combat;
    CombatPosition _combatposition;
    public int health;
    public string tipodeenemigo;
    public virtual void Start()
    {
        Enemyapears();
    }
    void Enemyapears()
    {
        Debug.Log("Aparecio un " + tipodeenemigo);
    }
    private void Update()
    {
        EnemyDies();
    }
    public virtual void Enemyturn()
    {

    }
    
    public void Setcombat(CombatPosition combatPosition)
    {
        _combatposition = combatPosition;
    }
    public void SetPlayer(Player playerreference)
    {
        player = playerreference;
    }
    public virtual void EnemyDies()
    {
        if (health <= 0)
        {
            _combatposition.salircombate();
            Destroy(gameObject);
        }
    }
}
