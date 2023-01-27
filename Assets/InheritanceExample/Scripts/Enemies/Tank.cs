using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : EnemyBase
{
    private float _intiialSpeed;
    private float _timer = 1;
    private float _timerElapsed = 1;

    private void Start()
    {
        _intiialSpeed = MoveSpeed;
    }

    protected override void OnHit()
    {

        StartCoroutine("OnHitTimer");

    }

    IEnumerator OnHitTimer()
    {
        MoveSpeed = 0;
        _timerElapsed = 0;
        while (_timerElapsed < _timer)
        {
            yield return null;
            _timerElapsed += Time.deltaTime;
        }
        MoveSpeed = _intiialSpeed;
    }

}
