using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAction : MonoBehaviour
{
    public float speed = 2.0f;
    public GameManger manager;
    Rigidbody2D rigid;
    Animator anim;
    float h;
    float v;
    bool isHorizonMove;
    Vector3 dirVec;
    GameObject scanObject;
    ScoreController scoreController;
    GameManger gameManger;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        scoreController = FindObjectOfType<ScoreController>();
        gameManger = FindObjectOfType<GameManger>();
    }

    void Update()
    {
        // ����
        h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal");
        v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical");

        // ��ư �̵�
        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal");
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical");
        bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal");
        bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical");

        // ���� �
        if (hDown)
        {
            isHorizonMove = true;
        }
        else if (vDown || hUp)
        {
            isHorizonMove = false;
        }

        // Animation
        if (anim.GetInteger("hAxisRaw") != h)
        {
            anim.SetBool("IsChange", true);
            anim.SetInteger("hAxisRaw", (int)h);
        }
        else if (anim.GetInteger("vAxisRaw") != v)
        {
            anim.SetBool("IsChange", true);
            anim.SetInteger("vAxisRaw", (int)v);
        }
        else
        {
            anim.SetBool("IsChange", false);
        }

        // ����
        if (vDown && v == 1)
        {
            dirVec = Vector3.left;
        }
        else if (vDown && v == -1)
        {
            dirVec = Vector3.right;
        }
        else if (hDown && h == -1)
        {
            dirVec = Vector3.down;
        }
        else if (hDown && h == 1)
        {
            dirVec = Vector3.up;
        }

        // ��ĵ
        if (Input.GetKeyDown(KeyCode.Space) && scanObject != null)
        {
            // Debug.Log("�̰��� NPC�Դϴ�.");
            manager.Action(scanObject);
        }
        if (Input.GetKeyDown(KeyCode.Z) && scanObject != null && scanObject.name != "��Ÿ������" && scanObject.name != "��Ÿ������" && scanObject.name != "IT������" && scanObject.name != "��õ��������" && scanObject.name != "�ۼ�������" && scanObject.name != "�ߵ�������" && scanObject.name != "���Ǵ�������")
        {
            scoreController.Score();
            Destroy(scanObject);
        }
    }
    void FixedUpdate()
    {
        Vector2 moveVec = isHorizonMove ? new Vector2(h, 0) : new Vector2(0, v);
        rigid.velocity = moveVec*speed;

        Debug.DrawRay(rigid.position, dirVec * 0.8f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 0.8f, LayerMask.GetMask("Object"));

        if (rayHit.collider != null)
        {
            scanObject = rayHit.collider.gameObject;
        }
        else
        {
            scanObject = null;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(manager.Clear>=18)
        {
            Debug.Log("���� Ŭ����");
            SceneManager.LoadScene("ClearScene");
        }
    }
}
