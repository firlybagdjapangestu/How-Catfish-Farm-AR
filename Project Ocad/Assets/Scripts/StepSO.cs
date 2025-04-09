using UnityEngine;

[CreateAssetMenu(fileName = "StepSO", menuName = "Scriptable Objects/StepSO")]
public class StepSO : ScriptableObject
{
    public string stepName;
    [TextArea(3, 10)]
    public string stepDescription;
    public Sprite stepSprite;
    public AudioClip stepSound;
    public GameObject stepPrefab;
}
