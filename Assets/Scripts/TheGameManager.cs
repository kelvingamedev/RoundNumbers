using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TheGameManager : MonoBehaviour {

    /// <summary>
    /// Reference to the Text Componenet to the number to be round
    /// </summary>
    public Text NumToBeRound; 

	// Use this for initialization
	void Start () {
        double num =  Random.Range(-9999.9999f, -9999.9999f);
        NumToBeRound.text = num.ToString(); 
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
