using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poison : Skill
{
    public override string skillName => "Poison";

    public override void Activate()
    {
        Debug.Log("Activando habilidad de veneno.");
    }
}
