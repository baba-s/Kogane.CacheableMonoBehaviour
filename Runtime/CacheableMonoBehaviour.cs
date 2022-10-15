using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// Transform プロパティをキャッシュする MonoBehaviour
    /// </summary>
    public abstract class CacheableMonoBehaviour : MonoBehaviour
    {
        //================================================================================
        // 変数
        //================================================================================
        private Transform m_transformCache; // transform プロパティのキャッシュ

        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// Transform を返します
        /// </summary>
        public new Transform transform
        {
            get
            {
                if ( m_transformCache == null )
                {
                    m_transformCache = base.transform;
                }

                return m_transformCache;
            }
        }

        /// <summary>
        /// ワールド座標における位置を取得または設定します
        /// </summary>
        public Vector3 position { get => transform.position; set => transform.position = value; }

        /// <summary>
        /// ワールド座標における回転角を取得または設定します
        /// </summary>
        public Quaternion rotation { get => transform.rotation; set => transform.rotation = value; }

        /// <summary>
        /// ワールド座標における回転角を取得または設定します
        /// </summary>
        public Vector3 eulerAngles { get => transform.eulerAngles; set => transform.eulerAngles = value; }

        /// <summary>
        /// ローカル座標における位置を取得または設定します
        /// </summary>
        public Vector3 localPosition { get => transform.localPosition; set => transform.localPosition = value; }

        /// <summary>
        /// ローカル座標における回転角を取得または設定します
        /// </summary>
        public Quaternion localRotation { get => transform.localRotation; set => transform.localRotation = value; }

        /// <summary>
        /// ローカル座標における回転角を取得または設定します
        /// </summary>
        public Vector3 localEulerAngles { get => transform.localEulerAngles; set => transform.localEulerAngles = value; }

        /// <summary>
        /// ローカル座標におけるスケーリング値を取得または設定します
        /// </summary>
        public Vector3 localScale { get => transform.localScale; set => transform.localScale = value; }

        //================================================================================
        // ワールド座標における位置
        //================================================================================
        /// <summary>
        /// ワールド座標における位置をリセットします
        /// </summary>
        public void ResetPosition()
        {
            transform.position = Vector3.zero;
        }

        /// <summary>
        /// ワールド座標における X 座標を設定します
        /// </summary>
        public void SetPositionX( float x )
        {
            var pos = transform.position;
            pos = new
            (
                x,
                pos.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Y 座標を設定します
        /// </summary>
        public void SetPositionY( float y )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x,
                y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Z 座標を設定します
        /// </summary>
        public void SetPositionZ( float z )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x,
                pos.y,
                z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector2 型でワールド座標における位置を設定します
        /// </summary>
        public void SetPosition( Vector2 v )
        {
            transform.position = new
            (
                v.x,
                v.y,
                transform.position.z
            );
        }

        /// <summary>
        /// Vector3 型でワールド座標における位置を設定します
        /// </summary>
        public void SetPosition( Vector3 v )
        {
            transform.position = v;
        }

        /// <summary>
        /// ワールド座標における位置を設定します
        /// </summary>
        public void SetPosition( float x, float y )
        {
            transform.position = new
            (
                x,
                y,
                transform.position.z
            );
        }

        /// <summary>
        /// ワールド座標における位置を設定します
        /// </summary>
        public void SetPosition( float x, float y, float z )
        {
            transform.position = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ワールド座標における X 座標に加算します
        /// </summary>
        public void AddPositionX( float x )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Y 座標に加算します
        /// </summary>
        public void AddPositionY( float y )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x,
                pos.y + y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における Z 座標に加算します
        /// </summary>
        public void AddPositionZ( float z )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x,
                pos.y,
                pos.z + z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector2 型でワールド座標における位置を加算します
        /// </summary>
        public void AddPosition( Vector2 v )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x + v.x,
                pos.y + v.y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// Vector3 型でワールド座標における位置を加算します
        /// </summary>
        public void AddPosition( Vector3 v )
        {
            transform.position += v;
        }

        /// <summary>
        /// ワールド座標における位置を加算します
        /// </summary>
        public void AddPosition( float x, float y )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z
            );
            transform.position = pos;
        }

        /// <summary>
        /// ワールド座標における位置を加算します
        /// </summary>
        public void AddPosition( float x, float y, float z )
        {
            var pos = transform.position;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z + z
            );
            transform.position = pos;
        }

        //================================================================================
        // ローカル座標における位置
        //================================================================================
        /// <summary>
        /// ローカル座標における位置をリセットします
        /// </summary>
        public void ResetLocalPosition()
        {
            transform.localPosition = Vector3.zero;
        }

        /// <summary>
        /// ローカル座標における X 座標を設定します
        /// </summary>
        public void SetLocalPositionX( float x )
        {
            var pos = transform.localPosition;
            pos = new
            (
                x,
                pos.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Y 座標を設定します
        /// </summary>
        public void SetLocalPositionY( float y )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x,
                y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Z 座標を設定します
        /// </summary>
        public void SetLocalPositionZ( float z )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y,
                z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector2 型でローカル座標における位置を設定します
        /// </summary>
        public void SetLocalPosition( Vector2 v )
        {
            transform.localPosition = new
            (
                v.x,
                v.y,
                transform.localPosition.z
            );
        }

        /// <summary>
        /// Vector3 型でローカル座標における位置を設定します
        /// </summary>
        public void SetLocalPosition( Vector3 v )
        {
            transform.localPosition = v;
        }

        /// <summary>
        /// ローカル座標における位置を設定します
        /// </summary>
        public void SetLocalPosition( float x, float y )
        {
            transform.localPosition = new
            (
                x,
                y,
                transform.localPosition.z
            );
        }

        /// <summary>
        /// ローカル座標における位置を設定します
        /// </summary>
        public void SetLocalPosition( float x, float y, float z )
        {
            transform.localPosition = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 座標に加算します
        /// </summary>
        public void AddLocalPositionX( float x )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Y 座標に加算します
        /// </summary>
        public void AddLocalPositionY( float y )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y + y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における Z 座標に加算します
        /// </summary>
        public void AddLocalPositionZ( float z )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x,
                pos.y,
                pos.z + z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector2 型でローカル座標における位置を加算します
        /// </summary>
        public void AddLocalPosition( Vector2 v )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x + v.x,
                pos.y + v.y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// Vector3 型でローカル座標における位置を加算します
        /// </summary>
        public void AddLocalPosition( Vector3 v )
        {
            transform.localPosition += v;
        }

        /// <summary>
        /// ローカル座標における位置を加算します
        /// </summary>
        public void AddLocalPosition( float x, float y )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z
            );
            transform.localPosition = pos;
        }

        /// <summary>
        /// ローカル座標における位置を加算します
        /// </summary>
        public void AddLocalPosition( float x, float y, float z )
        {
            var pos = transform.localPosition;
            pos = new
            (
                pos.x + x,
                pos.y + y,
                pos.z + z
            );
            transform.localPosition = pos;
        }

        //================================================================================
        // ワールド座標における回転角
        //================================================================================
        /// <summary>
        /// ワールド座標における回転角をリセットします
        /// </summary>
        public void ResetEulerAngles()
        {
            transform.eulerAngles = Vector3.zero;
        }

        /// <summary>
        /// ワールド座標における X 軸方向の回転角を設定します
        /// </summary>
        public void SetEulerAngleX( float x )
        {
            var angles = transform.eulerAngles;
            angles = new
            (
                x,
                angles.y,
                angles.z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における Y 軸方向の回転角を設定します
        /// </summary>
        public void SetEulerAngleY( float y )
        {
            var angles = transform.eulerAngles;
            angles = new
            (
                angles.x,
                y,
                angles.z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における Z 軸方向の回転角を設定します
        /// </summary>
        public void SetEulerAngleZ( float z )
        {
            var angles = transform.eulerAngles;
            angles = new
            (
                angles.x,
                angles.y,
                z
            );
            transform.eulerAngles = angles;
        }

        /// <summary>
        /// ワールド座標における回転角を設定します
        /// </summary>
        public void SetEulerAngles( Vector3 v )
        {
            transform.eulerAngles = v;
        }

        /// <summary>
        /// ワールド座標における回転角を設定します
        /// </summary>
        public void SetEulerAngles( float x, float y, float z )
        {
            transform.eulerAngles = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ワールド座標における X 軸方向の回転角を加算します
        /// </summary>
        public void AddEulerAngleX( float x )
        {
            transform.Rotate( x, 0, 0, Space.World );
        }

        /// <summary>
        /// ワールド座標における Y 軸方向の回転角を加算します
        /// </summary>
        public void AddEulerAngleY( float y )
        {
            transform.Rotate( 0, y, 0, Space.World );
        }

        /// <summary>
        /// ワールド座標における Z 軸方向の回転角を加算します
        /// </summary>
        public void AddEulerAngleZ( float z )
        {
            transform.Rotate( 0, 0, z, Space.World );
        }

        //================================================================================
        // ローカル座標における回転角
        //================================================================================
        /// <summary>
        /// ローカル座標における回転角をリセットします
        /// </summary>
        public void ResetLocalEulerAngles()
        {
            transform.localEulerAngles = Vector3.zero;
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を設定します
        /// </summary>
        public void SetLocalEulerAngleX( float x )
        {
            var angles = transform.localEulerAngles;
            angles = new
            (
                x,
                angles.y,
                angles.z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向の回転角を設定します
        /// </summary>
        public void SetLocalEulerAngleY( float y )
        {
            var angles = transform.localEulerAngles;
            angles = new
            (
                angles.x,
                y,
                angles.z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向の回転角を設定します
        /// </summary>
        public void SetLocalEulerAngleZ( float z )
        {
            var angles = transform.localEulerAngles;
            angles = new
            (
                angles.x,
                angles.y,
                z
            );
            transform.localEulerAngles = angles;
        }

        /// <summary>
        /// ローカル座標における回転角を設定します
        /// </summary>
        public void SetLocalEulerAngles( Vector3 v )
        {
            transform.localEulerAngles = v;
        }

        /// <summary>
        /// ローカル座標における回転角を設定します
        /// </summary>
        public void SetLocalEulerAngles( float x, float y, float z )
        {
            transform.localEulerAngles = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を加算します
        /// </summary>
        public void AddLocalEulerAngleX( float x )
        {
            transform.Rotate( x, 0, 0, Space.Self );
        }

        /// <summary>
        /// ローカル座標における Y 軸方向の回転角を加算します
        /// </summary>
        public void AddLocalEulerAngleY( float y )
        {
            transform.Rotate( 0, y, 0, Space.Self );
        }

        /// <summary>
        /// ローカル座標における X 軸方向の回転角を加算します
        /// </summary>
        public void AddLocalEulerAngleZ( float z )
        {
            transform.Rotate( 0, 0, z, Space.Self );
        }

        //================================================================================
        // ローカル座標におけるスケーリング値
        //================================================================================
        /// <summary>
        /// ローカル座標におけるスケーリング値をリセットします
        /// </summary>
        public void ResetLocalScale()
        {
            transform.localScale = Vector3.one;
        }

        /// <summary>
        /// ローカル座標における X 軸方向のスケーリング値を設定します
        /// </summary>
        public void SetLocalScaleX( float x )
        {
            var scale = transform.localScale;
            scale = new
            (
                x,
                scale.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向のスケーリング値を設定します
        /// </summary>
        public void SetLocalScaleY( float y )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x,
                y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向のスケーリング値を設定します
        /// </summary>
        public void SetLocalScaleZ( float z )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y,
                z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector2 型でローカル座標におけるスケーリング値を設定します
        /// </summary>
        public void SetLocalScale( Vector2 v )
        {
            transform.localScale = new
            (
                v.x,
                v.y,
                transform.localScale.z
            );
        }

        /// <summary>
        /// Vector3 型でローカル座標におけるスケーリング値を設定します
        /// </summary>
        public void SetLocalScale( Vector3 v )
        {
            transform.localScale = v;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を設定します
        /// </summary>
        public void SetLocalScale( float x, float y )
        {
            transform.localScale = new
            (
                x,
                y,
                transform.localScale.z
            );
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を設定します
        /// </summary>
        public void SetLocalScale( float x, float y, float z )
        {
            transform.localScale = new
            (
                x,
                y,
                z
            );
        }

        /// <summary>
        /// ローカル座標における X 軸方向のスケーリング値を加算します
        /// </summary>
        public void AddLocalScaleX( float x )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Y 軸方向のスケーリング値を加算します
        /// </summary>
        public void AddLocalScaleY( float y )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y + y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標における Z 軸方向のスケーリング値を加算します
        /// </summary>
        public void AddLocalScaleZ( float z )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x,
                scale.y,
                scale.z + z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector2 型でローカル座標におけるスケーリング値を加算します
        /// </summary>
        public void AddLocalScale( Vector2 v )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x + v.x,
                scale.y + v.y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// Vector3 型でローカル座標におけるスケーリング値を加算します
        /// </summary>
        public void AddLocalScale( Vector3 v )
        {
            transform.localScale += v;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を加算します
        /// </summary>
        public void AddLocalScale( float x, float y )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y + y,
                scale.z
            );
            transform.localScale = scale;
        }

        /// <summary>
        /// ローカル座標におけるスケーリング値を加算します
        /// </summary>
        public void AddLocalScale( float x, float y, float z )
        {
            var scale = transform.localScale;
            scale = new
            (
                scale.x + x,
                scale.y + y,
                scale.z + z
            );
            transform.localScale = scale;
        }
    }
}