using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;

public class GameDirector : Singleton<GameDirector>
{
	public int ScoreValue = 0;
	public Text ScoreText;
	public bool gameOver = false;
	public float PowerPelletTime = 2.0f;
	private float powerPelletCounter = 0.0f;
	public List<GhostController> Ghosts = new List<GhostController>();
    public Transform pelletsParent; //Added to keep a count of pellets.
    #region UpdateMovementStates
    public UnityEvent onScatter = new UnityEvent();
    public void addGhostScatter(UnityAction callback)
    {
        onScatter.AddListener(callback);
    }
    public void removeGhostScatter(UnityAction callback)
    {
        onScatter.RemoveListener(callback);
    }
    private void OnGhostScatter()
    {
        onScatter.Invoke();
    }
    public UnityEvent onChase = new UnityEvent();
    public void addGhostChase(UnityAction callback)
    {
        onChase.AddListener(callback);
    }
    public void removeGhostChase(UnityAction callback)
    {
        onChase.RemoveListener(callback);
    }
    private void OnGhostChase()
    {
        onChase.Invoke();
    }
    public UnityEvent onAfraid = new UnityEvent();
    public void addGhostAfraid(UnityAction callback)
    {
        onAfraid.AddListener(callback);
    }
    public void removeGhostAfraid(UnityAction callback)
    {
        onAfraid.RemoveListener(callback);
    }
    public void OnGhostAfraid()
    {
        onAfraid.Invoke();
        Invoke("OnGhostNotAfraid", PowerPelletTime);
    }
    public UnityEvent onNotAfraid = new UnityEvent();
    public void addGhostNotAfraid(UnityAction callback)
    {
        onNotAfraid.AddListener(callback);
    }
    public void removeGhostNotAfraid(UnityAction callback)
    {
        onNotAfraid.RemoveListener(callback);
    }
    private void OnGhostNotAfraid()
    {
        onNotAfraid.Invoke();
    }
    #endregion

    public enum States
	{
		enState_Normal,
		enState_PacmanInvincible,
		enState_GameOver,
	};
	public States state = States.enState_Normal;

	[System.Serializable]
	public class GameStateChangedEvent : UnityEvent<GameDirector.States> { }
	public GameStateChangedEvent GameStateChanged;

	void Start()
	{
		string formatString = System.String.Format("{0:D9}", ScoreValue);
		ScoreText.text = formatString;

        //Chase and Scatter alternation
        Invoke("OnGhostScatter", 0);
        Invoke("OnGhostChase", 7);
        Invoke("OnGhostScatter", 27);
        Invoke("OnGhostChase", 34);
        Invoke("OnGhostScatter", 54);
        Invoke("OnGhostChase", 59);
        Invoke("OnGhostScatter", 79);
        Invoke("OnGhostChase", 84);
	}

	public void IncreaseScore(int value)
	{
		ScoreValue += value;
		string formatString = System.String.Format("{0:D9}", ScoreValue);
		ScoreText.text = formatString;
	}

	public void ChangeGameState(States _newState)
	{
		state = _newState;
		switch (state)
		{
			case States.enState_Normal:
				powerPelletCounter = 0.0f;
				break;

			case States.enState_PacmanInvincible:
				powerPelletCounter = 0.0f;
				break;

			case States.enState_GameOver:
				gameOver = true;
				break;
		}
		GameStateChanged.Invoke(state);
	}

	public void Update()
	{
		switch(state)
		{
			case States.enState_PacmanInvincible:
				powerPelletCounter += Time.deltaTime;
				if (powerPelletCounter >= PowerPelletTime)
				{
					ChangeGameState(States.enState_Normal);
				}
				break;
		}
	}
}
