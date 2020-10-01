using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
    public Manufacturer manufacturer;
    public int magazineSize;
    public int damage;
    public double rof;
    public int accuracy;
    public int range;

    public AnimationClip reloadAnim;

    public virtual void Fire()
    {

    }

    public virtual void Reload()
    {

    }

}
