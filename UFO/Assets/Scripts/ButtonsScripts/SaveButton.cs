using UnityEngine;

public class SaveButton : MonoBehaviour, IActionCaller
{
    [SerializeField] private DataService _dataService;
    
    public void Call() => _dataService.SaveData();
}
