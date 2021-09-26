using UnityEngine;


public class T_MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
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

public class T_Singleton<T> where T : T_Singleton<T>, new()
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            /// Debug.Log( "_instance is null = " + ( _instance == null ).ToString() );

            if( null == _instance )
            {
                _instance = new T();
            }

            return _instance;
        }
    }
}
