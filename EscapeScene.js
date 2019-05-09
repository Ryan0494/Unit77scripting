import UnityEngine.SceneManagement;

function OnTriggerEnter (col : Collider) {
	SceneManager.LoadScene (2);
}