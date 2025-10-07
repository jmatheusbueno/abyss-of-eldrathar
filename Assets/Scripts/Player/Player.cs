using UnityEngine;

public class Player : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;

  public PlayerStats PlayerStats => playerStats;

  private void Awake()
  {

  }
}