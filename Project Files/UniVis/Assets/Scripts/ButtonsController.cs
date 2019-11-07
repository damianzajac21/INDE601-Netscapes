using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{

  public void GotoElementsPage() {
		SceneManager.LoadScene("ElementPage");
	}

  public GameObject Panel;

  public void OpenPanel() {
    if(Panel != null) {
      bool isActive = Panel.activeSelf;

      Panel.SetActive(!isActive);
    }
  }
}
