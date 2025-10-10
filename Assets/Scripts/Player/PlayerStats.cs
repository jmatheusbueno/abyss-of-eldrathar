using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
  [Header("Config")]
  public int Level;

  [Header("Health")]
  public float MaxHealth;
  public float Health;

  [Header("Mana")]
  public float MaxMana;
  public float Mana;

  [Header("Exp")]
  public float CurrentExp;
  public float NextLevelExp;
  public float InitialNextLevelExp;
  [Range(1f, 100f)] public float ExpMultiplier;

  public void ResetStats()
  {
    Health = MaxHealth;
    Mana = MaxMana;
    Level = 1;
    CurrentExp = 0;
    NextLevelExp = InitialNextLevelExp;
  }
}
