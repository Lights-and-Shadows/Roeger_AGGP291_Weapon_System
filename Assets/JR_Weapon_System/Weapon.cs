using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public Manufacturer manufacturer;
    public int magazineSize;
    public float damage;
    public float rof;
    public float accuracy;
    public float range;

    public AnimationClip reloadAnim;

    public virtual void Fire()
    {

    }

    public virtual void Reload()
    {

    }

}
