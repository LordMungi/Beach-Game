using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Scriptable Objects/LevelConfig")]
public class LevelConfig : ScriptableObject
{
    [field: SerializeField] public string conditionText { get; private set; }
    [field: SerializeField] public Item[] items { get; private set; }
    [field: SerializeField] public Tag correctTag { get; private set; }

}
