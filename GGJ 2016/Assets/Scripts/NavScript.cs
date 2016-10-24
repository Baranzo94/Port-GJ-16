using UnityEngine;
using System.Collections;

public class NavScript : MonoBehaviour {


		public GameObject Page1;
		public GameObject Page2;
	    public GameObject Page3;

		public GameObject Dialogue1;
		public GameObject Dialogue2;
		public GameObject Dialogue3;

		public int counter;

		public GameObject next;
		public GameObject back;
		public GameObject Play;
		// Use this for initialization

		void Start () {

			next.SetActive (true);
			back.SetActive (false);
			Play.SetActive (false);

			Page1.SetActive (true);
			Page2.SetActive (false);
			Page3.SetActive (false);

			Dialogue1.SetActive(true);
			Dialogue2.SetActive (false);
			Dialogue3.SetActive (false);

			counter = 0;
			}

			// Update is called once per frame
			void Update () {

			if (counter == 0) 

			{
			Play.SetActive (false);

			back.SetActive (false);
			next.SetActive (true);

			Page1.SetActive (true);
			Dialogue1.SetActive (true);

			Page2.SetActive (false);
			Dialogue2.SetActive (false);

			Page3.SetActive (false);
			Dialogue3.SetActive (false);

			}

			if (counter == 1) 

			{
			Play.SetActive (false);

			back.SetActive (true);
			next.SetActive (true);

			Page1.SetActive (false);
			Dialogue1.SetActive (false);

			Page2.SetActive (true);
			Dialogue2.SetActive (true);

			Page3.SetActive (false);
			Dialogue3.SetActive (false);
			}

		if (counter == 2) {

			Play.SetActive (true);

			back.SetActive (true);
			next.SetActive (false);

			Page1.SetActive (false);
			Dialogue1.SetActive (false);

			Page2.SetActive (false);
			Dialogue2.SetActive (false);

			Page3.SetActive (true);
			Dialogue3.SetActive (true);
		}
			if (counter == -1) 
			{
			counter = 0;

			Play.SetActive (false);

				back.SetActive (false);
				next.SetActive (true);

				Page1.SetActive (true);
				Dialogue1.SetActive (true);

				Page2.SetActive (false);
				Dialogue2.SetActive (false);

				Page3.SetActive (false);
				Dialogue3.SetActive (false);
			}


			}

			public void NextPress()
			{
			counter = counter + 1;
			}
			public void BackPress()
			{
			counter = counter - 1;
			}


			}


