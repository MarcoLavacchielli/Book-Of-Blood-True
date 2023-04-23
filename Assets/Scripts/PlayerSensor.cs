using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Cinemachine;

public class PlayerSensor : MonoBehaviour
{
    [SerializeField] UnityEvent EV_OnPlayerEnter;
    [SerializeField] UnityEvent EV_OnPlayerExit;

    public float DoorContador;
    public CinemachineVirtualCamera DoorCamera;
    public Player player;
    public Collider playerColl;
    public Rigidbody playerRB;
    public List<CinemachineVirtualCamera> CamarasDoor;
    public CinemachineVirtualCamera ActiveCamera;

    

    private void OnTriggerEnter(Collider other)
    {
        print("La puerta se abrio");
        if (IsPlayer(other))
        {
            SwitchCameraDoor(CamarasDoor[1]);
            player.enabled = false;
            playerRB.constraints = RigidbodyConstraints.FreezeAll;
            EV_OnPlayerEnter.Invoke();
            playerColl.enabled = false;
            StartCoroutine(CameraTransation());
        }
    }

    
   
    public void SwitchCameraDoor(CinemachineVirtualCamera Door)
    {
        Door.Priority = 10;
        ActiveCamera = Door;

        foreach (CinemachineVirtualCamera c in CamarasDoor)
        {
            if (c != Door && c.Priority != 0)
            {
                c.Priority = 0;
            }
        }


    }
    bool IsPlayer(Collider col)
    {
        Player c = col.GetComponent<Player>();
        if (c == GameManager.instance.Player())
        {
            return true;
        }
        return false;
    }

    IEnumerator CameraTransation()
    {
        yield return new WaitForSeconds(DoorContador);

        
        player.enabled = true;
        playerRB.constraints = RigidbodyConstraints.None;
        playerRB.constraints = RigidbodyConstraints.FreezeRotation;
        SwitchCameraDoor(CamarasDoor[0]);
        EV_OnPlayerExit.Invoke();

        yield return null;
    }
}
