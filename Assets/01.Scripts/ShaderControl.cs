using UnityEngine;
using UnityEngine.UI;

public class ShaderControl : MonoBehaviour
{
    public Material material;  // Reference to the material using the shader
    public string parameterName = "_YourParameterName";  // Replace with your actual parameter name

    public Slider slider;  // Reference to the UI slider

    void Start()
    {
        // Initialize the slider and register the callback
        slider.value = material.GetFloat(parameterName);
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Callback when the slider value changes
    void OnSliderValueChanged(float value)
    {
        // Set the shader parameter based on the slider value
        material.SetFloat(parameterName, value);
    }
}
