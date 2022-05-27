using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("JU TPS/UI/FPS Counter")]
public class FPSCounter : MonoBehaviour
{
    [SerializeField] private Text fpsText;
    public float refreshRate;
    void Start()
    {
        InvokeRepeating(nameof(UpdateFrameRateOnScreen), 0, refreshRate);
    }
    void UpdateFrameRateOnScreen()
    {
        if (fpsText == null) return;
        fpsText.text = FrameRate() + "FPS";
        fpsText.color = Color.Lerp(Color.red, Color.green, FrameRate() / 60f);
    }
    private int FrameRate()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        int fps = (int)(1f / Time.unscaledDeltaTime);
        return fps;
    }
}
