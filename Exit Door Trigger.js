var ObjectiveComplete : GameObject;

function OnTriggerEnter (col : Collider) {
	ObjectiveComplete.SetActive(true);

}