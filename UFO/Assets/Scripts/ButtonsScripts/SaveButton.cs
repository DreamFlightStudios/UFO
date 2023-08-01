using UnityEngine;

public class SaveButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private SaveData _saveData;
    
    public void Call() => _saveData.Save();
}
