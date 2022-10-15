using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// RectTransform プロパティをキャッシュする MonoBehaviour
    /// </summary>
    public abstract class CacheableUIBehaviour : CacheableMonoBehaviour
    {
        //================================================================================
        // 変数
        //================================================================================
        private RectTransform m_rectTransformCache; // rectTransform プロパティのキャッシュ

        //================================================================================
        // プロパティ
        //================================================================================
        /// <summary>
        /// RectTransform を返します
        /// </summary>
        public RectTransform rectTransform
        {
            get
            {
                if ( m_rectTransformCache == null )
                {
                    m_rectTransformCache = GetComponent<RectTransform>();
                }

                return m_rectTransformCache;
            }
        }

        public Vector2 anchoredPosition { get => rectTransform.anchoredPosition; set => rectTransform.anchoredPosition = value; }
        public Vector2 offsetMax        { get => rectTransform.offsetMax;        set => rectTransform.offsetMax = value; }
        public Vector2 offsetMin        { get => rectTransform.offsetMin;        set => rectTransform.offsetMin = value; }
        public Vector2 anchorMin        { get => rectTransform.anchorMin;        set => rectTransform.anchorMin = value; }
        public Vector2 anchorMax        { get => rectTransform.anchorMax;        set => rectTransform.anchorMax = value; }
        public Vector2 pivot            { get => rectTransform.pivot;            set => rectTransform.pivot = value; }
        public Vector2 sizeDelta        { get => rectTransform.sizeDelta;        set => rectTransform.sizeDelta = value; }

        //================================================================================
        // anchoredPosition
        //================================================================================
        public void ResetAnchoredPosition()                   => anchoredPosition = Vector2.zero;
        public void SetAnchoredPositionX( float  x )          => anchoredPosition = new( x, anchoredPosition.y );
        public void SetAnchoredPositionY( float  y )          => anchoredPosition = new( anchoredPosition.x, y );
        public void SetAnchoredPosition( Vector2 v )          => anchoredPosition = v;
        public void SetAnchoredPosition( float   x, float y ) => anchoredPosition = new( x, y );
        public void AddAnchoredPositionX( float  x )          => anchoredPosition += new Vector2( x, 0 );
        public void AddAnchoredPositionY( float  y )          => anchoredPosition += new Vector2( 0, y );
        public void AddAnchoredPosition( Vector2 v )          => anchoredPosition += v;
        public void AddAnchoredPosition( float   x, float y ) => anchoredPosition += new Vector2( x, y );

        //================================================================================
        // offsetMax
        //================================================================================
        public void SetOffsetMaxX( float  x )          => offsetMax = new( x, offsetMax.y );
        public void SetOffsetMaxY( float  y )          => offsetMax = new( offsetMax.x, y );
        public void SetOffsetMax( Vector2 v )          => offsetMax = v;
        public void SetOffsetMax( float   x, float y ) => offsetMax = new( x, y );

        //================================================================================
        // offsetMin
        //================================================================================
        public void SetOffsetMinX( float  x )          => offsetMin = new( x, offsetMin.y );
        public void SetOffsetMinY( float  y )          => offsetMin = new( offsetMin.x, y );
        public void SetOffsetMin( Vector2 v )          => offsetMin = v;
        public void SetOffsetMin( float   x, float y ) => offsetMin = new( x, y );

        //================================================================================
        // anchorMin
        //================================================================================
        public void SetAnchorMinX( float  x )          => anchorMin = new( x, anchorMin.y );
        public void SetAnchorMinY( float  y )          => anchorMin = new( anchorMin.x, y );
        public void SetAnchorMin( Vector2 v )          => anchorMin = v;
        public void SetAnchorMin( float   x, float y ) => anchorMin = new( x, y );

        //================================================================================
        // anchorMax
        //================================================================================
        public void SetAnchorMaxX( float  x )          => anchorMax = new( x, anchorMax.y );
        public void SetAnchorMaxY( float  y )          => anchorMax = new( anchorMax.x, y );
        public void SetAnchorMax( Vector2 v )          => anchorMax = v;
        public void SetAnchorMax( float   x, float y ) => anchorMax = new( x, y );

        //================================================================================
        // pivot
        //================================================================================
        public void SetPivotX( float  x )          => pivot = new( x, pivot.y );
        public void SetPivotY( float  y )          => pivot = new( pivot.x, y );
        public void SetPivot( Vector2 v )          => pivot = v;
        public void SetPivot( float   x, float y ) => pivot = new( x, y );

        //================================================================================
        // sizeDelta
        //================================================================================
        public void SetSizeDeltaX( float  x )          => sizeDelta = new( x, sizeDelta.y );
        public void SetSizeDeltaY( float  y )          => sizeDelta = new( sizeDelta.x, y );
        public void SetSizeDelta( Vector2 v )          => sizeDelta = v;
        public void SetSizeDelta( float   x, float y ) => sizeDelta = new( x, y );
        public void AddSizeDeltaX( float  x )          => sizeDelta += new Vector2( x, 0 );
        public void AddSizeDeltaY( float  y )          => sizeDelta += new Vector2( 0, y );
        public void AddSizeDelta( Vector2 v )          => sizeDelta += v;
        public void AddSizeDelta( float   x, float y ) => sizeDelta += new Vector2( x, y );
    }
}