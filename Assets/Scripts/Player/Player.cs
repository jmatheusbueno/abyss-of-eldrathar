using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;

  public PlayerStats PlayerStats => playerStats;

  private PlayerAnimations playerAnimations;

  private void Awake()
  {
    playerAnimations = GetComponent<PlayerAnimations>();
    
    if (playerStats.Health <= 0)
    {
      playerAnimations.SetDeadAnimation();
    }
  }
}