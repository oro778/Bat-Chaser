using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    //Properties
    //Player movement
    public Rigidbody2D prb;
    public float PlayerSpeed = 5f;
    public float horizontalMovement;
    public float verticalMovement;


   // Instantianator
    public GameObject prefab;
    public Transform parent;
    GameObject clone;


    //methods
    // Updates after first frame
    void Update()
    {
        //updating player movement horizontally
        Vector2 newVelocity = new Vector2(horizontalMovement * PlayerSpeed, verticalMovement * PlayerSpeed);
        prb.linearVelocity = newVelocity;
    }

    //Make so the player object moves on its own
    public void Move(InputAction.CallbackContext context) 
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
        verticalMovement = context.ReadValue<Vector2>().y;
    }

    //spawns flashlight and its clones
    public void InstantiateObject(InputAction.CallbackContext context)
    {
        for(int i = 0; i < 1; i++){
           clone = Instantiate(prefab, new Vector2(parent.position.x, parent.position.y + 1), Quaternion.identity);
           Destroy(clone, 0.15f);
        }
    }
}