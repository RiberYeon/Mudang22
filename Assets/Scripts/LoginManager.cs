using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using Firebase.Extensions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    private FirebaseAuth auth;  // 로그인, 회원가입에 사용
    private FirebaseUser user;  // 인증이 완료된 유저

    public InputField email;
    public InputField pw;
    public bool LoginCheck;
    public GameObject FailJoin;
    public GameObject SucJoin;
    public GameObject FailLogin;
    public GameObject JoinB;
    public GameObject LoginB;

    void Start()
    {
        auth = FirebaseAuth.DefaultInstance;
    }

    public void Create()
    {
        auth.CreateUserWithEmailAndPasswordAsync(email.text, pw.text).ContinueWithOnMainThread(task =>
        {
            if (!task.IsCanceled && !task.IsFaulted)
            {
                Debug.Log("회원가입완료");
                SucJoin.SetActive(true);
                if (FailJoin.activeSelf == true)
                {
                    FailJoin.SetActive(false);
                    SucJoin.SetActive(true);             
                }
                else
                {
                    SucJoin.SetActive(true);
                }
            }

            else
            {              
                Debug.Log("회원가입실패");
                // SceneManager.LoadScene("LoginScene");
                if (SucJoin.activeSelf == true)
                {
                    SucJoin.SetActive(false);
                    FailJoin.SetActive(true);
                }
                else
                {
                    FailJoin.SetActive(true);
                }
            }
        });
    }

    public void Login()
    {
        auth.SignInWithEmailAndPasswordAsync(email.text, pw.text).ContinueWithOnMainThread(task =>
        {
            if (task.IsCompleted && !task.IsCanceled && !task.IsFaulted)
            {
                Debug.Log("로그인 완료");
                LoginCheck = true;
                Debug.Log(LoginCheck);
                SceneManager.LoadScene("MenuScene");

            }

            else
            {
                Debug.Log("로그인 실패");
                LoginCheck = false;
                if(SucJoin.activeSelf)
                {
                    SucJoin.SetActive(false);
                    FailLogin.SetActive(true);
                }
                else if(FailJoin.activeSelf)
                {
                    FailJoin.SetActive(false);
                    FailLogin.SetActive(true);
                }
                else
                {
                    FailLogin.SetActive(true);
                }
                Debug.Log(LoginCheck);

            }
        });
    }
}
