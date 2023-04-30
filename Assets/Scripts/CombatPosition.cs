using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class CombatPosition : MonoBehaviour
{
    //public EnemyAldeano enemyAldean;
    public ParticleSystem ParticulasAmarillas;
    public Enemy enemyy;
    public Combat combatscript;
    public List<GameObject> enemyGObj;
    public Transform enemytransf;
    public GameObject areaWhereTheEnemySpawns;
    public bool battlePosition = false;
    public Rigidbody playerRB;
    public Camera mainCamera;
    public Player player;
    public List<CinemachineVirtualCamera> cameras;
    public CinemachineVirtualCamera ActiveCamera;
    GameManager myGM;
    public MyCamera camerascript;
    int enemiesreminder;
    public Deck deckscript;
    public VigorDeck vigordeckscript;
    public VigorCardsDisplay ScriptVigorCardDisplaySlot4;
    public VigorCardsDisplay ScriptVigorCardDisplaySlot5;
    public VigorCardsDisplay ScriptVigorCardDisplaySlot6;

    public void Start()
    {
        myGM = GameManager.instance;
    }
 
    public void salircombate()
    {
       
        enemiesreminder--;
        if (enemiesreminder <= 0)
        {
            Cursor.lockState = CursorLockMode.Locked;
            SwitchCamera(cameras[0]);

            myGM.activeUI();
            battlePosition = false;
            //camerascript.enabled = true;
            player.enabled = true;
            playerRB.constraints = RigidbodyConstraints.None;
            playerRB.constraints = RigidbodyConstraints.FreezeRotation;
            ParticulasAmarillas.Stop();
            Debug.Log("Saliste del combate");
            //playerRB.freezeRotation = false;
            //player.enabled = true;
            camerascript.enabled = true;
        }
    }

    public void combatON()
    {
        
        Cursor.lockState = CursorLockMode.Confined;
        SwitchCamera(cameras[1]);
        battlePosition = true;
        camerascript.enabled = false;
        myGM.activeUI();
        player.enabled = false;
        Vector3 direccion = new Vector3(7, 0, 12);
        transform.LookAt(direccion);
        mainCamera.transform.LookAt(enemytransf);
        playerRB.constraints = RigidbodyConstraints.FreezeAll;
        //playerRB.freezeRotation = true;
        Debug.Log("Entraste en combate");
        deckscript.DrawCards();
        vigordeckscript.DrawCards();
        
    }
    public void SwitchCamera(CinemachineVirtualCamera camera)
    {
        camera.Priority = 10;
        ActiveCamera = camera;

        foreach (CinemachineVirtualCamera c in cameras)
        {
            if (c != camera && c.Priority != 0)
            {
                c.Priority = 0;
            }
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 9)
        {
            Destroy(other.gameObject);
            enemiesreminder = 1;
            Enemy actualenemy = Instantiate(enemyGObj[Random.Range(0, enemyGObj.Count)], areaWhereTheEnemySpawns.transform.position, areaWhereTheEnemySpawns.transform.rotation).GetComponent<Enemy>();
            actualenemy.Setcombat(this);
            actualenemy.SetPlayer(player);
            combatscript.setenemy(actualenemy);
            ScriptVigorCardDisplaySlot4.setenemy(actualenemy);
            ScriptVigorCardDisplaySlot5.setenemy(actualenemy);
            ScriptVigorCardDisplaySlot6.setenemy(actualenemy);
            Destroy(areaWhereTheEnemySpawns.gameObject);
            combatON();
        }
    }
}
