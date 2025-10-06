using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
  [SerializeField] private PlayerStats playerStats;

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
    if (playerStats.Health <= 0)
    {
      PlayerDead();
    }
  }

  private void PlayerDead()
  {
    Debug.Log("Player Died");
  }
}
