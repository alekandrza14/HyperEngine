using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] string triggerEvent;
    [SerializeField] GameObject spawnGameObject;
    bool done;
    private void Start()
    {
        if (VarSave.GetBool(triggerEvent) == true && !done)
        {
          //  VarSave.SetBool(triggerEvent, true);
            Instantiate(spawnGameObject);
            done = true;
        }
    }

    void Update()
    {
        if (triggerEvent == HyperBolicTrigger._CurentToNameTrigger && !done)
        {
            VarSave.SetBool(triggerEvent,true);
            Instantiate(spawnGameObject);
            done = true;
        }
    }
}
