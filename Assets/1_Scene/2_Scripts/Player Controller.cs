using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 3f;
    Rigidbody2D rb2d;
    bool applyLeft = false;
    bool applyRight = false;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        applyLeft = Input.GetKey(KeyCode.LeftArrow);
        applyRight = Input.GetKey(KeyCode.RightArrow);
    }

    void FixedUpdate()
    {
        float torque = 0f;
        if (applyLeft)
        {
            torque += torqueAmount;
        }
        if (applyRight)
        {
            torque -= torqueAmount;
        }
        rb2d.AddTorque(torque);
    }
}
