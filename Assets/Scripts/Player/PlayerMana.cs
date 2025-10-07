using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.M))
    {
      UseMana(1f);
    }
  }

  public void UseMana(float amount)
  {
    if (playerStats.Mana >= amount)
    {
      playerStats.Mana = Mathf.Max(playerStats.Mana -= amount, 0f);
    }
  }
}