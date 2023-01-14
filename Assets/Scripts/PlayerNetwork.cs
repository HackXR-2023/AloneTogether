using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    public Behaviour[] behaviourToDisable;

    private void Update()
    {
        if (!IsOwner)
        {
            foreach (Behaviour behaviour in behaviourToDisable)
            {
                behaviour.enabled = false;
            }
        }
        else
        {
            foreach (Behaviour behaviour in behaviourToDisable)
            {
                behaviour.enabled = true;
            }
        }
    }

}
