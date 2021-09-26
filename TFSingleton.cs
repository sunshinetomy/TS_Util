using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TFSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            /// Debug.Log( "_instance is null = " + ( _instance == null ).ToString() );

            if( null == _instance )
            {
                var newObj = new GameObject(typeof(T).ToString());
                _instance = newObj.AddComponent<T>();

                DontDestroyOnLoad( _instance );
            }

            return _instance;
        }
    }
}
