using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
		text.text = "Space bar to begin...";
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell){
			state_cell ();
		} else if (myState == States.mirror) {
			state_mirror ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		} else if (myState == States.lock_0) {
			state_lock_0 ();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror ();
		} else if (myState == States.sheets_1) {
			state_sheets_1 ();
		} else if (myState == States.lock_1) {
			state_lock_1 ();
		} else if (myState == States.freedom) {
			state_freedom ();
		}
	
	}
	
	void state_cell () {
		text.text = "You awake in a damp, colorless pit of a cell, " +
					"more fit for an animal than a human.  A broken mirror (M) " +
					"does little to convince you that this place was ever " +
					"anything more beautiful.  You curl up on the floor, wrapping " + 
					"yourself in a thin sheet (S) that is little more than a rag and stare " +
					"at the only thing that isn't falling apart, a shiny steel lock (L) on your cell door.";
		if (Input.GetKeyDown("m")){
			myState = States.mirror;
		} else if (Input.GetKeyDown ("s")){
			myState = States.sheets_0;
		} else if (Input.GetKeyDown("l")){
			myState = States.lock_0;
		}
	}
	void state_mirror () {
		text.text = "Looking in the mirror, you do not recognize the creature that stares " +
					"back.  "
	}
	void state_sheets_0 () {
		
	}
	void state_lock_0 () {
		
	}
	void state_cell_mirror () {
		
	}
	void state_sheets_1 () {
		
	}
	void state_lock_1 () {
		
	}
	void state_freedom () {
	
	}
}
