public class LightingController : MonoBehaviour
{
    public Light directionalLight;
    public Color[] levelColors;
    private int currentLevel = 0;

    public void UpdateLighting(int levelIndex)
    {
        currentLevel = levelIndex % levelColors.Length;
        directionalLight.color = levelColors[currentLevel];
        RenderSettings.ambientLight = levelColors[currentLevel];
    }
}
