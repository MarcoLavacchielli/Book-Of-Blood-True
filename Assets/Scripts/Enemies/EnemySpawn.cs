using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public ParticleSystem ParticulasAmarillas;
    public Enemy enemyy;
    public Combat combatscript;
    public CombatPosition combatpositionscript;
    public List<GameObject> enemyGObj;
    public Transform enemytransf;
    public GameObject areaWhereTheEnemySpawns;
    public Player player;
    int enemiesreminder;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            enemiesreminder = 1;
            Enemy actualenemy = Instantiate(enemyGObj[Random.Range(0, enemyGObj.Count)], areaWhereTheEnemySpawns.transform.position, areaWhereTheEnemySpawns.transform.rotation).GetComponent<Enemy>();
            actualenemy.Setcombat(combatpositionscript);
            actualenemy.SetPlayer(player);
            combatscript.setenemy(actualenemy);
            Destroy(areaWhereTheEnemySpawns.gameObject);
            combatpositionscript.combatON();
        }
    }
}
