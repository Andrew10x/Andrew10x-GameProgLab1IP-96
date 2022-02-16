using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float runSpeed = 220f;
    public float strafeSpeed = 380f;
    public float jumpForce = 15f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    void Start()
    {
        Debug.Log("Запуск скрипта");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            strafeLeft = true;
        }
        else
        {
            strafeLeft = false;
        }

        if (Input.GetKey("d"))
        {
            strafeRight = true;
        }
        else
        {
            strafeRight = false;
        }

        if (Input.GetKey("space"))
        {
            doJump = true;
        }
        else
        {
            doJump = false;
        }
        FixedUpdate();
    }

    void FixedUpdate()
    {
        //rb.AddForce(0, 0, runSpeed * Time.deltaTime);
        if (strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.Force);
        }
        if (strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.Force);
        }
    }
}

