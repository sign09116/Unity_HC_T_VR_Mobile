using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : ObjectBase
{
    [SerializeField] Rigidbody rig;
    protected override void Awake()
    {
        base.Awake();
        rig = GetComponent<Rigidbody>();

    }
    protected override IEnumerator Action()
    {
        yield return new WaitForSeconds(delay);
        aud.PlayOneShot(sound, volume);
        rig.useGravity = true;
       aud.enabled = false;
    
    }
}
