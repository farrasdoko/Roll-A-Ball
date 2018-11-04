using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public GameObject menuPanel, howToPanel, CreditPanel;

	// Use this for initialization
	void Start () {
		menuPanel.SetActive (true);
		howToPanel.SetActive (false);
		CreditPanel.SetActive (false);
	}

	public void OnStartGameClicked() {
		SceneManager.LoadScene ("MiniGame");
	}

	public void HowToClicked(){
		menuPanel.SetActive (false);
		howToPanel.SetActive (true);
		CreditPanel.SetActive (false);
	}

	public void CreditsClicked(){
		menuPanel.SetActive (false);
		howToPanel.SetActive (false);
		CreditPanel.SetActive (true);
	}

	public void QuitClicked(){
		Application.Quit();
//		System.Environment.Exit(1);
	}

	public void OnBackClicked() {
		menuPanel.SetActive (true);
		howToPanel.SetActive (false);
		CreditPanel.SetActive (false);
	}
}
