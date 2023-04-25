using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyAldeano : Enemy
{
    public override void Enemyturn()
    {
        if (health <= 10 && health > 8)
        {
            BasicDamage();
        }
        else if (health > 4 && health <= 8)
        {
            HeavyDamage();
        }
        else if (health > 0 && health <= 4)
        {
            Regeneration();
        }
    }
    public void BasicDamage()
    {
        player.PlayerHealth -= 2;
        Debug.Log("El enemigo inflingio 2 de daño al jugador con un ataque basico");
    }
    public void HeavyDamage()
    {
        player.PlayerHealth -= 4;
        Debug.Log("El enemigo inflingio 4 de daño al jugador con un golpe pesado");
    }
    public void Regeneration()
    {
        health += 3;
        Debug.Log("El enemigo se curo 3 de vida");
    }
}