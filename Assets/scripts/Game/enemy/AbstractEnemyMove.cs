using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractEnemyMove : MonoBehaviour
{
    protected Rigidbody2D _rb;
    protected Transform _targetTransform;
    protected Transform _transform;
    protected float _speed;

    public virtual void Init(Rigidbody2D rb, Transform transform, Transform target,float speed)
    {
        _rb = rb;
        _targetTransform = target;
        _transform = transform;
        _speed = speed;

    }

    public virtual void Move()
    {

    }
}
