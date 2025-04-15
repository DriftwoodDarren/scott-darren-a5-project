using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    [SerializeField] private AudioSource _cannonShot;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            GetComponent <AudioSource>().Play();
        }
    }
}
