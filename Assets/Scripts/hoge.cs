using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoge : MonoBehaviour {

	GameObject aoi;
	GameObject mana;

	Transform aoiTr;
	Transform manaTr;

	bool isManaFront = true;
	bool wasManaFront = true;

	// Use this for initialization
	void Start () {
		aoi = GameObject.Find ("ImageTarget(1)");
		mana = GameObject.Find ("ImageTarget");

		aoiTr = aoi.transform;
		manaTr = mana.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		isManaFront = manaTr.position.z < aoiTr.position.z;
		if (isManaFront != wasManaFront) {
			//攻撃
		}
		wasManaFront = isManaFront;
	}
}
