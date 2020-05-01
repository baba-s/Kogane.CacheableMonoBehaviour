# Uni Cacheable Mono Behaviour

Transform プロパティをキャッシュする MonoBehaviour

## 使用例

```cs
using UnityEngine;

public class Example : CacheableMonoBehaviour
{
    private void Start()
    {
        var vec = Vector3.zero;
        var x   = 0f;
        var y   = 0f;
        var z   = 0f;

        // transform.position を操作
        vec = position;
        x   = position.x;
        y   = position.y;
        z   = position.z;
        ResetPosition();
        SetPositionX( 1 );
        SetPositionY( 2 );
        SetPositionZ( 3 );
        SetPosition( 1, 2 );
        SetPosition( 1, 2, 3 );
        SetPosition( new Vector2( 1, 2 ) );
        SetPosition( new Vector3( 1, 2, 3 ) );
        AddPositionX( 1 );
        AddPositionY( 2 );
        AddPositionZ( 3 );
        AddPosition( 1, 2 );
        AddPosition( 1, 2, 3 );
        AddPosition( new Vector2( 1, 2 ) );
        AddPosition( new Vector3( 1, 2, 3 ) );
        
        // transform.localPosition を操作
        vec = localPosition;
        x   = localPosition.x;
        y   = localPosition.y;
        z   = localPosition.z;
        ResetLocalPosition();
        SetLocalPositionX( 1 );
        SetLocalPositionY( 2 );
        SetLocalPositionZ( 3 );
        SetLocalPosition( 1, 2 );
        SetLocalPosition( 1, 2, 3 );
        SetLocalPosition( new Vector2( 1, 2 ) );
        SetLocalPosition( new Vector3( 1, 2, 3 ) );
        AddLocalPositionX( 1 );
        AddLocalPositionY( 2 );
        AddLocalPositionZ( 3 );
        AddLocalPosition( 1, 2 );
        AddLocalPosition( 1, 2, 3 );
        AddLocalPosition( new Vector2( 1, 2 ) );
        AddLocalPosition( new Vector3( 1, 2, 3 ) );
        
        // transform.localScale を操作
        vec = localScale;
        x   = localScale.x;
        y   = localScale.y;
        z   = localScale.z;
        ResetLocalScale();
        SetLocalScaleX( 1 );
        SetLocalScaleY( 2 );
        SetLocalScaleZ( 3 );
        SetLocalScale( 1, 2 );
        SetLocalScale( 1, 2, 3 );
        SetLocalScale( new Vector2( 1, 2 ) );
        SetLocalScale( new Vector3( 1, 2, 3 ) );
        AddLocalScaleX( 1 );
        AddLocalScaleY( 2 );
        AddLocalScaleZ( 3 );
        AddLocalScale( 1, 2 );
        AddLocalScale( 1, 2, 3 );
        AddLocalScale( new Vector2( 1, 2 ) );
        AddLocalScale( new Vector3( 1, 2, 3 ) );
        
        // transform.eulerAngles を操作
        vec = eulerAngles;
        x   = eulerAngles.x;
        y   = eulerAngles.y;
        z   = eulerAngles.z;
        ResetEulerAngles();
        SetEulerAngleX( 1 );
        SetEulerAngleY( 2 );
        SetEulerAngleZ( 3 );
        SetEulerAngles( 1, 2, 3 );
        SetEulerAngles( new Vector2( 1, 2 ) );
        SetEulerAngles( new Vector3( 1, 2, 3 ) );
        AddEulerAngleX( 1 );
        AddEulerAngleY( 2 );
        AddEulerAngleZ( 3 );
        
        // transform.localEulerAngles を操作
        vec = localEulerAngles;
        x   = localEulerAngles.x;
        y   = localEulerAngles.y;
        z   = localEulerAngles.z;
        ResetLocalEulerAngles();
        SetLocalEulerAngleX( 1 );
        SetLocalEulerAngleY( 2 );
        SetLocalEulerAngleZ( 3 );
        SetLocalEulerAngles( 1, 2, 3 );
        SetLocalEulerAngles( new Vector2( 1, 2 ) );
        SetLocalEulerAngles( new Vector3( 1, 2, 3 ) );
        AddLocalEulerAngleX( 1 );
        AddLocalEulerAngleY( 2 );
        AddLocalEulerAngleZ( 3 );
    }
}
```