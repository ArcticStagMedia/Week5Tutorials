using UnityEngine;
using System.Collections;

public class PlayerFirst
{

    private int experience;

    public int Experience
    {

        //get accesor method
        get
        {
            return experience;
        }

        //set accessor method
        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }

        set
        {
            experience = value * 1000;
        }
    }

    public int Health {get; set;}
}
