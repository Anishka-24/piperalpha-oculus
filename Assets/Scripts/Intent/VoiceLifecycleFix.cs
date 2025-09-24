using UnityEngine;
using UnityEngine.Android;

public class VoiceLifecycleFix : MonoBehaviour
{
    void Awake()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
    }

    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus && !Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
        }
    }
}
