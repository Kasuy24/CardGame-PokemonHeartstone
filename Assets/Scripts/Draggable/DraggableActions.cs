using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DraggableActions : MonoBehaviour {

    //abstract class: Interficies
    public abstract void OnStartDrag();
    
    public abstract void OnEndDrag();

    public abstract void OnDraggingInUpdate();

    public virtual bool CanDrag
    {
        get
        {
            return true;
        }
    }

    protected abstract bool DragSuccessful();
}
