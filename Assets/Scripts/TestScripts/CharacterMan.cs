using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMan : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField]
    UIBroker uiBroker;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    //private float jumpHeight = 1.0f;
    //private float gravityValue = -9.81f;

    private bool CharacterTest = false;
    public GameObject joyStick;

    private CharacterInputControls characterInputControls;
    void Awake()
    {
        characterInputControls = new CharacterInputControls();
    }
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void OnEnable()
    {
        characterInputControls.Enable();
    }
    void OnDisable()
    {
        characterInputControls.Disable();
    }


    // Update is called once per frame
    void Update()
    {
        if (!CharacterTest) return;
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector2 move2D = characterInputControls.Character.Move.ReadValue<Vector2>();
        Vector3 move3D = new Vector3(move2D.x, 0, move2D.y);
        controller.Move(move3D * Time.deltaTime * playerSpeed);

        if (move3D != Vector3.zero)
        {
            gameObject.transform.forward = move3D;
        }

        /*
        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }
        */
        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);
    }

}

