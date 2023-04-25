using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
     public Vector3 move;
     Rigidbody myRig;
     [SerializeField] float speed=200;

     private void Awake()
     {
         myRig = GetComponent<Rigidbody>();
     }
     float yfall;
     private void FixedUpdate()
     {
         yfall=myRig.velocity.y;
         move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

         myRig.velocity = move * Time.deltaTime*speed;
         //control de caida
         myRig.velocity = new Vector3(myRig.velocity.x,yfall,myRig.velocity.z);


     }
     void Update()
     {

     }
    */

    public float horizonalMove;
    public float verticalMove;
    private Vector3 playerInput;
    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;
    private Vector3 movePLayer;
    //CombatPosition _combatposition;

    public CharacterController player;
    public float playerspeed;
    public int PlayerHealth = 30;
    public int vigorPoints = 40;
    public float gravity = 9.8f;
    
    private void Start()
    {
        player = GetComponent<CharacterController>();
    }
    private void Update()
    {
        horizonalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        //PlayerDies();
        playerInput = new Vector3(horizonalMove, 0, verticalMove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePLayer = playerInput.x * camRight + playerInput.z * camForward;

        player.transform.LookAt(player.transform.position + movePLayer);

        setGravity();

        player.Move(movePLayer * playerspeed * Time.deltaTime);
    }

    
    
    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
    void setGravity()
    {
        movePLayer.y = -gravity * Time.deltaTime;

    }
    /*public void PlayerDies()
    {
        if (PlayerHealth <= 0)
        {
            _combatposition.salircombate();
            Destroy(gameObject);
            PlayerHealth = 30;
        }
    }*/

}
