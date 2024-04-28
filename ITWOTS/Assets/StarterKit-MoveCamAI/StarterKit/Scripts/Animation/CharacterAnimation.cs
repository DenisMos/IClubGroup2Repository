using UnityEngine;
using System.Collections;

public class CharacterAnimation : MonoBehaviour {

	// Public boolean for running animation
	public bool _animRun;
	public bool _animFig;

    // Animator variables
    private Animator anim;
	private string animRun = "Run";
	private string animFig = "Fig";

    void Start()
	{
		anim = GetComponent<Animator>();	// Get the animator component
	}
	
	void Update()
	{
		if(_animRun)	// If _animRun is true then continue
		{
			anim.SetBool(animFig, false);
			anim.SetBool(animRun, true);	// Set the animator Bool with the String Value of animRun to True
		}
		else	// If _animRun is false then continue
		{
			anim.SetBool(animRun, false);	// Set the animator Bool with the String Value of animRun to True
		}

		if (_animFig)
		{
            anim.SetBool(animRun, false);
			anim.SetBool(animFig, true);
        }
		else   
		{
			anim.SetBool(animFig, false);
		}
    }
	
}
