
using UnityEngine;

public class InputState : MonoBehaviour
{


    public bool IsActionButtonPressed;
    public bool IsStanding;
    public float StandingTreshhold;

    private Vector2 _absoluteVelocity;

    private Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        IsActionButtonPressed = Input.anyKeyDown;
    }

    private void FixedUpdate()
    {
        _absoluteVelocity = new Vector2(Mathf.Abs(_rigidbody2D.velocity.x), Mathf.Abs(_rigidbody2D.velocity.y));
        IsStanding = _absoluteVelocity.y < StandingTreshhold;
    }

}
