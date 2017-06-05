using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomGen : MonoBehaviour {

    public List<Room> rooms = new List<Room>();
    public Room roomStudy;
    public Room roomHallway;
    public Room roomBathroom;
    public Room roomtrue = new Room(false, true, false, false, false, false, false, false, true, true, true, -4); //lit black
    public Room room2 = new Room(false, true, false, false, false, true, true, false, true, false, false, 0); // linoleum cube
    public Room room3 = new Room(false, false, false, false, true, true, false, true, false, false, false, 1); // walls cave inward

    // Use this for initialization
    void Start ()
    {
        //refresh player
        Room newRoom = GameObject.Instantiate<Room>(roomStudy); // random room in study place

        rooms.Add(newRoom);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
