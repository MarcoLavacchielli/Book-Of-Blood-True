using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    public Player player;
    public Combat combat;
    CombatPosition _combatposition;
    public int health;
    private void Start()
    {
        /*EnemyAldeano enemyaldeano = new EnemyAldeano();
        enemyaldeano.health = 10;
        enemyaldeano.Enemyturn();

        EnemySectarian enemysectarian = new EnemySectarian();
        enemysectarian.health = 15;
        enemysectarian.EnemyTurn();

        EnemyTank enemyTank = new EnemyTank();
        enemyTank.health = 20;
        enemyTank.EnemyTurn();*/

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
