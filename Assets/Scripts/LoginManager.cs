using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Auth;
using Firebase.Extensions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    private FirebaseAuth auth;  // �α���, ȸ�����Կ� ���
    private FirebaseUser user;  // ������ �Ϸ�� ����

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
                Debug.Log("ȸ�����ԿϷ�");
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
                Debug.Log("ȸ�����Խ���");
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
                Debug.Log("�α��� �Ϸ�");
                LoginCheck = true;
                Debug.Log(LoginCheck);
                SceneManager.LoadScene("MenuScene");

            }

            else
            {
                Debug.Log("�α��� ����");
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
