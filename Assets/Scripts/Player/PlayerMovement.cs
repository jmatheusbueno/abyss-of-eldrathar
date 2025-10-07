using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  [Header("Movement Settings")]
  [SerializeField] private float speed = 5f;

  private Player player;
  private PlayerActions actions;
  private PlayerAnimations playerAnimations;
  private Rigidbody2D rb2D;
  private Vector2 moveDirection;

  private void Awake()
  {
    player = GetComponent<Player>();
    actions = new PlayerActions();
    playerAnimations = GetComponent<PlayerAnimations>();
    rb2D = GetComponent<Rigidbody2D>();
  }

  void Update()
  {
    ReadMovement();
  }

  private void FixedUpdate()
  {
    Move();
  }

  private void Move()
  {
    if (player.PlayerStats.Health <= 0f) return;
    rb2D.MovePosition(rb2D.position + moveDirection * (speed * Time.fixedDeltaTime));
  }

  private void ReadMovement()
  {
    moveDirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
    if (moveDirection == Vector2.zero)
    {
      playerAnimations.SetMoveBoolTransition(false);
      return;
    }

    playerAnimations.SetMoveBoolTransition(true);
    playerAnimations.SetMoveAnimation(moveDirection);
  }

  private void OnEnable()
  {
    actions.Enable();
  }

  private void OnDisable()
  {
    actions.Disable();
  }
}
