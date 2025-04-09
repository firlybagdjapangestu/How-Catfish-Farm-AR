using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CatfishPanelUI : MonoBehaviour
{
    [SerializeField] private StepSO stepSO;
    [SerializeField] private TextMeshProUGUI stepName;
    [SerializeField] private Image stepImage;
    [SerializeField] private AudioClip stepSound;
    [SerializeField] private Button catfishSoundButton;
    [SerializeField] private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stepName.text = stepSO.stepName;
        stepImage.sprite = stepSO.stepSprite;
        stepSound = stepSO.stepSound;
    }

    void PlaySound()
    {
        if (audioSource != null)
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
            else if (stepSound != null)
            {
                audioSource.clip = stepSound;
                audioSource.Play();
            }
        }
    }
}
