using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;
  
  private PlayerAnimations playerAnimations;

  private void Awake()
  {
    playerAnimations = GetComponent<PlayerAnimations>();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.H))
    {
      TakeDamage(1f);
    }
  }
  
  public void TakeDamage(float amount)
  {
    playerStats.Health -= amount;
    if (playerStats.Health <= 0f)
    {
      PlayerDead();
    }
  }

  private void PlayerDead()
  {
    playerAnimations.SetDeadAnimation();
  }
}
