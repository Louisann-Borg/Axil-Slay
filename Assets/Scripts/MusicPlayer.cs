using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private static MusicPlayer musicPlayerInstance;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (musicPlayerInstance == null )
        {
            musicPlayerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
