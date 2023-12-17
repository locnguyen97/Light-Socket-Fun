using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> listSlot;
    [SerializeField] private Transform parentListSlot;
    
    public List<GameObject> listTarget;
    public Transform parentListTarget;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        
        foreach (Transform tr in parentListSlot)
        {
            listSlot.Add(tr.gameObject);
        }
        foreach (Transform tr in parentListTarget)
        {
            listTarget.Add(tr.gameObject);
        }
    }

    public void RemoveObject(GameObject obj)
    {
        listSlot.Remove(obj);
        if (listSlot.Count == 0)
        {
            GameManager.Instance.CheckLevelUp();
            canCheck = false;
        }
    }
    public void RemoveTarget(GameObject obj)
    {
        listTarget.Remove(obj);
    }
}
