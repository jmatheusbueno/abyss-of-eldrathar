using UnityEngine;

public class PlayerExp : MonoBehaviour
{
  [Header("Config")]
  [SerializeField] private PlayerStats playerStats;

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.X))
    {
      AddExp(300f);
    }
  }

  private void AddExp(float amount)
  {
    playerStats.CurrentExp += amount;
    while (playerStats.CurrentExp >= playerStats.NextLevelExp)
    {
      playerStats.CurrentExp -= playerStats.NextLevelExp;
      NextLevel();
    }
  }

  private void NextLevel()
  {
    playerStats.Level++;
    float currentExpRequired = playerStats.NextLevelExp;
    float newNextLevelExp =
      Mathf.Round(currentExpRequired + playerStats.NextLevelExp * (playerStats.ExpMultiplier / 100f));
    playerStats.NextLevelExp = newNextLevelExp;
    Debug.Log($"Level Up! New Level: {playerStats.Level}, Next Level Exp: {playerStats.NextLevelExp}");
  }
}