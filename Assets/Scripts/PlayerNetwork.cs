using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    public Component[] componentsToDelete;

    private void Awake()
    {
        if (!IsOwner)
        {
            foreach (Component component in componentsToDelete)
            {
                Destroy(component);
            }
        }
    }
}
