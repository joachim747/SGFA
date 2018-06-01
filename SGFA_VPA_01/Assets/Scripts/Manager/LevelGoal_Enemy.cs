using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelGoal_Enemy : MonoBehaviour {

	public GameObject m_Zone;
	public List<GameObject> enemies = new List<GameObject>();
	public GameObject infobox;
	public Text message;

	private WaitForSeconds m_InfoWait = new WaitForSeconds(3f);

	// Use this for initialization
	void Start () {
		m_Zone.SetActive(false);
	}

	void Update(){
		foreach (GameObject go in enemies) {
			if(!go.active){
				enemies.Remove(go);
			}
		}

		switch(enemies.Count){
			case 0:
				handleMessage("All Enemies defeated. Zone is now reachable.");
				m_Zone.SetActive(true);
				break;
			case 1:
				handleMessage("One Enemy left");
				break;
			case 2:
				handleMessage("Two Enemies left");
				break;
		}
	}

	private IEnumerator handleMessage(string msg){
		message.text = msg;
		infobox.SetActive(true);
		yield return m_InfoWait;
		infobox.SetActive(false);
	}

	/* below code would be nicer but causes serious issues
	void Start () {
		m_Zone.SetActive(false);
		StartCoroutine(checkForCondition());
	}
	
	private IEnumerator checkForCondition(){
		while(!m_Zone.active){
			foreach (GameObject go in enemies) {
				if(!go.active){
					enemies.Remove(go);
				}
			}

			if(enemies.Count == 0){
				m_Zone.SetActive(true);
			}
		}

		yield return null;
	}
 */
}
