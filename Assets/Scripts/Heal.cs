using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Skill
{
    public override string skillName => "Heal";

    public override void Activate()
    {
        Debug.Log("Activando habilidad de curaci�n.");
    }
}
