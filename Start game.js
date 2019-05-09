import UnityEngine.SceneManagement;



function Update () {
		if (Input.GetButtonDown("Action")) {
	SceneManager.LoadScene (1);
	}
}	