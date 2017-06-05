using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    [SerializeField]
    public bool plant;
    public bool manmade;
    public bool water;
    public bool dark;
    public bool animal;
    new public bool light;
    public bool items;

    public bool north;
    public bool east;
    public bool south;
    public bool west;

    public int sanity;
    public bool isref;
    public bool normal;

    public Room(bool pPlant, bool pManmade, bool pWater, bool pDark, bool pAnimal, bool pLight, bool pItems, bool North, bool East, bool South, bool West, int sane, bool reference = false, bool norm = true)
    {
        plant = pPlant;
        manmade = pManmade;
        water = pWater;
        dark = pDark;
        animal = pAnimal;
        light = pLight;
        items = pItems;
        north = North;
        east = East;
        south = South;
        west = West;

        sanity = sane;
        isref = reference;
        normal = norm;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
