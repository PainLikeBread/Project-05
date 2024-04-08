using UnityEngine;

public class FootstepAudio : MonoBehaviour
{
    public AudioSource audioSource;

    void Update()
    {
        // Check for movement input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
       
        if (Mathf.Abs(moveHorizontal) > 0.1f || Mathf.Abs(moveVertical) > 0.1f)
        {
            
            if (!audioSource.isPlaying)
            {
    
                audioSource.Play();
            }
        }
        else
        {
            audioSource.Stop();
        }
    }
}