using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerStats))]
public class PlayerStatsEditor : Editor
{
  private PlayerStats startsTarget => target as PlayerStats;

  public override void OnInspectorGUI()
  {
    base.OnInspectorGUI();
    if (GUILayout.Button("Reset Stats"))
    {
      startsTarget.ResetStats();
    }
  }
}
