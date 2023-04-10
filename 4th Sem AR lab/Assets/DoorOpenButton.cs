using UnityEngine;

public class DoorOpenButton : MonoBehaviour
{
    public Animator doorAnimator;
    public AudioSource doorOpenSound;
    public AudioSource doorCloseSound;

    public void OnButtonClicked()
    {
        if (doorAnimator.GetBool("isOpen"))
        {
            doorAnimator.SetBool("isOpen", false);
            doorCloseSound.Play();
        }
        else
        {
            doorAnimator.SetBool("isOpen", true);
            doorOpenSound.Play();
        }
    }
}
