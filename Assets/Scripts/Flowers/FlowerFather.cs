using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlowerFather : MonoBehaviour, IDragable, IFusionable, IGetVariables
{
    //public string message;

    //public int[,] values = new int[2, 2];

    /*
    int Intent;
    int Formality;
    int MultiplierIntent;
    int MultiplierFormality;
    string Subject;
    */

    public int Intent { get; private set; }
    public int Formality { get; private set; }
    public int MultiplierIntent { get; private set; }
    public int MultiplierFormality { get; private set; }
    public string Subject { get; private set; }




    private Vector3 _lastposition;

   

    virtual public void Start()
    {
        _lastposition = transform.position;

        Subject = "Faith";

        MultiplierFormality = 5;
        MultiplierIntent = 4;
        Intent = 10;
        Formality = 9;
    }

    public GameObject ObjectsToBeDraged(ref Vector3 positions)
    {
        positions = transform.position;
        return gameObject;
    }

    public void Move(Vector3 position)
    {
        throw new System.NotImplementedException();
    }

    public bool WasUsed()
    {
        throw new System.NotImplementedException();
    }

    //codigo anterior anterior para devolver objeto
    /*
    private void OnCollisionEnter(Collision collision)
    {
        
        // Si el objeto seleccionado toca un collider no deseado, se establece su posici�n en la �ltima posici�n almacenada
        if (collision.collider.CompareTag("dontzone"))
        {
            
            transform.position = _lastposition;
        }
    }
    */

    //Codigo anterior para devolver objeto
    /*
    private void OnTriggerExit(Collider other)
    {
       
        if (other.CompareTag("dontzone"))
        {
            print("se fue");
            transform.position = _lastposition;
        }
    }
    */





    int IGetVariables.Intent { get { return Intent; } }
    int IGetVariables.Formality { get { return Formality; } }
    int IGetVariables.MultiplierIntent { get { return MultiplierIntent; } }
    int IGetVariables.MultiplierFormality { get { return MultiplierFormality; } }
    string IGetVariables.Subject { get { return Subject; } }

    public bool canBeDragged { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
}