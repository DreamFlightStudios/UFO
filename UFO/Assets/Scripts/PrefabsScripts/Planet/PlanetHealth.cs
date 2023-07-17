using UnityEngine;

public class PlanetHealth : MonoBehaviour
{
    [SerializeField] private int _live = 10;

    public bool TakeDamage()
    {
        _live--;
        if (_live > 0) return false;
        
        gameObject.SetActive(false);
        return true;
    }
}