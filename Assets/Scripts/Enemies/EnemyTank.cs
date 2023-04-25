using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : Enemy
{
    public void EnemyTurn()
    {
        if (health <= 20 && health > 15)
        {
            BasicDamage();
        }
        else if (health > 7 && health <= 15)
        {
            HeavyDamage();
        }
        else if (health > 0 && health <= 7)
        {
            Regeneration();
        }
    }
    public void BasicDamage()
    {
        player.PlayerHealth -= 4;
        Debug.Log("El enemigo inflingio 4 de daño al jugador con un ataque basico");
    }
    public void HeavyDamage()
    {
        player.PlayerHealth -= 6;
        Debug.Log("El enemigo inflingio 6 de daño al jugador con un golpe pesado");
    }
    public void Regeneration()
    {
        health += 6;
        Debug.Log("El enemigo se curo 6 de vida");
    }
}