﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

  public void GotoElementsPage() {
		SceneManager.LoadScene("ElementsPage");
	}

  public void AddNewLocation() {
    SceneManager.LoadScene("NewLocation");
  }

}
