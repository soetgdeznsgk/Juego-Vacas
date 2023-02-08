using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMiradorOceano : scriptCaminantes
{

    public override void Caminar()
    {
        //animacion.Play("down_walk");
        animacion.SetInteger("estado", 1);
        LeanTween.moveY(gameObject, -5f, 3f); // cambiar a -300f cuando acabe el testeo del cambio de animaciones
    }

}
