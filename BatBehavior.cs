using UnityEngine;

public class BatBehavior : MonoBehaviour
{
    //Properties
    public GameObject pointA;
    public GameObject pointB;
    public Rigidbody2D ecoll;

    public GameObject plyrPos;
    public float speed;
    private Transform CurPos;


    //Methods
    //First Frame
    void Start()
    {
        ecoll = GetComponent<Rigidbody2D>();
        CurPos = pointA.transform;
    }

    // Updates after first frame
    void Update()
    {
        //setting velocity
        Vector2 point = CurPos.position - transform.position;
        if(CurPos == pointA.transform)
        {
            ecoll.linearVelocity = new Vector2(-speed, 0);
        } else {
            ecoll.linearVelocity = new Vector2(speed, 0);
        }

        //Towards A
        if(Vector2.Distance(transform.position, CurPos.position) < 0.5f && CurPos == pointA.transform)
        {
            CurPos = pointB.transform;
        }
        //Towards point B
        if(Vector2.Distance(transform.position, CurPos.position) <0.2f && CurPos == pointB.transform)
        {
            CurPos = pointA.transform;
        }
    }
}
