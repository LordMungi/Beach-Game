using UnityEngine;

[CreateAssetMenu(fileName = "LevelConfig", menuName = "Scriptable Objects/LevelConfig")]
public class LevelConfig : ScriptableObject
{
    [field: SerializeField] public Item[] items { get; private set; }
    [field: SerializeField] public Tag correctTag;

}
