using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;

  public PlayerStats PlayerStats => playerStats;

  private PlayerAnimations playerAnimations;

  public void ResetPlayer()
  {
    playerStats.ResetStats();
    playerAnimations.SetReviveAnimation();
  }

  private void Awake()
  {
    playerAnimations = GetComponent<PlayerAnimations>();
    playerAnimations.SetReviveAnimation();
  }
}