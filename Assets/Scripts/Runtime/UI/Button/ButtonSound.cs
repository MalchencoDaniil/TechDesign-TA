 using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip buttonSoundClip;

    public void SelectedButton()
    {
        audioSource.PlayOneShot(buttonSoundClip);
    }
}