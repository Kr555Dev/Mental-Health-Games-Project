using UnityEngine;

public class OrientationLock : MonoBehaviour
{
    // Set this to true to lock the scene in portrait mode
    public bool lockToPortrait = false;

    // Set this to true to lock the scene in landscape mode
    public bool lockToLandscape = false;

    private void Start()
    {
        if (lockToPortrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        else if (lockToLandscape)
        {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}
