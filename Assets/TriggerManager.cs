using UnityEngine;
using UnityEngine.Playables;

public class TriggerManager : MonoBehaviour
{
    public PlayableDirector playableDirector;

    void OnTriggerEnter(Collider other)
    {
        playableDirector.Play();
    }
}
