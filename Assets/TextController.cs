using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, sheets_2, lock_1, mirror_2, freedom, lose};
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
		} else if (myState == States.mirror_2) {
			state_cell_mirror_2 ();
		}  else if (myState == States.sheets_2) {
			state_sheets_2 ();
		} else if (myState == States.freedom) {
			state_freedom ();
		} else if (myState == States.lose){
			state_lose ();
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
					"back.  You notice that one of the cracks is a little wider than it was before " +
					"and you are able to work a piece free!  Maybe you can work the lock " +
					"loose with it (L), but you've been stuck here such a long time ... (S)";
		if (Input.GetKeyDown("l")){
			myState = States.mirror_2;
		} else if (Input.GetKeyDown ("s")){
			myState = States.cell_mirror;
		}
	}
	void state_sheets_0 () {
		text.text = "You begin tearing the sheet into a series of strips.  Then you tie them together " +
					"and it looks like you have a halfway decent little rope.  You tie one end to the " +
					"rusty cell door.  Do you have enough strenth to pull a bar out and squeeze through? (P) " +
					"It could work, but you'd probably just get caught by the guard... (S)";
		if (Input.GetKeyDown("p")){
			myState = States.sheets_1;
		} else if (Input.GetKeyDown ("s")){
			myState = States.sheets_2;
		}
	}
	void state_lock_0 () {
		text.text = "You limp over to the cell door and begin clawing at the lock furiously, " +
				"it's as if you've become an animal, knawing with your teeth on the glowing " +
				"steel slab.  Your teeth crack as try desperately to break it free.  The sound of " +
				"footsteps do not even register in your animal heart.  The guard smacks you " +
				"with a baton through the bars and you fall backwards.  He opens the cell door. " +
				"This is your chance, you could attack him (A).  But you are so thin and weak... (C)";
		if (Input.GetKeyDown("a")){
			myState = States.lose;
		} else if (Input.GetKeyDown ("c")){
			myState = States.lock_1;
		}
	}
	void state_cell_mirror_2 () {
		text.text = "You hack and poke at the lock for hours, until you've lost all track of time. " +
					"It looks the same, shiny and new and unbreakable as ever.  Before you realize "+
					"how much noise you're making, the footsteps of the guard come pounding " +
					"down the hall outside... (Space bar)";
		if (Input.GetKeyDown("space")){
			myState = States.lose;
		}
	}
	void state_cell_mirror () {
		text.text = "You slash across your wrist in one quick motion.  It hurts so much, but already " +
					"you are feeling drowsy.  You sit down, and watch as the blood pools around your hands " +
					"and everything begins to go dark. (Space Bar)";
		if (Input.GetKeyDown("space")){
			myState = States.freedom;
		}
	}
	void state_sheets_1 () {
		text.text = "You pull and pull, but you cannot get the bar to budge. You keep pulling " +
					"with a sick desperation that will not be quenched.  Before you realize "+
					"how much noise you're making, the footsteps of the guard come pounding " +
					"down the hall outside... (Space bar)";
		if (Input.GetKeyDown("space")){
			myState = States.lose;
		}
	}
	void state_lock_1 () {
		text.text = "You cower in the corner, too afraid to look up.  You don't hear anything, " +
					"and finally after forever, you look up.  The cell is open.  The guard " +
					"is gone.  (Space bar)";
		if (Input.GetKeyDown("space")){
			myState = States.freedom;
		}
	}
	void state_sheets_2 () {
		text.text = "You wrap the end of the sheet around your neck and slide down, back against the bars. " +
					"It tightens and you cannot breath.  You haven't the energy to fight it.  The world goes " +
					"dark and you claw frantically at your neck, but what little strength you had is gone. " +
					"(Space bar)";
		if (Input.GetKeyDown("space")){
			myState = States.freedom;
		}
	}
	void state_freedom () {
		text.text = "You're free at last...";
		if (Input.GetKeyDown("space")){
			myState = States.cell;
		}
	}
	void state_lose () {
		text.text = "The guard has disgust written on his face.  He shakes his head and raises " +
					"a pistol.  You're too tired to be afraid.  Just so tired. Do you hear the shot? " +
					"Do you feel any pain?  Did any of it really matter?";
		if (Input.GetKeyDown("space")){
			myState = States.cell;
		}
	}
}
