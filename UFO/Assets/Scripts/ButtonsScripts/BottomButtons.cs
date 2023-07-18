using UnityEngine;
using UnityEngine.UI;

public class BottomButtons : MonoBehaviour, IActionCaller
{
    [SerializeField] private Slider KnobR;
    [SerializeField] private Slider KnobL;
    [SerializeField] private Slider BotSlider;
    
    [SerializeField] private bool _isPlusButton;
    
    public void Call()
    {
        if (_isPlusButton)
        {
            BotSlider.value += 0.1f * Time.fixedDeltaTime;
            KnobR.value -= 0.1f * Time.fixedDeltaTime;
            KnobL.value -= 0.1f * Time.fixedDeltaTime;
        }
        else
        {
            BotSlider.value -= 0.1f * Time.fixedDeltaTime;
            KnobR.value += 0.1f * Time.fixedDeltaTime;
            KnobL.value += 0.1f * Time.fixedDeltaTime;
        }
    }
}
