using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadAdditive : MonoBehaviour {

	public void loadAddOnClick(int level)
    {
       Application.LoadLevelAdditive(level);
       
    }
}
