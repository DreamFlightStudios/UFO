using UnityEngine;
using UnityEngine.UI;

public class BottomPlusButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private Slider KnobR;
    [SerializeField] private Slider KnobL;

    [SerializeField] private Slider BotSlider;
    public void Call()
    {
        BotSlider.value += 0.1f * Time.fixedDeltaTime;
        KnobR.value -= 0.1f * Time.fixedDeltaTime;
        KnobL.value -= 0.1f * Time.fixedDeltaTime;
    }
}
