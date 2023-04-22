using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryObjectsActions : MonoBehaviour
{
    private int WhispersCount;
    public int KeyForTheBlackDoor;
    
    public Camera mainCamera;
    [SerializeField] LayerMask doormask;
    private void Update()
    {


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 6)
        {
            WhispersCount += 1;
            Destroy(other.gameObject);
            if (WhispersCount == 1)
            {
                Debug.Log("vas por buen camino Oswald, puedo sentirlo. ahora recupera mi libro y dale buen uso a mis cartas, o conocerás las consecuencias");
            }
            else if (WhispersCount == 2)
            {
                Debug.Log("escucha atentamente Oswald, el combate está cerca. tienes dos mazos. uno de ellos me alimentará de tu vigor para darte" +
                    " gran parte de mi poder y pueden poner el combate a tu favor si lo usas con ingenio. Mientras más luches tu vigor aumentará" +
                    ", y por ende, más podré consumir de ti, así que trata de no morirte tan rápido");
            }
            else if (WhispersCount == 3)
            {
                Debug.Log("el mazo que no consume tu vigor son sólo un suplemento, pero pueden ser muy oportunas. Te las di por pena ");
            }
            else if (WhispersCount == 4)
            {
                Debug.Log("¿así usas mis cartas? eres decepcionante");
            }
        }
        if (other.gameObject.layer == 8)
        {
            //llave
            KeyForTheBlackDoor = 1;
            Destroy(other.gameObject);
        }
        if (other.gameObject.layer == 7)
        {
           //puerta
            if (KeyForTheBlackDoor==1)
            {
                Destroy(other.gameObject);
            }

        }
    }    /*private void Update()
    {
        if(combatMode == true)
        {
            fightStarts();
        }
        if (aldeano.health <= 0)
        {
            fightIsOver();
        }
        if (isfrozen == true)
        {
           
        }
        player2.frozee();
    }

    public void isFreeze()
    {
        isfrozen = true;
    }
    public void fightStarts()
    {
        transform.LookAt(enemy.transform);
        mainCameraa.transform.LookAt(enemy.transform);
        isFreeze();
        //transicion de cámara

    }
    public void fightIsOver()
    {
        isfrozen = false;
        //transicion de cámara
    }*/
}
