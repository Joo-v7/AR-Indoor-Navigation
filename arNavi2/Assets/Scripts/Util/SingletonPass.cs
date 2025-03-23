using UnityEngine;

/// <summary>
///  Awake에서 DontDestory 처리 
/// </summary>
/// <typeparam name="T">모노 상속 필요한 클래스</typeparam>
public class SingletonPass<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T Instance = null;
    public static T instance
    {
        get
        {
            if (Instance == null)
            {
                GameObject obj;
                obj = GameObject.Find(typeof(T).Name);

                if (obj == null)
                {
                    obj = new GameObject(typeof(T).Name);
                    Instance = obj.AddComponent<T>();
                }
                else
                {
                    Instance = obj.GetComponent<T>();
                }
            }
            return Instance;
        }
    }

    public virtual void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = gameObject.GetComponent<T>();

            //Debug.Log("CreateSingleton - " + typeof(T).Name);
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
