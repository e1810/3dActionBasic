using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GroundChecker : MonoBehaviour
{
    public UnityEvent onEnterGround;
    public UnityEvent onExitGround;
    private int enterNum = 0;

    private void OnTriggerEnter(Collider collision)
    {
        enterNum++;
        onEnterGround.Invoke();
    }

    private void OnTriggerExit(Collider collision)
    {
        enterNum--;
        if (enterNum <= 0)
        {
            onExitGround.Invoke();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
