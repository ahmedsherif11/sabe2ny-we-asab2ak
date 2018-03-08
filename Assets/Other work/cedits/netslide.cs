using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class netslide : MonoBehaviour {

	// Use this for initialization
	public void Go () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
