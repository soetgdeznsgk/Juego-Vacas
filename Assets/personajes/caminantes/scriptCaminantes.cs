using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCaminantes : NPCs
{
    public string[] discursoDelPersonajeTrasScript;

    public virtual void Caminar()
    {
        // acá va cualquier script de caminado que tenga un personaje
    }


    public override void Interaccion() 
    {
        base.Interaccion();     

        if (!jugador.controlMenu.menuAbierto && haInteractuado) 
        {
            Caminar();  // ésto supone que la pauta entre el estado 1 y el estado 2 de un personaje, sea el haber hablado con ellos, lo cual puede no ser el caso
            discursoDelPersonaje = discursoDelPersonajeTrasScript;
        }

        // faltan implementar los cambios al personaje después del cambio de estado
    }
}
