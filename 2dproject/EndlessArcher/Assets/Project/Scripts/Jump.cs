using UnityEngine;

public class Jump : MonoBehaviour {

    public float JumpSpeed;

    private InputState _inputState;
    private Rigidbody2D _rigidBody2D;

    private void Awake() {

        _inputState = GetComponent<InputState>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_inputState.IsActionButtonPressed && _inputState.IsStanding) {
            _rigidBody2D.velocity = new Vector2(0, JumpSpeed);
        }
    }

}
