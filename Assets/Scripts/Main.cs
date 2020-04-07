using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main:MonoBehaviour{
	
	public Toggle m_autorotateToLandscapeLeftToggle;
	public Toggle m_autorotateToLandscapeRightToggle;
	public Toggle m_autorotateToPortraitToggle;
	public Toggle m_autorotateToPortraitUpsideDownToggle;
	
	public Dropdown m_dropdown;
	
	private void Awake(){
		m_autorotateToLandscapeLeftToggle.isOn=true;
		Screen.autorotateToLandscapeLeft=m_autorotateToLandscapeLeftToggle.isOn;
		
		m_autorotateToLandscapeRightToggle.isOn=true;
		Screen.autorotateToLandscapeRight=m_autorotateToLandscapeRightToggle.isOn;
		
		m_autorotateToPortraitToggle.isOn=true;
		Screen.autorotateToPortrait=m_autorotateToPortraitToggle.isOn;
		
		m_autorotateToPortraitUpsideDownToggle.isOn=true;
		Screen.autorotateToPortraitUpsideDown=m_autorotateToPortraitUpsideDownToggle.isOn;
		
		m_dropdown.value=(int)ScreenOrientation.AutoRotation;
		Screen.orientation=(ScreenOrientation)m_dropdown.value;
	}
	
	private void Update(){
		
	}
	
	public void OnAutorotateToLandscapeLeftValueChanged(bool value){
		Screen.autorotateToLandscapeLeft=value;
	}
	
	public void OnAutorotateToLandscapeRightValueChanged(bool value){
		Screen.autorotateToLandscapeRight=value;
	}
	
	public void OnAutorotateToPortraitValueChanged(bool value){
		Screen.autorotateToPortrait=value;
	}
	
	public void OnAutorotateToPortraitUpsideDownValueChanged(bool value){
		Screen.autorotateToPortraitUpsideDown=value;
	}
	
	public void OnDropdownValueChanged(){
		Screen.orientation=(ScreenOrientation)m_dropdown.value;
	}
}
