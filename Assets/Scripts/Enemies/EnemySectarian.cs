using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySectarian : Enemy
{
    public override void Start()
    {
        base.Start();
    }
    public void EnemyTurn()
    {
        if (health <= 15 && health > 11)
        {
            BasicDamage();
        }
        else if (health > 6 && health <= 11)
        {
            HeavyDamage();
        }
        else if (health > 0 && health <= 6)
        {
            Regeneration();
        }
    }
    public void BasicDamage()
    {
        player.PlayerHealth -= 3;
        Debug.Log("El enemigo inflingio 3 de daño al jugador con un ataque basico");
    }
    public void HeavyDamage()
    {
        player.PlayerHealth -= 5;
        Debug.Log("El enemigo inflingio 5 de daño al jugador con un golpe pesado");
    }
    public void Regeneration()
    {
        health += 5;
        Debug.Log("El enemigo se curo 5 de vida");
    }
}